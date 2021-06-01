using ChatApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var hasher = new PasswordHasher<User>();

            User user = new User()
            {
                FirstName = "Smejds",
                LastName = "Smejdssson",
                UserName = "Smejds",
                NormalizedUserName = "SMEJDS",
                PasswordHash = hasher.HashPassword(null, "Test")
            };
            builder.Entity<User>().HasData(user);
        }
    }
}

