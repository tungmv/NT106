using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server_API.Migrations.TrainDB
{
    /// <inheritdoc />
    public partial class TrainInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tram",
                columns: table => new
                {
                    ID_Tram = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    TenTram = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Thanhpho = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Tinh = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tram", x => x.ID_Tram);
                });

            migrationBuilder.CreateTable(
                name: "Tuyen",
                columns: table => new
                {
                    ID_Tuyen = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    TenTuyen = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tuyen", x => x.ID_Tuyen);
                });

            migrationBuilder.CreateTable(
                name: "VeNam",
                columns: table => new
                {
                    ID_VeNam = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    ID_Tuyen = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    ID_Giuong = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    DonGia = table.Column<int>(type: "INTEGER", nullable: false),
                    KhaDung = table.Column<int>(type: "INTEGER", nullable: false),
                    HoTen = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    NamSinh = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeNam", x => x.ID_VeNam);
                });

            migrationBuilder.CreateTable(
                name: "VeNgoi",
                columns: table => new
                {
                    ID_VeNgoi = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    ID_Tuyen = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    ID_Ghe = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    DonGia = table.Column<int>(type: "INTEGER", nullable: false),
                    KhaDung = table.Column<int>(type: "INTEGER", nullable: false),
                    HoTen = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    NamSinh = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeNgoi", x => x.ID_VeNgoi);
                });

            migrationBuilder.CreateTable(
                name: "DiemDi",
                columns: table => new
                {
                    ID_Tuyen = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    ID_Tram = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    KhoangCach = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiemDi", x => new { x.ID_Tuyen, x.ID_Tram });
                    table.ForeignKey(
                        name: "FK_DiemDi_Tram_ID_Tram",
                        column: x => x.ID_Tram,
                        principalTable: "Tram",
                        principalColumn: "ID_Tram",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiemDi_Tuyen_ID_Tuyen",
                        column: x => x.ID_Tuyen,
                        principalTable: "Tuyen",
                        principalColumn: "ID_Tuyen",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LichTrinh",
                columns: table => new
                {
                    ID_LichTrinh = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    ID_Tuyen = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    ID_Tau = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    KhoiHanh = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichTrinh", x => x.ID_LichTrinh);
                    table.ForeignKey(
                        name: "FK_LichTrinh_Tuyen_ID_Tuyen",
                        column: x => x.ID_Tuyen,
                        principalTable: "Tuyen",
                        principalColumn: "ID_Tuyen",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tau",
                columns: table => new
                {
                    ID_Tau = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    TuoiTho = table.Column<int>(type: "INTEGER", nullable: false),
                    TuyenID_Tuyen = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tau", x => x.ID_Tau);
                    table.ForeignKey(
                        name: "FK_Tau_LichTrinh_ID_Tau",
                        column: x => x.ID_Tau,
                        principalTable: "LichTrinh",
                        principalColumn: "ID_LichTrinh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tau_Tuyen_TuyenID_Tuyen",
                        column: x => x.TuyenID_Tuyen,
                        principalTable: "Tuyen",
                        principalColumn: "ID_Tuyen",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Toa",
                columns: table => new
                {
                    ID_Toa = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    Loai = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    ID_Tau = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toa", x => x.ID_Toa);
                    table.ForeignKey(
                        name: "FK_Toa_Tau_ID_Tau",
                        column: x => x.ID_Tau,
                        principalTable: "Tau",
                        principalColumn: "ID_Tau",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ghe",
                columns: table => new
                {
                    ID_Ghe = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    Loai = table.Column<string>(type: "TEXT", maxLength: 4, nullable: false),
                    ID_Toa = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ghe", x => x.ID_Ghe);
                    table.ForeignKey(
                        name: "FK_Ghe_Toa_ID_Toa",
                        column: x => x.ID_Toa,
                        principalTable: "Toa",
                        principalColumn: "ID_Toa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ghe_VeNgoi_ID_Ghe",
                        column: x => x.ID_Ghe,
                        principalTable: "VeNgoi",
                        principalColumn: "ID_VeNgoi",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phong",
                columns: table => new
                {
                    ID_Phong = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    Loai = table.Column<string>(type: "TEXT", maxLength: 1, nullable: false),
                    ID_Toa = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phong", x => x.ID_Phong);
                    table.ForeignKey(
                        name: "FK_Phong_Toa_ID_Toa",
                        column: x => x.ID_Toa,
                        principalTable: "Toa",
                        principalColumn: "ID_Toa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Giuong",
                columns: table => new
                {
                    ID_Giuong = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    ID_Phong = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giuong", x => x.ID_Giuong);
                    table.ForeignKey(
                        name: "FK_Giuong_Phong_ID_Phong",
                        column: x => x.ID_Phong,
                        principalTable: "Phong",
                        principalColumn: "ID_Phong",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Giuong_VeNam_ID_Giuong",
                        column: x => x.ID_Giuong,
                        principalTable: "VeNam",
                        principalColumn: "ID_VeNam",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiemDi_ID_Tram",
                table: "DiemDi",
                column: "ID_Tram");

            migrationBuilder.CreateIndex(
                name: "IX_Ghe_ID_Toa",
                table: "Ghe",
                column: "ID_Toa");

            migrationBuilder.CreateIndex(
                name: "IX_Giuong_ID_Phong",
                table: "Giuong",
                column: "ID_Phong");

            migrationBuilder.CreateIndex(
                name: "IX_LichTrinh_ID_Tuyen",
                table: "LichTrinh",
                column: "ID_Tuyen");

            migrationBuilder.CreateIndex(
                name: "IX_Phong_ID_Toa",
                table: "Phong",
                column: "ID_Toa");

            migrationBuilder.CreateIndex(
                name: "IX_Tau_TuyenID_Tuyen",
                table: "Tau",
                column: "TuyenID_Tuyen");

            migrationBuilder.CreateIndex(
                name: "IX_Toa_ID_Tau",
                table: "Toa",
                column: "ID_Tau");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiemDi");

            migrationBuilder.DropTable(
                name: "Ghe");

            migrationBuilder.DropTable(
                name: "Giuong");

            migrationBuilder.DropTable(
                name: "Tram");

            migrationBuilder.DropTable(
                name: "VeNgoi");

            migrationBuilder.DropTable(
                name: "Phong");

            migrationBuilder.DropTable(
                name: "VeNam");

            migrationBuilder.DropTable(
                name: "Toa");

            migrationBuilder.DropTable(
                name: "Tau");

            migrationBuilder.DropTable(
                name: "LichTrinh");

            migrationBuilder.DropTable(
                name: "Tuyen");
        }
    }
}
