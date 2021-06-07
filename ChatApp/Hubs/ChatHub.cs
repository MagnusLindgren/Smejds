using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
//using ChatApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using ChatApp.Models;

namespace ChatApp.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message, string groupName)        
        {
            user = Context.User.Identity.Name;
            
            await Clients.OthersInGroup(groupName).SendAsync("ReceiveMessage", user, message);
        }

        public Task SendMessageToGroup(string groupName, string user, string message)
        {
            return Clients.Group(groupName).SendAsync("ReceiveMessage", user, message);
        }
        public async Task AddToGroup(string groupName)
        {
            //user = Context.User.Identity.Name;

            await Groups.AddToGroupAsync(Context.ConnectionId, groupName); // Byta ut Connection ID... till en annan User...

            await Clients.OthersInGroup(groupName).SendAsync("ReceiveMessage", $"{Context.ConnectionId} has joined the group {groupName}.");
        }

        /////////////////////////////////////////////////
  /*      public async Task PrivateMessage(string user, string message)
        {
            await Clients.Caller.SendAsync("SendMessage", user, message);

        } */




        // Få ut ett unikt COnnectionID från varje användare, sen jämnför användarens ConnectionID med inkomande COnnectionID, så om det stämmer så är det till höger i chaten och är det fel så ska dte läggas till vänster
    }
}
