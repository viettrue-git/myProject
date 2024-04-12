using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class namemigrationa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "tags");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "article");

            migrationBuilder.RenameColumn(
                name: "TagId",
                table: "tags",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "article",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "ArticleId",
                table: "article",
                newName: "BannerId");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "tags",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "tags",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "tags",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "article",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "tags");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "tags");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "tags");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "article");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "tags",
                newName: "TagId");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "article",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "BannerId",
                table: "article",
                newName: "ArticleId");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "tags",
                type: "ntext",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "article",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
