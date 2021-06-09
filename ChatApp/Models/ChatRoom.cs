using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class ChatRoom
    {
        public int Id { get;  set; }

        public string Name { get; set; }
        public DateTime Created_at_date { get; set; }
 


        public List<ChatMessage> Messages { get; set; }

        public List<User> Users { get; set; }
        
    }
}
