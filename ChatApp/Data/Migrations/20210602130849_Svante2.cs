using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatApp.Data.Migrations
{
    public partial class Svante2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47aee39b-68be-428c-847a-958328be565b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ad625eac-7f3d-4a57-bc99-291c8c3c4765", 0, "1a5f93a5-5865-4333-b556-e8dba4dd139c", "Smejds@mail.com", true, "Smejds", "Smejdssson", false, null, "SMEJDS@MAIL.COM", "SMEJDS@MAIL.COM", "AQAAAAEAACcQAAAAEMCJPf9L0SaSfHyA1BrbOIj3H3l4R7HC02LKMawE/LKaH1LSVQl7obet9/QBaqef5w==", null, false, "dd277fd4-6c7e-4d86-a9fc-abaeb2ab124d", false, "Smejds@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad625eac-7f3d-4a57-bc99-291c8c3c4765");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "47aee39b-68be-428c-847a-958328be565b", 0, "2a3527b3-b268-4c90-8e70-3fd61c86288f", "Smejds@mail.com", true, "Smejds", "Smejdssson", false, null, "SMEJDS@MAIL.COM", "SMEJDS@MAIL.COM", "AQAAAAEAACcQAAAAEJ/hFFURyWxInvZ3EwAlkVwwRbbe/MdOIyYIQMJF0IMyhjlJdDq14TmweWF4v1x3hw==", null, false, "d2bc2bcd-1aa7-422d-8ab6-e79e90c2f8d0", false, "Smejds@mail.com" });
        }
    }
}
