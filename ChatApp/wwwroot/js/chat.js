"use strict";
import { sendChatBubble, receiveChatBubble } from "./modules/chatbubble.js";
var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
//document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    receiveChatBubble(message, user);
});

connection.start();

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