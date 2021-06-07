using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatApp.Hubs;
using Microsoft.AspNetCore.Identity;
using ChatApp.Models;
using ChatApp.Data;

namespace ChatApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public class Message
        {
            public string message;
            public bool user;
        }
        public List<Message> Mes { get; set; }

        
        public async Task OnGetAsync(bool? resetDb)
        {
            if (resetDb ?? false)
            {
                await _context.Seed(_userManager, _roleManager);
            }

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