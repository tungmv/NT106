using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server_API.Migrations.TrainDB
{
    /// <inheritdoc />
    public partial class Train2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tau_LichTrinh_ID_Tau",
                table: "Tau");

            migrationBuilder.CreateIndex(
                name: "IX_LichTrinh_ID_Tau",
                table: "LichTrinh",
                column: "ID_Tau");

            migrationBuilder.AddForeignKey(
                name: "FK_LichTrinh_Tau_ID_Tau",
                table: "LichTrinh",
                column: "ID_Tau",
                principalTable: "Tau",
                principalColumn: "ID_Tau",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LichTrinh_Tau_ID_Tau",
                table: "LichTrinh");

            migrationBuilder.DropIndex(
                name: "IX_LichTrinh_ID_Tau",
                table: "LichTrinh");

            migrationBuilder.AddForeignKey(
                name: "FK_Tau_LichTrinh_ID_Tau",
                table: "Tau",
                column: "ID_Tau",
                principalTable: "LichTrinh",
                principalColumn: "ID_LichTrinh",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
