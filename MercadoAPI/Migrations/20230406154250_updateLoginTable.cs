using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MercadoAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateLoginTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Signups",
                table: "Signups");

            migrationBuilder.RenameTable(
                name: "Signups",
                newName: "Users");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "username",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Signups");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Signups",
                table: "Signups",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.username);
                });
        }
    }
}
