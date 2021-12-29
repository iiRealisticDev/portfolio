const levelup = require("levelup"); // require levelup
const leveldown = require("leveldown"); // require leveldown
/**
 * @type {levelup.LevelUp} // sets the type for the "db" variable for better intellisense
 */
const db = levelup(leveldown("./db")); // makes a DB in this directory under a new directory called "db"

// make a new key in the database called "test1" with a value of "test2", the callback checks if there
// was an error doing so, and if there is, it'll throw an error.
db.put("test1", "value1", function (err) {
    if (err) throw new Error(err);
});

// gets a value from within the database called "test1", the callback includes a possible error
// and the value.
db.get("test1", function (err, val) {
    if (err) throw new Error(err);
    console.log("test1=" + val); // outputs: test1=value1
});

// testing with objects, same as the new key test above, just using a stringified version of a json object.
let obj = {
    name: "TestName",
    age: 20
}
db.put("object1", JSON.stringify(obj), function (err) {
    if (err) throw new Error(err);
});

db.get("object1", function (err, val) {
    if (err) throw new Error(err);
    val = JSON.parse(val); // turns the JSON String into a JSON Object
    console.log(val); // outputs the value
    let currVal = val; // make a new variable with the current information, for readability
    currVal.Country = "Germany"; // add a key called "Country" to the object, with the value of "Germany"
    db.put("object1", JSON.stringify(currVal), function (err) { // same as the previous put examples
        if (err) throw new Error(err);
        db.get("object1", function (err, val) {
            if (err) throw new Error(err);
            val = JSON.parse(val); // the value will be a buffer, so we must convert it to JSON
            console.log(val); // outputs the new value
        });
    });
});
