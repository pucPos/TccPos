using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebMedForms.Migrations
{
    /// <inheritdoc />
    public partial class prioridadeajuste3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "prioridade",
                table: "Solicitacao",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "prioridade",
                table: "Solicitacao");
        }
    }
}
