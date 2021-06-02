// Script för att generera chatbubblor
export { createChatBubble };

function createChatBubble(message) {

    const chatbox = document.querySelector(".chat-box");

    const sent = document.createElement("div");
    const recived = document.createElement("div");
    const text = document.createElement("p");

    chatbox.append(sent);
    sent.append(text);

    text.textContent = message;

    sent.classList.add("sent");
}