using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaaS_PDV.Migrations
{
    /// <inheritdoc />
    public partial class AtualizandoCargosEAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMasterAdmin",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CriadoPor",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Empresas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Nivel",
                table: "Cargos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMasterAdmin",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "CriadoPor",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "Nivel",
                table: "Cargos");
        }
    }
}
