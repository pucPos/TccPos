using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebMedForms.Migrations
{
    /// <inheritdoc />
    public partial class prioridadeajuste2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "prioridade",
                table: "Solicitacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "prioridade",
                table: "Solicitacao",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
