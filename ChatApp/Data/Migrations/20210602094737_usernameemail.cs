using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatApp.Data.Migrations
{
    public partial class usernameemail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f44b2b8-6a13-4e01-98a9-32ab1ea0cab9");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b1c537d2-bfd4-45c7-a48f-e2fadfe8280b", 0, "54a37cbf-1ce9-4712-80b8-4a7ab47c3959", "Smejds@mail.com", true, "Smejds", "Smejdssson", false, null, "SMEJDS@MAIL.COM", "SMEJDS", "AQAAAAEAACcQAAAAENGJKtjNoGRH8rad2XcqA0rpznYAbjf1LPSojajd48ThP23qD4g1S7y9/X0vatyXzw==", null, false, "cd240215-7245-4463-949f-34d7da13ffe2", false, "Smejds@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1c537d2-bfd4-45c7-a48f-e2fadfe8280b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6f44b2b8-6a13-4e01-98a9-32ab1ea0cab9", 0, "f80e3271-319d-4fa9-835c-3f033118ed9b", "Smejds@mail.com", true, "Smejds", "Smejdssson", false, null, "SMEJDS@MAIL.COM", "SMEJDS", "AQAAAAEAACcQAAAAEGwAW0HGdzcXfkKObnjF2Y2kR5W1JJv7ypSIzh1glX2olWF167IrwYaWowDuFIzRbA==", null, false, "2336ac88-1305-4163-b39d-1a4aa8b099a2", false, "Smejds" });
        }
    }
}
