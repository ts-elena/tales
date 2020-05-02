﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TalesApp.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<Guid>(nullable: false),
                    CharacterName = table.Column<string>(nullable: false),
                    CharacterAvatar = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                });

            migrationBuilder.CreateTable(
                name: "StorySets",
                columns: table => new
                {
                    StorySetId = table.Column<Guid>(nullable: false),
                    StorySetName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorySets", x => x.StorySetId);
                });

            migrationBuilder.CreateTable(
                name: "Stories",
                columns: table => new
                {
                    StoryId = table.Column<Guid>(nullable: false),
                    StoryName = table.Column<string>(nullable: false),
                    StoryCoverImage = table.Column<string>(nullable: false),
                    StorySetId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stories", x => x.StoryId);
                    table.ForeignKey(
                        name: "FK_Stories_StorySets_StorySetId",
                        column: x => x.StorySetId,
                        principalTable: "StorySets",
                        principalColumn: "StorySetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lines",
                columns: table => new
                {
                    LineId = table.Column<Guid>(nullable: false),
                    StoryId = table.Column<Guid>(nullable: false),
                    LineContent = table.Column<string>(nullable: false),
                    CharacterId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lines", x => new { x.LineId, x.StoryId });
                    table.ForeignKey(
                        name: "FK_Lines_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lines_Stories_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Stories",
                        principalColumn: "StoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DictionaryWords",
                columns: table => new
                {
                    DictionaryWordId = table.Column<Guid>(nullable: false),
                    LineId1 = table.Column<Guid>(nullable: false),
                    LineStoryId = table.Column<Guid>(nullable: false),
                    LineId = table.Column<Guid>(nullable: false),
                    DictionaryWordText = table.Column<string>(nullable: false),
                    WordAddedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictionaryWords", x => x.DictionaryWordId);
                    table.ForeignKey(
                        name: "FK_DictionaryWords_Lines_LineId1_LineStoryId",
                        columns: x => new { x.LineId1, x.LineStoryId },
                        principalTable: "Lines",
                        principalColumns: new[] { "LineId", "StoryId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineSequences",
                columns: table => new
                {
                    LineId = table.Column<Guid>(nullable: false),
                    LineNumber = table.Column<int>(nullable: false),
                    LineId1 = table.Column<Guid>(nullable: false),
                    LineStoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineSequences", x => x.LineId);
                    table.ForeignKey(
                        name: "FK_LineSequences_Lines_LineId1_LineStoryId",
                        columns: x => new { x.LineId1, x.LineStoryId },
                        principalTable: "Lines",
                        principalColumns: new[] { "LineId", "StoryId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DictionaryWords_LineId1_LineStoryId",
                table: "DictionaryWords",
                columns: new[] { "LineId1", "LineStoryId" });

            migrationBuilder.CreateIndex(
                name: "IX_Lines_CharacterId",
                table: "Lines",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Lines_StoryId",
                table: "Lines",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LineSequences_LineId1_LineStoryId",
                table: "LineSequences",
                columns: new[] { "LineId1", "LineStoryId" });

            migrationBuilder.CreateIndex(
                name: "IX_Stories_StorySetId",
                table: "Stories",
                column: "StorySetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DictionaryWords");

            migrationBuilder.DropTable(
                name: "LineSequences");

            migrationBuilder.DropTable(
                name: "Lines");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Stories");

            migrationBuilder.DropTable(
                name: "StorySets");
        }
    }
}
