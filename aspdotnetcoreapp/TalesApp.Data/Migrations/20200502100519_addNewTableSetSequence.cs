using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TalesApp.Data.Migrations
{
    public partial class addNewTableSetSequence : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StorySets",
                keyColumn: "StorySetId",
                keyValue: new Guid("f4709f4e-b81e-48b4-a4d3-c44a99f3057d"));

            migrationBuilder.AddColumn<Guid>(
                name: "StorySetsSequenceStorySetId",
                table: "StorySets",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StorySetsSequences",
                columns: table => new
                {
                    StorySetId = table.Column<Guid>(nullable: false),
                    SetNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorySetsSequences", x => x.StorySetId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StorySets_StorySetsSequenceStorySetId",
                table: "StorySets",
                column: "StorySetsSequenceStorySetId");

            migrationBuilder.AddForeignKey(
                name: "FK_StorySets_StorySetsSequences_StorySetsSequenceStorySetId",
                table: "StorySets",
                column: "StorySetsSequenceStorySetId",
                principalTable: "StorySetsSequences",
                principalColumn: "StorySetId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StorySets_StorySetsSequences_StorySetsSequenceStorySetId",
                table: "StorySets");

            migrationBuilder.DropTable(
                name: "StorySetsSequences");

            migrationBuilder.DropIndex(
                name: "IX_StorySets_StorySetsSequenceStorySetId",
                table: "StorySets");

            migrationBuilder.DropColumn(
                name: "StorySetsSequenceStorySetId",
                table: "StorySets");

            migrationBuilder.InsertData(
                table: "StorySets",
                columns: new[] { "StorySetId", "StorySetName" },
                values: new object[] { new Guid("f4709f4e-b81e-48b4-a4d3-c44a99f3057d"), "Starter" });
        }
    }
}
