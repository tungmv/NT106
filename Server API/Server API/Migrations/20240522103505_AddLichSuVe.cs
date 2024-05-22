using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server_API.Migrations
{
    /// <inheritdoc />
    public partial class AddLichSuVe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LichSuDatVeNam",
                columns: table => new
                {
                    ID_KhachHang = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ID_VeNam = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuDatVeNam", x => new { x.ID_KhachHang, x.ID_VeNam });
                    table.ForeignKey(
                        name: "FK_LichSuDatVeNam_khachhang_ID_KhachHang",
                        column: x => x.ID_KhachHang,
                        principalTable: "khachhang",
                        principalColumn: "ID_KhachHang",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LichSuDatVeNgoi",
                columns: table => new
                {
                    ID_KhachHang = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ID_VeNgoi = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuDatVeNgoi", x => new { x.ID_KhachHang, x.ID_VeNgoi });
                    table.ForeignKey(
                        name: "FK_LichSuDatVeNgoi_khachhang_ID_KhachHang",
                        column: x => x.ID_KhachHang,
                        principalTable: "khachhang",
                        principalColumn: "ID_KhachHang",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LichSuDatVeNam");

            migrationBuilder.DropTable(
                name: "LichSuDatVeNgoi");
        }
    }
}
