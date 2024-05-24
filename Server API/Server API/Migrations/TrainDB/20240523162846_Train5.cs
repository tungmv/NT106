using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server_API.Migrations.TrainDB
{
    /// <inheritdoc />
    public partial class Train5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Giuong",
                table: "Giuong");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ghe",
                table: "Ghe");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Giuong",
                table: "Giuong",
                columns: new[] { "ID_Giuong", "ID_Phong" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ghe",
                table: "Ghe",
                columns: new[] { "ID_Ghe", "ID_Toa" });

            migrationBuilder.CreateIndex(
                name: "IX_Giuong_ID_Giuong",
                table: "Giuong",
                column: "ID_Giuong",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ghe_ID_Ghe",
                table: "Ghe",
                column: "ID_Ghe",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Giuong",
                table: "Giuong");

            migrationBuilder.DropIndex(
                name: "IX_Giuong_ID_Giuong",
                table: "Giuong");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ghe",
                table: "Ghe");

            migrationBuilder.DropIndex(
                name: "IX_Ghe_ID_Ghe",
                table: "Ghe");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Giuong",
                table: "Giuong",
                column: "ID_Giuong");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ghe",
                table: "Ghe",
                column: "ID_Ghe");
        }
    }
}
