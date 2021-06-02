"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
//document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
    document.getElementById("messageList").appendChild(li);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    li.textContent = `${user}: ${message}`;
});

connection.start();

document.getElementById("txtChatBox").addEventListener("keyup", function (event) {
    if (event.key === 'Enter') {
        var user = "Dork" //document.getElementById("userInput").value;
        var message = document.getElementById("txtChatBox").value;
        document.getElementById("txtChatBox").value = "";
        connection.invoke("SendMessage", user, message).catch(function (err) {
            return console.error(err.toString());
        });
    }
    event.preventDefault();
});

/*
document.getElementById("sendButtonGroup").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    var groupName = document.getElementById("joinGroupText").value;
    document.getElementById("messageInput").value = "";
    connection.invoke("SendMessageToGroup", groupName, user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

document.getElementById("joinGroup").addEventListener("click", function (event) {
    var groupName = document.getElementById("joinGroupText").value;
    connection.invoke("AddToGroup", groupName).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});
*/