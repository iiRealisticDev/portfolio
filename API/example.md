# Save the folder, open it in something like Visual Studio Code, then run `npm start`. Then run a GET request: (from within the server.js file on the client)
```javascript
fetch("/?key=key1")
  .then((res) => res.json())
  .then((data) => {
    console.log(data); // true
  });
```
