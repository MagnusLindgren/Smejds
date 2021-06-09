using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatApp.Data.Migrations
{
    public partial class testWithSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessageUser_Message_MessagesID",
                table: "MessageUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message",
                table: "Message");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47aee39b-68be-428c-847a-958328be565b");

            migrationBuilder.RenameTable(
                name: "Message",
                newName: "Messages");

            migrationBuilder.AddColumn<int>(
                name: "ChatUserId",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "ChatUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatUsers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ChatUserId",
                table: "Messages",
                column: "ChatUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_ChatUsers_ChatUserId",
                table: "Messages",
                column: "ChatUserId",
                principalTable: "ChatUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MessageUser_Messages_MessagesID",
                table: "MessageUser",
                column: "MessagesID",
                principalTable: "Messages",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_ChatUsers_ChatUserId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_MessageUser_Messages_MessagesID",
                table: "MessageUser");

            migrationBuilder.DropTable(
                name: "ChatUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ChatUserId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ChatUserId",
                table: "Messages");

            migrationBuilder.RenameTable(
                name: "Messages",
                newName: "Message");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message",
                table: "Message",
                column: "ID");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "47aee39b-68be-428c-847a-958328be565b", 0, "2a3527b3-b268-4c90-8e70-3fd61c86288f", "Smejds@mail.com", true, "Smejds", "Smejdssson", false, null, "SMEJDS@MAIL.COM", "SMEJDS@MAIL.COM", "AQAAAAEAACcQAAAAEJ/hFFURyWxInvZ3EwAlkVwwRbbe/MdOIyYIQMJF0IMyhjlJdDq14TmweWF4v1x3hw==", null, false, "d2bc2bcd-1aa7-422d-8ab6-e79e90c2f8d0", false, "Smejds@mail.com" });

            migrationBuilder.AddForeignKey(
                name: "FK_MessageUser_Message_MessagesID",
                table: "MessageUser",
                column: "MessagesID",
                principalTable: "Message",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
