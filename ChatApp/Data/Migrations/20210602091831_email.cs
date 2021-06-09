using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatApp.Data.Migrations
{
    public partial class email : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf7b68a-e9fc-45ef-a115-b29a8c5e41e5");

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MessageUser",
                columns: table => new
                {
                    MessagesID = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageUser", x => new { x.MessagesID, x.UsersId });
                    table.ForeignKey(
                        name: "FK_MessageUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MessageUser_Message_MessagesID",
                        column: x => x.MessagesID,
                        principalTable: "Message",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "046dc74c-b0fb-4e49-8d16-14ccf705e333", 0, "e734b206-129e-46f2-8703-0ca693cc2566", "Smejds@mail.com", false, "Smejds", "Smejdssson", false, null, "SMEJDS@MAIL.COM", "SMEJDS", "AQAAAAEAACcQAAAAEGVzGjZONWqUg7Z2OJI7Sci8PFiBEa6afw6nWb3gIlN/8LQN9cUVpxUi7uZSwTtd5Q==", null, false, "dc0afa71-e5eb-4a60-ae66-e8696853bf20", false, "Smejds" });

            migrationBuilder.CreateIndex(
                name: "IX_MessageUser_UsersId",
                table: "MessageUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessageUser");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "046dc74c-b0fb-4e49-8d16-14ccf705e333");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5bf7b68a-e9fc-45ef-a115-b29a8c5e41e5", 0, "7f1ed039-42cd-4934-8af5-d6037a2146f5", null, false, "Smejds", "Smejdssson", false, null, null, "SMEJDS", "AQAAAAEAACcQAAAAEDqpPRq86B3Zz5RGZCeR1ow9vdjPl0VbtwJ/+KxGjupkNmny6Cuhg3EZMVlWpvexyg==", null, false, "7a9b80f6-8fc4-4c7d-bc96-415a69007446", false, "Smejds" });
        }
    }
}
