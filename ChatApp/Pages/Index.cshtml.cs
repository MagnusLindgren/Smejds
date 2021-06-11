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
using Microsoft.EntityFrameworkCore;

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
        [BindProperty]
        public List<ChatRoom> ChatRoom { get; set; }

        public async Task OnGetAsync(bool? resetDb)
        {
            if (resetDb ?? false)
            {
                await _context.Seed(_userManager, _roleManager);
            }
            var user = User.Identity.Name;

            // Hämtar Userns chatrooms i lista
            User userModel = _context.Users.Include(r => r.ChatRooms).FirstOrDefault(o => o.UserName == user);

            ChatRoom = userModel.ChatRooms;
        }
    }
}