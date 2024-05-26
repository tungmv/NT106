using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server_API.Migrations.TrainDB
{
    /// <inheritdoc />
    public partial class TrainFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KhaDung",
                table: "VeNgoi");

            migrationBuilder.DropColumn(
                name: "KhaDung",
                table: "VeNam");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpireDate",
                table: "VeNgoi",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpireDate",
                table: "VeNam",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpireDate",
                table: "VeNgoi");

            migrationBuilder.DropColumn(
                name: "ExpireDate",
                table: "VeNam");

            migrationBuilder.AddColumn<int>(
                name: "KhaDung",
                table: "VeNgoi",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KhaDung",
                table: "VeNam",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
