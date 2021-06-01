using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class Message
    {
        public int ID { get;  set; }

        public string MessageText { get; set; }
        public string Name { get; set; }
        public DateTime Timestamp { get; set; }

        public int ChatId { get; set; }

        public List<User> Users { get; set; }
        
    }
}