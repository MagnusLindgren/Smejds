export { generateRoom }

function generateRoom() {
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

    friendName.textContent = "groupName";

    chatBoxMain.classList.add("col-8","chat-box-main");
    box.classList.add("position-relative","h-100");
    chatFriend.classList.add("chat-friend", "position-absolute","w-100");
    chatFriendBack.classList.add("chat-friend-background");
    profilePic.classList.add("profile-pic-content-L");
    friendName.classList.add("friend-name-large");

    chatBox.classList.add("chat-box");
    chatInputBox.classList.add("chat-text", "position-absolute", "w-100");
    chatInputText.setAttribute("id", "txtChatBox");
}