using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class ChatMessage
    {
        public int Id { get;  set; }

        public string MessageText { get; set; }

        public DateTime Timestamp { get; set; }

        public ChatRoom ChatRoom { get; set; }



        public User Users { get; set; }
        
    }
}