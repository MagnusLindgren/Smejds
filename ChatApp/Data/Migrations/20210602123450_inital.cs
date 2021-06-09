using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatApp.Data.Migrations
{
    public partial class inital : Migration
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
                values: new object[] { "a39855a4-a511-4597-ac91-bb709616bb5f", 0, "4e3c8154-ff9c-4222-b907-31ce735b8c73", null, false, "Smejds", "Smejdssson", false, null, null, "SMEJDS", "AQAAAAEAACcQAAAAENz3fZTVmEka2ggr9NxFSDT7D3Bxlp5eOsc68RyB0tZWjfe1xINUXW+rGvW6pxTc+w==", null, false, "0a8254ab-6cb3-4ed2-97b7-4e29951042b7", false, "Smejds" });

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
                keyValue: "a39855a4-a511-4597-ac91-bb709616bb5f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5bf7b68a-e9fc-45ef-a115-b29a8c5e41e5", 0, "7f1ed039-42cd-4934-8af5-d6037a2146f5", null, false, "Smejds", "Smejdssson", false, null, null, "SMEJDS", "AQAAAAEAACcQAAAAEDqpPRq86B3Zz5RGZCeR1ow9vdjPl0VbtwJ/+KxGjupkNmny6Cuhg3EZMVlWpvexyg==", null, false, "7a9b80f6-8fc4-4c7d-bc96-415a69007446", false, "Smejds" });
        }
    }
}
