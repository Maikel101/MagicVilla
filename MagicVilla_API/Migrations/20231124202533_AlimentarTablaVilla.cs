using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaAcualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la Villa...", new DateTime(2023, 11, 24, 21, 25, 33, 120, DateTimeKind.Local).AddTicks(5567), new DateTime(2023, 11, 24, 21, 25, 33, 120, DateTimeKind.Local).AddTicks(5518), "", 50, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle de la Villa...", new DateTime(2023, 11, 24, 21, 25, 33, 120, DateTimeKind.Local).AddTicks(5576), new DateTime(2023, 11, 24, 21, 25, 33, 120, DateTimeKind.Local).AddTicks(5574), "", 80, "Premium vista a la Playa", 6, 250.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
