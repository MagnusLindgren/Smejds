// Script för att generera chatbubblor

function createChatBubble(message) {
    const chatbox = document.querySelector(".chat-box");

    const sent = docment.createElement("div");
    const recived = document.createElement("div");
    const text = document.createElement("p");

    chatbox.append(sent);
    sent.append(text);

    text.innerHTML(message);

    sent.classlist.add("sent");
}