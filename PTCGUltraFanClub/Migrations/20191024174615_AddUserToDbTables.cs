using Microsoft.EntityFrameworkCore.Migrations;

namespace PTCGUltraFanClub.Migrations
{
    public partial class AddUserToDbTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    EmailAddresss = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 30, nullable: false),
                    ConfirmPassword = table.Column<string>(maxLength: 30, nullable: false),
                    userDeckChoicesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_UserDeckChoices_userDeckChoicesID",
                        column: x => x.userDeckChoicesID,
                        principalTable: "UserDeckChoices",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_userDeckChoicesID",
                table: "Users",
                column: "userDeckChoicesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
