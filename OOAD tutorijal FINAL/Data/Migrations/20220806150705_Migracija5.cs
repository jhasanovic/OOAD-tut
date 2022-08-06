using Microsoft.EntityFrameworkCore.Migrations;

namespace OOAD_tutorijal_FINAL.Data.Migrations
{
    public partial class Migracija5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slika",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Student");
        }
    }
}
