using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkLookup.Migrations
{
    public partial class AddSeededNationalData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "National",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "National",
                columns: new[] { "NationalId", "Name" },
                values: new object[] { 1, "National Parks Conservation Association" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "National",
                keyColumn: "NationalId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "National");
        }
    }
}
