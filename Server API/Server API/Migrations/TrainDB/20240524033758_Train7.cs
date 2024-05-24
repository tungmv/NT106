using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server_API.Migrations.TrainDB
{
    /// <inheritdoc />
    public partial class Train7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ghe_VeNgoi_ID_Ghe",
                table: "Ghe");

            migrationBuilder.DropForeignKey(
                name: "FK_Giuong_VeNam_ID_Giuong",
                table: "Giuong");

            migrationBuilder.DropIndex(
                name: "IX_Giuong_ID_Giuong",
                table: "Giuong");

            migrationBuilder.DropIndex(
                name: "IX_Ghe_ID_Ghe",
                table: "Ghe");

            migrationBuilder.AddColumn<string>(
                name: "ID_Toa",
                table: "VeNgoi",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ID_Phong",
                table: "VeNam",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_VeNgoi_ID_Ghe_ID_Toa",
                table: "VeNgoi",
                columns: new[] { "ID_Ghe", "ID_Toa" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VeNgoi_ID_Tuyen",
                table: "VeNgoi",
                column: "ID_Tuyen");

            migrationBuilder.CreateIndex(
                name: "IX_VeNam_ID_Giuong_ID_Phong",
                table: "VeNam",
                columns: new[] { "ID_Giuong", "ID_Phong" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VeNam_ID_Tuyen",
                table: "VeNam",
                column: "ID_Tuyen");

            migrationBuilder.AddForeignKey(
                name: "FK_VeNam_Giuong_ID_Giuong_ID_Phong",
                table: "VeNam",
                columns: new[] { "ID_Giuong", "ID_Phong" },
                principalTable: "Giuong",
                principalColumns: new[] { "ID_Giuong", "ID_Phong" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VeNam_Tuyen_ID_Tuyen",
                table: "VeNam",
                column: "ID_Tuyen",
                principalTable: "Tuyen",
                principalColumn: "ID_Tuyen",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VeNgoi_Ghe_ID_Ghe_ID_Toa",
                table: "VeNgoi",
                columns: new[] { "ID_Ghe", "ID_Toa" },
                principalTable: "Ghe",
                principalColumns: new[] { "ID_Ghe", "ID_Toa" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VeNgoi_Tuyen_ID_Tuyen",
                table: "VeNgoi",
                column: "ID_Tuyen",
                principalTable: "Tuyen",
                principalColumn: "ID_Tuyen",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VeNam_Giuong_ID_Giuong_ID_Phong",
                table: "VeNam");

            migrationBuilder.DropForeignKey(
                name: "FK_VeNam_Tuyen_ID_Tuyen",
                table: "VeNam");

            migrationBuilder.DropForeignKey(
                name: "FK_VeNgoi_Ghe_ID_Ghe_ID_Toa",
                table: "VeNgoi");

            migrationBuilder.DropForeignKey(
                name: "FK_VeNgoi_Tuyen_ID_Tuyen",
                table: "VeNgoi");

            migrationBuilder.DropIndex(
                name: "IX_VeNgoi_ID_Ghe_ID_Toa",
                table: "VeNgoi");

            migrationBuilder.DropIndex(
                name: "IX_VeNgoi_ID_Tuyen",
                table: "VeNgoi");

            migrationBuilder.DropIndex(
                name: "IX_VeNam_ID_Giuong_ID_Phong",
                table: "VeNam");

            migrationBuilder.DropIndex(
                name: "IX_VeNam_ID_Tuyen",
                table: "VeNam");

            migrationBuilder.DropColumn(
                name: "ID_Toa",
                table: "VeNgoi");

            migrationBuilder.DropColumn(
                name: "ID_Phong",
                table: "VeNam");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Ghe_VeNgoi_ID_Ghe",
                table: "Ghe",
                column: "ID_Ghe",
                principalTable: "VeNgoi",
                principalColumn: "ID_VeNgoi",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Giuong_VeNam_ID_Giuong",
                table: "Giuong",
                column: "ID_Giuong",
                principalTable: "VeNam",
                principalColumn: "ID_VeNam",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
