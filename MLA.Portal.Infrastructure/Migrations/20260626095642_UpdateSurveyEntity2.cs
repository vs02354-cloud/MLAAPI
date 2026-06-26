using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MLA.Portal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSurveyEntity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Assemblies_AssemblyId",
                table: "Surveys");

            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Districts_DistrictId",
                table: "Surveys");

            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_GramPanchayats_GramPanchayatId",
                table: "Surveys");

            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Villages_VillageId",
                table: "Surveys");

            migrationBuilder.DropIndex(
                name: "IX_Surveys_AssemblyId",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "AssemblyId",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Msr_Village");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Msr_Village");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Msr_LocalBody");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Msr_LocalBody");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Msr_District");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Msr_District");

            migrationBuilder.RenameColumn(
                name: "GramPanchayatId",
                table: "Surveys",
                newName: "LocalBodyId");

            migrationBuilder.RenameIndex(
                name: "IX_Surveys_GramPanchayatId",
                table: "Surveys",
                newName: "IX_Surveys_LocalBodyId");

            migrationBuilder.RenameColumn(
                name: "NameHi",
                table: "Msr_Village",
                newName: "VillageNameHindi");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "Msr_Village",
                newName: "VillageName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Msr_Village",
                newName: "VillageId");

            migrationBuilder.RenameColumn(
                name: "NameHi",
                table: "Msr_LocalBody",
                newName: "LocalBodyNameHindi");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "Msr_LocalBody",
                newName: "LocalBodyName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Msr_LocalBody",
                newName: "LocalBodyId");

            migrationBuilder.RenameColumn(
                name: "NameHi",
                table: "Msr_District",
                newName: "DistrictNameHindi");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "Msr_District",
                newName: "DistrictName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Msr_District",
                newName: "DistrictId");

            migrationBuilder.AddColumn<string>(
                name: "DevelopmentWorks",
                table: "Surveys",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Education",
                table: "Surveys",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Electricity",
                table: "Surveys",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GovtSchemes",
                table: "Surveys",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Health",
                table: "Surveys",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Road",
                table: "Surveys",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Satisfaction",
                table: "Surveys",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Water",
                table: "Surveys",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WillVote",
                table: "Surveys",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_Msr_District_DistrictId",
                table: "Surveys",
                column: "DistrictId",
                principalTable: "Msr_District",
                principalColumn: "DistrictId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_Msr_LocalBody_LocalBodyId",
                table: "Surveys",
                column: "LocalBodyId",
                principalTable: "Msr_LocalBody",
                principalColumn: "LocalBodyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_Msr_Village_VillageId",
                table: "Surveys",
                column: "VillageId",
                principalTable: "Msr_Village",
                principalColumn: "VillageId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Msr_District_DistrictId",
                table: "Surveys");

            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Msr_LocalBody_LocalBodyId",
                table: "Surveys");

            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Msr_Village_VillageId",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "DevelopmentWorks",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "Education",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "Electricity",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "GovtSchemes",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "Health",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "Road",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "Satisfaction",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "Water",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "WillVote",
                table: "Surveys");

            migrationBuilder.RenameColumn(
                name: "LocalBodyId",
                table: "Surveys",
                newName: "GramPanchayatId");

            migrationBuilder.RenameIndex(
                name: "IX_Surveys_LocalBodyId",
                table: "Surveys",
                newName: "IX_Surveys_GramPanchayatId");

            migrationBuilder.RenameColumn(
                name: "VillageNameHindi",
                table: "Msr_Village",
                newName: "NameHi");

            migrationBuilder.RenameColumn(
                name: "VillageName",
                table: "Msr_Village",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "VillageId",
                table: "Msr_Village",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LocalBodyNameHindi",
                table: "Msr_LocalBody",
                newName: "NameHi");

            migrationBuilder.RenameColumn(
                name: "LocalBodyName",
                table: "Msr_LocalBody",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "LocalBodyId",
                table: "Msr_LocalBody",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DistrictNameHindi",
                table: "Msr_District",
                newName: "NameHi");

            migrationBuilder.RenameColumn(
                name: "DistrictName",
                table: "Msr_District",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "DistrictId",
                table: "Msr_District",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "AssemblyId",
                table: "Surveys",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Msr_Village",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Msr_Village",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Msr_LocalBody",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Msr_LocalBody",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Msr_District",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Msr_District",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_AssemblyId",
                table: "Surveys",
                column: "AssemblyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_Assemblies_AssemblyId",
                table: "Surveys",
                column: "AssemblyId",
                principalTable: "Assemblies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_Districts_DistrictId",
                table: "Surveys",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_GramPanchayats_GramPanchayatId",
                table: "Surveys",
                column: "GramPanchayatId",
                principalTable: "GramPanchayats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_Villages_VillageId",
                table: "Surveys",
                column: "VillageId",
                principalTable: "Villages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
