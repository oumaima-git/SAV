using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAV.infrastructure.Migrations
{
    public partial class intiale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "FamilleTiers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Inactif",
                table: "FamilleTiers",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "FamilleTiers");

            migrationBuilder.DropColumn(
                name: "Inactif",
                table: "FamilleTiers");
        }
    }
}
