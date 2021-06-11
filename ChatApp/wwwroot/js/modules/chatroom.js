export { generateRoom }

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
connection.start();

function generateRoom(groupName) {
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

    chatBoxMain.classList.add("col-8","chat-box-main");
    box.classList.add("position-relative","h-100");
    chatFriend.classList.add("chat-friend", "position-absolute","w-100");
    chatFriendBack.classList.add("chat-friend-background");
    profilePic.classList.add("profile-pic-content-L");
    friendName.classList.add("friend-name-large");
    friendName.setAttribute("id", "groupName")

    chatBox.classList.add("chat-box");
    chatInputBox.classList.add("chat-text", "position-absolute", "w-100");
    chatInputText.setAttribute("id", "txtChatBox");

connection.invoke("GetMessageHistory", groupName).catch(function (err) {
    return console.error(err.toString());
});
}

connection.on("receiveHistory", function (chatMessagesJson) {
    const main = document.querySelector(".chat-box-main");

    const chatBoxMain = document.createElement("p");

    main.append(chatBoxMain)

    chatBoxMain.innerText = chatMessagesJson[1].MessageText;

    console.log(chatMessagesJson);
})
