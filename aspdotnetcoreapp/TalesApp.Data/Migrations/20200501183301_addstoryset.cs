using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TalesApp.Data.Migrations
{
    public partial class addstoryset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StorySets",
                columns: new[] { "StorySetId", "StorySetName" },
                values: new object[] { new Guid("f4709f4e-b81e-48b4-a4d3-c44a99f3057d"), "Starter" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StorySets",
                keyColumn: "StorySetId",
                keyValue: new Guid("f4709f4e-b81e-48b4-a4d3-c44a99f3057d"));
        }
    }
}
