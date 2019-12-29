using Microsoft.EntityFrameworkCore.Migrations;

namespace DragoonApp.Migrations
{
    public partial class UpdatedUserModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentNumber",
                table: "AbpUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "typeOfUser",
                table: "AbpUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentNumber",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "typeOfUser",
                table: "AbpUsers");
        }
    }
}
