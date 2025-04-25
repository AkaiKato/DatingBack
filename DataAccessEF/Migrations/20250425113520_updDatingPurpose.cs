using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessEF.Migrations
{
    /// <inheritdoc />
    public partial class updDatingPurpose : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalTagProfiles_Books_PersonalTagId",
                table: "PersonalTagProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalTagProfiles_PersonalTags_PersonalTagId1",
                table: "PersonalTagProfiles");

            migrationBuilder.DropIndex(
                name: "IX_PersonalTagProfiles_PersonalTagId1",
                table: "PersonalTagProfiles");

            migrationBuilder.DropColumn(
                name: "PersonalTagId1",
                table: "PersonalTagProfiles");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalTagProfiles_PersonalTags_PersonalTagId",
                table: "PersonalTagProfiles",
                column: "PersonalTagId",
                principalTable: "PersonalTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalTagProfiles_PersonalTags_PersonalTagId",
                table: "PersonalTagProfiles");

            migrationBuilder.AddColumn<Guid>(
                name: "PersonalTagId1",
                table: "PersonalTagProfiles",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalTagProfiles_PersonalTagId1",
                table: "PersonalTagProfiles",
                column: "PersonalTagId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalTagProfiles_Books_PersonalTagId",
                table: "PersonalTagProfiles",
                column: "PersonalTagId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalTagProfiles_PersonalTags_PersonalTagId1",
                table: "PersonalTagProfiles",
                column: "PersonalTagId1",
                principalTable: "PersonalTags",
                principalColumn: "Id");
        }
    }
}
