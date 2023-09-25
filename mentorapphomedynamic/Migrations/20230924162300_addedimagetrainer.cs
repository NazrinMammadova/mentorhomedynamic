using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mentorapphomedynamic.Migrations
{
    public partial class addedimagetrainer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Trainers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Trainers");
        }
    }
}
