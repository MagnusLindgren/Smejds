using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatApp.Data.Migrations
{
    public partial class emailconfirmation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "046dc74c-b0fb-4e49-8d16-14ccf705e333");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6f44b2b8-6a13-4e01-98a9-32ab1ea0cab9", 0, "f80e3271-319d-4fa9-835c-3f033118ed9b", "Smejds@mail.com", true, "Smejds", "Smejdssson", false, null, "SMEJDS@MAIL.COM", "SMEJDS", "AQAAAAEAACcQAAAAEGwAW0HGdzcXfkKObnjF2Y2kR5W1JJv7ypSIzh1glX2olWF167IrwYaWowDuFIzRbA==", null, false, "2336ac88-1305-4163-b39d-1a4aa8b099a2", false, "Smejds" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f44b2b8-6a13-4e01-98a9-32ab1ea0cab9");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "046dc74c-b0fb-4e49-8d16-14ccf705e333", 0, "e734b206-129e-46f2-8703-0ca693cc2566", "Smejds@mail.com", false, "Smejds", "Smejdssson", false, null, "SMEJDS@MAIL.COM", "SMEJDS", "AQAAAAEAACcQAAAAEGVzGjZONWqUg7Z2OJI7Sci8PFiBEa6afw6nWb3gIlN/8LQN9cUVpxUi7uZSwTtd5Q==", null, false, "dc0afa71-e5eb-4a60-ae66-e8696853bf20", false, "Smejds" });
        }
    }
}
