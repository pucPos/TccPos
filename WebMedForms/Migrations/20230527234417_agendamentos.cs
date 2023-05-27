using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebMedForms.Migrations
{
    /// <inheritdoc />
    public partial class agendamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "data_agendamento_1",
                table: "Solicitacao",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "data_agendamento_2",
                table: "Solicitacao",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "data_agendamento_3",
                table: "Solicitacao",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "data_agendamento_1",
                table: "Solicitacao");

            migrationBuilder.DropColumn(
                name: "data_agendamento_2",
                table: "Solicitacao");

            migrationBuilder.DropColumn(
                name: "data_agendamento_3",
                table: "Solicitacao");
        }
    }
}
