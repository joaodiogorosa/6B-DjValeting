using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DjValeting.MVC.Data.Migrations
{
    public partial class ApprovedClientModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "clientModels",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Approved",
                table: "clientModels");
        }
    }
}
