namespace Todo;
using LiteDB;

public class Task
{
    public int Id { get; set; }
    public string Title { get; set; } = "Task Title";
    public string Description { get; set; } = "Task Description";
    public bool Completed { get; set; } = false;
}

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        string currPath = Directory.GetCurrentDirectory();
        var db = new LiteDatabase($"{currPath}/test.db");
        var collection = db.GetCollection<Task>("tasks");
        var testTask = new Task
        {
            Title = "TestTask",
            Description = "Make ToDo List work"
        };
        collection.Insert(testTask);
        var res = collection.Query().Where(entry => entry.Completed == false);
        var resArray = res.ToArray();
        layoutPanel.SuspendLayout();
        foreach (Task t in resArray)
        {
            var taskLb = new Label();
            taskLb.AutoSize = true;
            taskLb.Text = t.Title + "\n" + t.Description;
            taskLb.TextAlign = ContentAlignment.TopCenter;
            layoutPanel.Controls.Add(taskLb);
        }
        layoutPanel.ResumeLayout(false);
    }
}
