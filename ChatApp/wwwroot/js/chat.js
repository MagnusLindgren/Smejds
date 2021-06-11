//"use strict";
import { sendChatBubble, receiveChatBubble } from "./modules/chatbubble.js";
import { generateRoom } from "./modules/chatroom.js";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

connection.start();

/*
let createGroupButton = document.getElementById("create-group");
createGroupButton.addEventListener("click", function() {
    let chatRoom = document.querySelectorAll(".chat-box-main");
    let groupName = document.getElementById("create-group-name").value;
    clearRoom(chatRoom);
    generateRoom(groupName);
    executeChat();
});
*/
let joinRoomButton = document.getElementById("join-room");
joinRoomButton.addEventListener("click", function (event) {
    if (document.querySelector(".main-box").contains(document.getElementById("groupName"))) {
        let groupName = document.getElementById("groupName").innerText;
        connection.invoke("RemoveFromGroup", groupName);
    };
    var groupName = document.getElementById("join-group-name").value;
    connection.invoke("AddToGroup", groupName).catch(function (err) {
        return console.error(err.toString());
    });
    let chatRoom = document.querySelectorAll(".chat-box-main");
    clearRoom(chatRoom);
    generateRoom(groupName);
    executeChat();
});

function myFunction(value) {    
    //alert($(value).attr('id'));

    if (document.querySelector(".main-box").contains(document.getElementById("groupName"))) {
        let groupName = document.getElementById("groupName").innerText;
        connection.invoke("RemoveFromGroup", groupName);
    };
    let getId = $(value).attr('id');
    connection.invoke("AddToGroup", getId).catch(function (err) {
        return console.error(err.toString());
    });
    
    let chatRoom = document.querySelectorAll(".chat-box-main");
    clearRoom(chatRoom);
    generateRoom(getId);
    executeChat();
}

window.myFunction = myFunction;

//in send button until connection is established
//document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    console.log("ReceiveMessage Test")
    receiveChatBubble(user, message);
});

function executeChat() {
    document.getElementById("txtChatBox").addEventListener("keydown", function (event) {
        if (event.keyCode == 13 && !event.shiftKey) {
            event.preventDefault();
            var message = document.getElementById("txtChatBox").value;
            var groupName = document.getElementById("groupName").innerText;
            var user = "Dork"; //document.getElementById("userInput").value;
            if (message != null && message != "") {
                document.getElementById("txtChatBox").value = "";                
                sendChatBubble(message);
                connection.invoke("SendMessage", user, message, groupName).catch(function (err) {
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

