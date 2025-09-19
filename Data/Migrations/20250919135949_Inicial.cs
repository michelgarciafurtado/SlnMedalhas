using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Opm",
                columns: table => new
                {
                    CodOpm = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OPmPai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Opm", x => x.CodOpm);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Policial",
                columns: table => new
                {
                    Re = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostoGrad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodOpm = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Policial", x => x.Re);
                    table.ForeignKey(
                        name: "FK_Tbl_Policial_Tbl_Opm_CodOpm",
                        column: x => x.CodOpm,
                        principalTable: "Tbl_Opm",
                        principalColumn: "CodOpm",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Medalhas",
                columns: table => new
                {
                    IdMedalha = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeMedalha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoMedalha = table.Column<int>(type: "int", nullable: false),
                    DataConcessao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NBolConcessao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Re = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DataCassacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NBolCassacao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Medalhas", x => x.IdMedalha);
                    table.ForeignKey(
                        name: "FK_Tbl_Medalhas_Tbl_Policial_Re",
                        column: x => x.Re,
                        principalTable: "Tbl_Policial",
                        principalColumn: "Re",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tbl_Opm",
                columns: new[] { "CodOpm", "Descricao", "OPmPai" },
                values: new object[,]
                {
                    { "607070000", "7.bpm/i", "607000000" },
                    { "607400000", "40.bpm/i", "607000000" },
                    { "607500000", "50.bpm/i", "607000000" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Medalhas_Re",
                table: "Tbl_Medalhas",
                column: "Re");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Policial_CodOpm",
                table: "Tbl_Policial",
                column: "CodOpm");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Medalhas");

            migrationBuilder.DropTable(
                name: "Tbl_Policial");

            migrationBuilder.DropTable(
                name: "Tbl_Opm");
        }
    }
}
