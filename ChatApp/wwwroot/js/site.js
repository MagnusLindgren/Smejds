// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//import { generateRoom } from "./modules/chatroom.js";
/*
$("#txtChatBox").keypress(function (e) {
    if (e.which === 13 && !e.shiftKey) {
        e.preventDefault();

        $(this).closest("form").submit();
    }
});*/

/*function generateRoom(groupName) {
    const main = document.querySelector(".main-box");

    const chatBoxMain = document.createElement("div");
    const box = document.createElement("div");
    const chatFriend = document.createElement("div");
    const chatFriendBack = document.createElement("div");
    const profilePic = document.createElement("div");
    const friendName = document.createElement("p");

    const chatBox = document.createElement("div");
    const chatInputBox = document.createElement("div");
    const chatInputText = document.createElement("textarea");

    main.append(chatBoxMain);
    chatBoxMain.append(box);
    box.append(chatFriend);
    chatFriend.append(chatFriendBack);
    chatFriend.append(profilePic);
    profilePic.append(friendName);

    box.append(chatBox);
    box.append(chatInputBox);
    chatInputBox.append(chatInputText);

    chatInputText.rows = "1";

    friendName.textContent = groupName;

    chatBoxMain.classList.add("col-8", "chat-box-main");
    box.classList.add("position-relative", "h-100");
    chatFriend.classList.add("chat-friend", "position-absolute", "w-100");
    chatFriendBack.classList.add("chat-friend-background");
    profilePic.classList.add("profile-pic-content-L");
    friendName.classList.add("friend-name-large");
    friendName.setAttribute("id", "groupName")

    chatBox.classList.add("chat-box");
    chatInputBox.classList.add("chat-text", "position-absolute", "w-100");
    chatInputText.setAttribute("id", "txtChatBox");
}


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
function clearRoom(clear) {
    for (var i = 0; i < clear.length; i++) {
        clear[i].remove();
    }
}

function myFunction(value) {
    let getId = $(value).attr('id')
    //alert($(value).attr('id'));
    let chatRoom = document.querySelectorAll(".chat-box-main");
    clearRoom(chatRoom);
    generateRoom(getId);
    executeChat();
}*/














const colorThief = new ColorThief();
const img = new Image();

img.addEventListener('load', function () {
    colorThief.getColor(img);
});

img.crossOrigin = 'Anonymous';
img.src = 'https://res.cloudinary.com/crunchbase-production/image/upload/c_lpad,f_auto,q_auto:eco/v1440924046/wi1mlnkbn2jluko8pzkj.png'