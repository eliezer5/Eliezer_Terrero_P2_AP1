using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Eliezer_Terrero_P2_AP1.API.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accesorios",
                columns: new[] { "AccesoriosId", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Camara Trasera" },
                    { 2, "Pantalla interior" },
                    { 3, "Interior en Piel" },
                    { 4, "Sun Roof" },
                    { 5, "Aros de Lujo" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accesorios",
                keyColumn: "AccesoriosId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accesorios",
                keyColumn: "AccesoriosId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Accesorios",
                keyColumn: "AccesoriosId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Accesorios",
                keyColumn: "AccesoriosId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Accesorios",
                keyColumn: "AccesoriosId",
                keyValue: 5);
        }
    }
}
