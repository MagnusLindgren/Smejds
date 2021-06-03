﻿// Script för att generera chatbubblor
export { sendChatBubble, receiveChatBubble };

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

function sendChatBubble(message) {

    const chatbox = document.querySelector(".chat-box");

    const sent = document.createElement("div");
    const text = document.createElement("p");

    chatbox.append(sent);
    sent.append(text);

    // Auto scroll
    sent.scrollIntoView();

    text.textContent = message;

    sent.classList.add("sent");
}

function receiveChatBubble(message, user) {
    const chatbox = document.querySelector(".chat-box");

    const received = document.createElement("div");
    const text = document.createElement("p");

    chatbox.append(received);
    received.append(text);

    // Auto scroll
    received.scrollIntoView();

    text.textContent = `${user}: ${message}`;

    received.classList.add("recieved");
}