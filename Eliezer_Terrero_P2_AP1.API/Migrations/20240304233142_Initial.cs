using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eliezer_Terrero_P2_AP1.API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehiculosDetalle_Vehiculos_VehiculosVehiculoId",
                table: "VehiculosDetalle");

            migrationBuilder.DropIndex(
                name: "IX_VehiculosDetalle_VehiculosVehiculoId",
                table: "VehiculosDetalle");

            migrationBuilder.DropColumn(
                name: "VehiculosVehiculoId",
                table: "VehiculosDetalle");

            migrationBuilder.CreateIndex(
                name: "IX_VehiculosDetalle_VehiculoId",
                table: "VehiculosDetalle",
                column: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehiculosDetalle_Vehiculos_VehiculoId",
                table: "VehiculosDetalle",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehiculosDetalle_Vehiculos_VehiculoId",
                table: "VehiculosDetalle");

            migrationBuilder.DropIndex(
                name: "IX_VehiculosDetalle_VehiculoId",
                table: "VehiculosDetalle");

            migrationBuilder.AddColumn<int>(
                name: "VehiculosVehiculoId",
                table: "VehiculosDetalle",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehiculosDetalle_VehiculosVehiculoId",
                table: "VehiculosDetalle",
                column: "VehiculosVehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehiculosDetalle_Vehiculos_VehiculosVehiculoId",
                table: "VehiculosDetalle",
                column: "VehiculosVehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "VehiculoId");
        }
    }
}
