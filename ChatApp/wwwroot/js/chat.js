"use strict";
import { sendChatBubble, receiveChatBubble } from "./modules/chatbubble.js";
import { generateRoom } from "./modules/chatroom.js";
var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

let addButton = document.getElementById("create-group")
addButton.addEventListener("click", function() {
    let chatRoom = document.querySelectorAll(".chat-box-main");
    let groupName = document.getElementById("create-group-name").value;
    clearRoom(chatRoom);
    generateRoom(groupName);
    executeChat();
});



//Disable send button until connection is established
//document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    receiveChatBubble(message, user);
});

connection.start();

function executeChat() {
    document.getElementById("txtChatBox").addEventListener("keydown", function (event) {
        if (event.keyCode == 13 && !event.shiftKey) {
            event.preventDefault();
            var message = document.getElementById("txtChatBox").value;
            var user = "Dork" //document.getElementById("userInput").value;
            if (message != null && message != "") {
                document.getElementById("txtChatBox").value = "";
                sendChatBubble(message);
                connection.invoke("SendMessage", user, message).catch(function (err) {
                    return console.error(err.toString());
                });
            }
        }
    });
}

/*
document.getElementById("txtChatBox").addEventListener("keyup", function (event) {
    if (event.key === 'Enter') {
        var user = "Dork" //document.getElementById("userInput").value;
        var message = document.getElementById("txtChatBox").value;
        document.getElementById("txtChatBox").value = "";
        sendChatBubble(message);
        connection.invoke("SendMessage", user, message).catch(function (err) {
            return console.error(err.toString());
        });
    }
    event.preventDefault();
});*/
/*
document.getElementById("txtChatBox").addEventListener("keyup", function (event) {
    if (event.key === 'Enter') {
        var user = "You" //document.getElementById("userInput").value;
        var message = document.getElementById("txtChatBox").value;
        document.getElementById("txtChatBox").value = "";
        var li = document.createElement("li");
        document.getElementById("messageList").appendChild(li);
        li.textContent = `${user}: ${message}`;
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
});*/

function clearRoom(clear) {
    for (var i = 0; i < clear.length; i++) {
        clear[i].remove();
    }
}

