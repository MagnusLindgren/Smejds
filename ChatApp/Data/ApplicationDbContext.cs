using ChatApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}

        public DbSet<User> Users { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set;  }
        public DbSet<ChatRoom> ChatRooms { get; set;  }


        public async Task Seed(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            await Database.EnsureDeletedAsync();
            await Database.EnsureCreatedAsync();

            var hasher = new PasswordHasher<User>();

            await roleManager.CreateAsync(new IdentityRole("Administrator"));
            await roleManager.CreateAsync(new IdentityRole("Moderator"));
            await roleManager.CreateAsync(new IdentityRole("AppUser"));

             
                
            await Roles.ToListAsync();

            User user = new User()
            {
                FirstName = "Smejds",
                LastName = "Smejdssson",
                UserName = "Smejds@mail.com",
                NormalizedUserName = "SMEJDS@MAIL.COM",
                Email = "Smejds@mail.com",
                NormalizedEmail = "SMEJDS@MAIL.COM",
                EmailConfirmed = true,

                //PasswordHash = hasher.HashPassword(null, "Test")
            };

            

     

            var date = DateTime.Now;


            ChatRoom chatrooms = new ChatRoom()
            {
                Name = "1",
                Created_at_date = date,
                Users = new List<User>() { user },

            };

            ChatMessage chatmessages = new ChatMessage()
            {
                MessageText = "Hej på er!",
                Users = user,
                ChatRoom = chatrooms,


            };

            await userManager.CreateAsync(user, "Test123!");
            await userManager.AddToRoleAsync(user, "Administrator");


            await AddAsync(chatrooms);
            await AddAsync(chatmessages);

            //await AddAsync(user);
            await SaveChangesAsync();
        }
    }
}