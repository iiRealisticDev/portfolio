const express = require("express");
const app = express();
const data = require("./data.json");
console.log(data);

app.listen(200);

app.use(express.static(__dirname + "/public"))

app.get("/", function (req, res) {
    let q = req.query;
    let key = q.key;
    if (!data[id]) {
        return res.status(404).send({
            messgae: "Error: Key not found."
        })
    } else {
        return res.status(200).send(data[key]);
    }
});