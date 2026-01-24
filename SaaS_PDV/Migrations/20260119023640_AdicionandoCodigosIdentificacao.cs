using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaaS_PDV.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoCodigosIdentificacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Filiais",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Empresas",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Filiais");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Empresas");
        }
    }
}
