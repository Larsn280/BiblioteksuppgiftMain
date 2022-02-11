using Microsoft.EntityFrameworkCore.Migrations;

namespace BiblioteksuppgiftMain.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Lånedatum",
                table: "Utlåningar",
                type: "nvarchar(max)",
                rowVersion: true,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lånedatum",
                table: "Utlåningar");
        }
    }
}
