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
// using ApplicationDbContext;
using ChatApp.Data;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public ChatHub (ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task SendMessage(string user, string message, string groupName)        
        {
            user = Context.User.Identity.Name;
            //await AddToGroup(groupName).ConfigureAwait(false);
            await Clients.OthersInGroup(groupName).SendAsync("ReceiveMessage", user, message);

            await SaveMessagesToDatabase(user, message, groupName);
        }

        public Task SendMessageToGroup(string groupName, string user, string message)
        {
            return Clients.Group(groupName).SendAsync("ReceiveMessage", user, message);
        }
        public async Task AddToGroup(string groupName)
        {
            var user = Context.User.Identity.Name;

            await SaveGroupToDatabase(user, groupName);

            var message = $" has joined the group { groupName}.";
            
            await Clients.OthersInGroup(groupName).SendAsync("ReceiveMessage", user, message);
        }
        

        public async Task SaveMessagesToDatabase(string user, string message, string groupName)
        {
            var userModel = await _context.Users.FirstOrDefaultAsync(o => o.UserName == user);
            ChatRoom chatRoomModel = _context.ChatRooms.Include(m => m.Users).FirstOrDefault(o => o.Name == groupName);

            ChatMessage chatMessage = new ChatMessage()
            {
                MessageText = message,
                Users = userModel,
                Timestamp = DateTime.Now,
                ChatRoom = chatRoomModel
            };

            await _context.ChatMessages.AddAsync(chatMessage);
            await _context.SaveChangesAsync();
        }

        public async Task SaveGroupToDatabase(string user, string groupName)
        {
            var userModel = await _context.Users.FirstOrDefaultAsync(o => o.UserName == user);

            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);

            ChatRoom chatRoomModel = _context.ChatRooms.Include(m => m.Users).FirstOrDefault(o => o.Name == groupName);

            if (chatRoomModel == null)
            {
                ChatRoom chatRoomToModel = new ChatRoom()
                {
                    Name = groupName,
                    Created_at_date = DateTime.Now,
                    Users = new List<User>() { userModel }
                };
                await _context.ChatRooms.AddAsync(chatRoomToModel);
                await _context.SaveChangesAsync();
            }
            else
            {
                if (!chatRoomModel.Users.Contains(userModel))
                {
                    chatRoomModel.Users.Add(userModel);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
}
