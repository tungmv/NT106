using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server_API.Migrations
{
    /// <inheritdoc />
    public partial class InitUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "khachhang",
                columns: table => new
                {
                    ID_KhachHang = table.Column<string>(type: "TEXT", nullable: false),
                    HoTen = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    NamSinh = table.Column<int>(type: "INTEGER", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachhang", x => x.ID_KhachHang);
                });

            migrationBuilder.CreateTable(
                name: "KhongPhaiMatKhau",
                columns: table => new
                {
                    salt = table.Column<string>(type: "TEXT", nullable: false),
                    ID_KhachHang = table.Column<string>(type: "TEXT", nullable: false),
                    Hashed = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhongPhaiMatKhau", x => x.salt);
                    table.ForeignKey(
                        name: "FK_KhongPhaiMatKhau_khachhang_ID_KhachHang",
                        column: x => x.ID_KhachHang,
                        principalTable: "khachhang",
                        principalColumn: "ID_KhachHang",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KhongPhaiMatKhau_ID_KhachHang",
                table: "KhongPhaiMatKhau",
                column: "ID_KhachHang",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KhongPhaiMatKhau");

            migrationBuilder.DropTable(
                name: "khachhang");
        }
    }
}
