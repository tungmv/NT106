using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server_API.Migrations.TrainDB
{
    /// <inheritdoc />
    public partial class Train6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Loai",
                table: "Phong");

            migrationBuilder.DropColumn(
                name: "Loai",
                table: "Ghe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Loai",
                table: "Phong",
                type: "TEXT",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Loai",
                table: "Ghe",
                type: "TEXT",
                maxLength: 4,
                nullable: false,
                defaultValue: "");
        }
    }
}
