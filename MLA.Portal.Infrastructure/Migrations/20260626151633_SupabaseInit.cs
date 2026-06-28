using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MLA.Portal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SupabaseInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Msr_Village",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Msr_LocalBody",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Msr_District",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Msr_Village");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Msr_LocalBody");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Msr_District");
        }
    }
}
