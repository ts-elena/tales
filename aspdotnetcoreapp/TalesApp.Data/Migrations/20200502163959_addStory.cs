using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TalesApp.Data.Migrations
{
    public partial class addStory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StorySets",
                columns: new[] { "StorySetId", "StorySetName", "StorySetsSequenceStorySetId" },
                values: new object[] { new Guid("964c4453-a7f3-4d74-a6fd-4132dcfa59cc"), "Set 1", null });

            migrationBuilder.InsertData(
                table: "StorySetsSequences",
                columns: new[] { "StorySetId", "SetNumber" },
                values: new object[] { new Guid("964c4453-a7f3-4d74-a6fd-4132dcfa59cc"), 0 });

            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "StoryId", "StoryCoverImage", "StoryName", "StorySetId" },
                values: new object[] { new Guid("e738b6dd-bb98-47e2-841c-6643d425df2e"), "/images/howls-moving-castle.jfif", "Opening Story of Howl's Moving Castle", new Guid("964c4453-a7f3-4d74-a6fd-4132dcfa59cc") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "StoryId",
                keyValue: new Guid("e738b6dd-bb98-47e2-841c-6643d425df2e"));

            migrationBuilder.DeleteData(
                table: "StorySetsSequences",
                keyColumn: "StorySetId",
                keyValue: new Guid("964c4453-a7f3-4d74-a6fd-4132dcfa59cc"));

            migrationBuilder.DeleteData(
                table: "StorySets",
                keyColumn: "StorySetId",
                keyValue: new Guid("964c4453-a7f3-4d74-a6fd-4132dcfa59cc"));
        }
    }
}
