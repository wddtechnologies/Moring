using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Morning.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addVillaNumbers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Villas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Villas",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    Villa_Number = table.Column<int>(type: "int", nullable: false),
                    VillaId = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.Villa_Number);
                    table.ForeignKey(
                        name: "FK_VillaNumbers_Villas_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "VillaNumbers",
                columns: new[] { "Villa_Number", "SpecialDetails", "VillaId" },
                values: new object[,]
                {
                    { 101, null, 1 },
                    { 201, null, 2 },
                    { 301, null, 3 },
                    { 401, null, 4 },
                    { 501, null, 5 }
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 12, 12, 9, 22, 2, 17, DateTimeKind.Local).AddTicks(5448), new DateTime(2024, 12, 12, 9, 22, 2, 17, DateTimeKind.Local).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 12, 12, 9, 22, 2, 17, DateTimeKind.Local).AddTicks(5512), new DateTime(2024, 12, 12, 9, 22, 2, 17, DateTimeKind.Local).AddTicks(5513) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 12, 12, 9, 22, 2, 17, DateTimeKind.Local).AddTicks(5516), new DateTime(2024, 12, 12, 9, 22, 2, 17, DateTimeKind.Local).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 12, 12, 9, 22, 2, 17, DateTimeKind.Local).AddTicks(5519), new DateTime(2024, 12, 12, 9, 22, 2, 17, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 12, 12, 9, 22, 2, 17, DateTimeKind.Local).AddTicks(5523), new DateTime(2024, 12, 12, 9, 22, 2, 17, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaId",
                table: "VillaNumbers",
                column: "VillaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 12, 9, 10, 46, 28, 713, DateTimeKind.Local).AddTicks(7166), new DateTime(2024, 12, 9, 10, 46, 28, 713, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 12, 9, 10, 46, 28, 713, DateTimeKind.Local).AddTicks(7225), new DateTime(2024, 12, 9, 10, 46, 28, 713, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 12, 9, 10, 46, 28, 713, DateTimeKind.Local).AddTicks(7229), new DateTime(2024, 12, 9, 10, 46, 28, 713, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 12, 9, 10, 46, 28, 713, DateTimeKind.Local).AddTicks(7233), new DateTime(2024, 12, 9, 10, 46, 28, 713, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 12, 9, 10, 46, 28, 713, DateTimeKind.Local).AddTicks(7237), new DateTime(2024, 12, 9, 10, 46, 28, 713, DateTimeKind.Local).AddTicks(7238) });
        }
    }
}
