namespace HelloWorld;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoSize = true;
        this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Password Generator";
        this.BackColor = Color.FromArgb(78,78,78);

        
        
        var title = new Label();
        title.TabIndex = 0;
        title.Name = "title";
        title.TabIndex = 0;
        title.Size = new Size(100,20);
        this.Controls.Add(title);
        title.AutoSize = true;
        title.Anchor = AnchorStyles.Top;
        title.Text = "Password Generator";
        title.Font = new Font("Aria", 24);
        title.Scale(new SizeF(10.5F,10.5F));
    }


    #endregion
}
