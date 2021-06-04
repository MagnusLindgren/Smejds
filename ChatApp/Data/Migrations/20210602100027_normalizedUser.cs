using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatApp.Data.Migrations
{
    public partial class normalizedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1c537d2-bfd4-45c7-a48f-e2fadfe8280b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "47aee39b-68be-428c-847a-958328be565b", 0, "2a3527b3-b268-4c90-8e70-3fd61c86288f", "Smejds@mail.com", true, "Smejds", "Smejdssson", false, null, "SMEJDS@MAIL.COM", "SMEJDS@MAIL.COM", "AQAAAAEAACcQAAAAEJ/hFFURyWxInvZ3EwAlkVwwRbbe/MdOIyYIQMJF0IMyhjlJdDq14TmweWF4v1x3hw==", null, false, "d2bc2bcd-1aa7-422d-8ab6-e79e90c2f8d0", false, "Smejds@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47aee39b-68be-428c-847a-958328be565b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b1c537d2-bfd4-45c7-a48f-e2fadfe8280b", 0, "54a37cbf-1ce9-4712-80b8-4a7ab47c3959", "Smejds@mail.com", true, "Smejds", "Smejdssson", false, null, "SMEJDS@MAIL.COM", "SMEJDS", "AQAAAAEAACcQAAAAENGJKtjNoGRH8rad2XcqA0rpznYAbjf1LPSojajd48ThP23qD4g1S7y9/X0vatyXzw==", null, false, "cd240215-7245-4463-949f-34d7da13ffe2", false, "Smejds@mail.com" });
        }
    }
}
