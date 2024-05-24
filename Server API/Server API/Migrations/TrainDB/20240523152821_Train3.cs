using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server_API.Migrations.TrainDB
{
    /// <inheritdoc />
    public partial class Train3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KhoiHanh",
                table: "LichTrinh",
                newName: "Gio");

            migrationBuilder.AddColumn<string>(
                name: "Lop",
                table: "Tau",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Thu",
                table: "LichTrinh",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lop",
                table: "Tau");

            migrationBuilder.DropColumn(
                name: "Thu",
                table: "LichTrinh");

            migrationBuilder.RenameColumn(
                name: "Gio",
                table: "LichTrinh",
                newName: "KhoiHanh");
        }
    }
}
