using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessEF.Migrations
{
    /// <inheritdoc />
    public partial class upd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Profiles_ProfileId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Interests_Profiles_ProfileId",
                table: "Interests");

            migrationBuilder.DropForeignKey(
                name: "FK_Musicans_Profiles_ProfileId",
                table: "Musicans");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalTags_Profiles_ProfileId",
                table: "PersonalTags");

            migrationBuilder.DropForeignKey(
                name: "FK_TVMedias_Profiles_ProfileId",
                table: "TVMedias");

            migrationBuilder.DropIndex(
                name: "IX_TVMedias_ProfileId",
                table: "TVMedias");

            migrationBuilder.DropIndex(
                name: "IX_PersonalTags_ProfileId",
                table: "PersonalTags");

            migrationBuilder.DropIndex(
                name: "IX_Musicans_ProfileId",
                table: "Musicans");

            migrationBuilder.DropIndex(
                name: "IX_Interests_ProfileId",
                table: "Interests");

            migrationBuilder.DropIndex(
                name: "IX_Books_ProfileId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "TVMedias");

            migrationBuilder.DropColumn(
                name: "DatingPurpose",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "PersonalTags");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Musicans");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TVMedias",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "DatingPurposeId",
                table: "Profiles",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PersonalTags",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Musicans",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Interests",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Books",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "BookProfiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BookId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProfileId = table.Column<Guid>(type: "uuid", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookProfiles_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookProfiles_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DatingPurpose",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatingPurpose", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterestProfiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    InterestId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProfileId = table.Column<Guid>(type: "uuid", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterestProfiles_Interests_InterestId",
                        column: x => x.InterestId,
                        principalTable: "Interests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterestProfiles_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MusicanProfiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MusicanId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProfileId = table.Column<Guid>(type: "uuid", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicanProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusicanProfiles_Musicans_MusicanId",
                        column: x => x.MusicanId,
                        principalTable: "Musicans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusicanProfiles_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalTagProfiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PersonalTagId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProfileId = table.Column<Guid>(type: "uuid", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    PersonalTagId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalTagProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalTagProfiles_Books_PersonalTagId",
                        column: x => x.PersonalTagId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalTagProfiles_PersonalTags_PersonalTagId1",
                        column: x => x.PersonalTagId1,
                        principalTable: "PersonalTags",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PersonalTagProfiles_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TVMediaProfiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TVMediasId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProfileId = table.Column<Guid>(type: "uuid", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TVMediaProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TVMediaProfiles_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TVMediaProfiles_TVMedias_TVMediasId",
                        column: x => x.TVMediasId,
                        principalTable: "TVMedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_DatingPurposeId",
                table: "Profiles",
                column: "DatingPurposeId");

            migrationBuilder.CreateIndex(
                name: "IX_BookProfiles_BookId",
                table: "BookProfiles",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookProfiles_ProfileId",
                table: "BookProfiles",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_InterestProfiles_InterestId",
                table: "InterestProfiles",
                column: "InterestId");

            migrationBuilder.CreateIndex(
                name: "IX_InterestProfiles_ProfileId",
                table: "InterestProfiles",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_MusicanProfiles_MusicanId",
                table: "MusicanProfiles",
                column: "MusicanId");

            migrationBuilder.CreateIndex(
                name: "IX_MusicanProfiles_ProfileId",
                table: "MusicanProfiles",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalTagProfiles_PersonalTagId",
                table: "PersonalTagProfiles",
                column: "PersonalTagId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalTagProfiles_PersonalTagId1",
                table: "PersonalTagProfiles",
                column: "PersonalTagId1");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalTagProfiles_ProfileId",
                table: "PersonalTagProfiles",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_TVMediaProfiles_ProfileId",
                table: "TVMediaProfiles",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_TVMediaProfiles_TVMediasId",
                table: "TVMediaProfiles",
                column: "TVMediasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_DatingPurpose_DatingPurposeId",
                table: "Profiles",
                column: "DatingPurposeId",
                principalTable: "DatingPurpose",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_DatingPurpose_DatingPurposeId",
                table: "Profiles");

            migrationBuilder.DropTable(
                name: "BookProfiles");

            migrationBuilder.DropTable(
                name: "DatingPurpose");

            migrationBuilder.DropTable(
                name: "InterestProfiles");

            migrationBuilder.DropTable(
                name: "MusicanProfiles");

            migrationBuilder.DropTable(
                name: "PersonalTagProfiles");

            migrationBuilder.DropTable(
                name: "TVMediaProfiles");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_DatingPurposeId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TVMedias");

            migrationBuilder.DropColumn(
                name: "DatingPurposeId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "PersonalTags");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Musicans");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Books");

            migrationBuilder.AddColumn<Guid>(
                name: "ProfileId",
                table: "TVMedias",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DatingPurpose",
                table: "Profiles",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProfileId",
                table: "PersonalTags",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProfileId",
                table: "Musicans",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProfileId",
                table: "Interests",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProfileId",
                table: "Books",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TVMedias_ProfileId",
                table: "TVMedias",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalTags_ProfileId",
                table: "PersonalTags",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Musicans_ProfileId",
                table: "Musicans",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Interests_ProfileId",
                table: "Interests",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_ProfileId",
                table: "Books",
                column: "ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Profiles_ProfileId",
                table: "Books",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_Profiles_ProfileId",
                table: "Interests",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Musicans_Profiles_ProfileId",
                table: "Musicans",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalTags_Profiles_ProfileId",
                table: "PersonalTags",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TVMedias_Profiles_ProfileId",
                table: "TVMedias",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id");
        }
    }
}
