using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server_API.Migrations.TrainDB
{
    /// <inheritdoc />
    public partial class TrainFinal3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VeNam_Tuyen_ID_Tuyen",
                table: "VeNam");

            migrationBuilder.DropForeignKey(
                name: "FK_VeNgoi_Tuyen_ID_Tuyen",
                table: "VeNgoi");

            migrationBuilder.DropIndex(
                name: "IX_VeNgoi_ID_Tuyen",
                table: "VeNgoi");

            migrationBuilder.DropIndex(
                name: "IX_VeNam_ID_Tuyen",
                table: "VeNam");

            migrationBuilder.RenameColumn(
                name: "ID_Tuyen",
                table: "VeNgoi",
                newName: "XuatPhat");

            migrationBuilder.RenameColumn(
                name: "ID_Tuyen",
                table: "VeNam",
                newName: "XuatPhat");

            migrationBuilder.AlterColumn<int>(
                name: "NamSinh",
                table: "VeNgoi",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "DiemDen",
                table: "VeNgoi",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ID_LichTrinh",
                table: "VeNgoi",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "NamSinh",
                table: "VeNam",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "DiemDen",
                table: "VeNam",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ID_LichTrinh",
                table: "VeNam",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_VeNgoi_ID_LichTrinh",
                table: "VeNgoi",
                column: "ID_LichTrinh");

            migrationBuilder.CreateIndex(
                name: "IX_VeNam_ID_LichTrinh",
                table: "VeNam",
                column: "ID_LichTrinh");

            migrationBuilder.AddForeignKey(
                name: "FK_VeNam_LichTrinh_ID_LichTrinh",
                table: "VeNam",
                column: "ID_LichTrinh",
                principalTable: "LichTrinh",
                principalColumn: "ID_LichTrinh",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VeNgoi_LichTrinh_ID_LichTrinh",
                table: "VeNgoi",
                column: "ID_LichTrinh",
                principalTable: "LichTrinh",
                principalColumn: "ID_LichTrinh",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VeNam_LichTrinh_ID_LichTrinh",
                table: "VeNam");

            migrationBuilder.DropForeignKey(
                name: "FK_VeNgoi_LichTrinh_ID_LichTrinh",
                table: "VeNgoi");

            migrationBuilder.DropIndex(
                name: "IX_VeNgoi_ID_LichTrinh",
                table: "VeNgoi");

            migrationBuilder.DropIndex(
                name: "IX_VeNam_ID_LichTrinh",
                table: "VeNam");

            migrationBuilder.DropColumn(
                name: "DiemDen",
                table: "VeNgoi");

            migrationBuilder.DropColumn(
                name: "ID_LichTrinh",
                table: "VeNgoi");

            migrationBuilder.DropColumn(
                name: "DiemDen",
                table: "VeNam");

            migrationBuilder.DropColumn(
                name: "ID_LichTrinh",
                table: "VeNam");

            migrationBuilder.RenameColumn(
                name: "XuatPhat",
                table: "VeNgoi",
                newName: "ID_Tuyen");

            migrationBuilder.RenameColumn(
                name: "XuatPhat",
                table: "VeNam",
                newName: "ID_Tuyen");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NamSinh",
                table: "VeNgoi",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NamSinh",
                table: "VeNam",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_VeNgoi_ID_Tuyen",
                table: "VeNgoi",
                column: "ID_Tuyen");

            migrationBuilder.CreateIndex(
                name: "IX_VeNam_ID_Tuyen",
                table: "VeNam",
                column: "ID_Tuyen");

            migrationBuilder.AddForeignKey(
                name: "FK_VeNam_Tuyen_ID_Tuyen",
                table: "VeNam",
                column: "ID_Tuyen",
                principalTable: "Tuyen",
                principalColumn: "ID_Tuyen",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VeNgoi_Tuyen_ID_Tuyen",
                table: "VeNgoi",
                column: "ID_Tuyen",
                principalTable: "Tuyen",
                principalColumn: "ID_Tuyen",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
