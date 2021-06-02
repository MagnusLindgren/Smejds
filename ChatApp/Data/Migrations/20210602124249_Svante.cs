using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatApp.Data.Migrations
{
    public partial class Svante : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a39855a4-a511-4597-ac91-bb709616bb5f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "571d7212-79ff-4e97-be62-569ea54a1c32", 0, "3b36fa46-6ac2-4514-bb7c-aad5cd74c250", "Smejds@mail.com", true, "Smejds", "Smejdssson", false, null, "SMEJDS@MAIL.COM", "SMEJDS@MAIL.COM", "AQAAAAEAACcQAAAAEGqJ4SJGq7qhBG+ItJpGp2tgpOdlRQ1aXZY6mdgujI6RTk2YUErnIO3ilB7W4eE6LA==", null, false, "983be2bf-e389-45da-aafd-cafc6b5c446b", false, "Smejds@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "571d7212-79ff-4e97-be62-569ea54a1c32");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a39855a4-a511-4597-ac91-bb709616bb5f", 0, "4e3c8154-ff9c-4222-b907-31ce735b8c73", null, false, "Smejds", "Smejdssson", false, null, null, "SMEJDS", "AQAAAAEAACcQAAAAENz3fZTVmEka2ggr9NxFSDT7D3Bxlp5eOsc68RyB0tZWjfe1xINUXW+rGvW6pxTc+w==", null, false, "0a8254ab-6cb3-4ed2-97b7-4e29951042b7", false, "Smejds" });
        }
    }
}
