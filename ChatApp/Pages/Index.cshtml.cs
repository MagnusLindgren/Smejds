using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatApp.Hubs;

namespace ChatApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public class Message
        {
            public string message;
            public bool user;
        }
        public List<Message> Mes { get; set; }


        public void OnGet()
        {
            List<Message> mes = new List<Message>()
            {
                new Message() { message = "Tjenna!", user = true },
                new Message() { message = "Tjenna vad händer!", user = false },
                new Message() { message = "Inte mycket dd?", user = true },
                new Message() { message = "Försöker göra en schysst chatt hemsida", user = false }
            };
            Mes = mes;
        }
    }
}