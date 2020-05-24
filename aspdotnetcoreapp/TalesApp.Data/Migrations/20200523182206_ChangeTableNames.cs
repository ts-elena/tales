using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TalesApp.Data.Migrations
{
    public partial class ChangeTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DictionaryWords_Lines_LineId",
                table: "DictionaryWords");

            migrationBuilder.DropForeignKey(
                name: "FK_Lines_Characters_CharacterId",
                table: "Lines");

            migrationBuilder.DropForeignKey(
                name: "FK_Lines_Stories_StoryId",
                table: "Lines");

            migrationBuilder.DropForeignKey(
                name: "FK_Stories_StorySets_StorySetId",
                table: "Stories");

            migrationBuilder.DropTable(
                name: "LineSequences");

            migrationBuilder.DropTable(
                name: "StorySetsSequences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StorySets",
                table: "StorySets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stories",
                table: "Stories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lines",
                table: "Lines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DictionaryWords",
                table: "DictionaryWords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Characters",
                table: "Characters");

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("167a92c5-7f34-4be1-b6c8-ee396c7ae122"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("2ce0f84b-bf87-4c29-92ac-1b68cbbf66ba"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("4450397c-ebfa-4e40-98e9-83a88337bc27"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("6a23b4f0-6524-410d-8466-c8b9f0a4676c"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("863ee926-37ff-4ab8-97dd-94d14883f85b"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("94507b55-2690-439a-bcf0-a1d0aac881f5"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("ae500c1f-e734-423d-a0fa-d862f7ff69b3"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("b69fdb5a-19ed-4be0-a160-1d7970fe6b70"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("d5502289-46d5-4eea-aebf-7f5ef2bc64d8"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("d726c01c-c4a1-46a0-a92d-a3e097cecfa4"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("ed9f81ef-8ac5-4a6c-babe-a254303059a4"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("f8bc27ca-f5d4-41e1-8a11-8ebb228654b6"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("107c0d9f-1c8d-4832-b25f-737779b4c604"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("4274eaf5-de9a-4fbc-a6fd-e59f3f8158b8"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("8e7c45ab-6805-4c27-bb42-4be6548bdaf0"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("a247f0d7-c23f-41e7-b66d-628dfd0d06ee"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("b4162d1f-52e8-4872-b9dc-dc6a6fcfdf40"));

            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "StoryId",
                keyValue: new Guid("170d55ca-9254-48e9-8535-e463dde768a5"));

            migrationBuilder.DeleteData(
                table: "StorySets",
                keyColumn: "StorySetId",
                keyValue: new Guid("ac225e0d-ef1e-48c0-9050-5f9eda46d513"));

            migrationBuilder.RenameTable(
                name: "StorySets",
                newName: "StorySet");

            migrationBuilder.RenameTable(
                name: "Stories",
                newName: "Story");

            migrationBuilder.RenameTable(
                name: "Lines",
                newName: "Line");

            migrationBuilder.RenameTable(
                name: "DictionaryWords",
                newName: "DictionaryWord");

            migrationBuilder.RenameTable(
                name: "Characters",
                newName: "Character");

            migrationBuilder.RenameIndex(
                name: "IX_Stories_StorySetId",
                table: "Story",
                newName: "IX_Story_StorySetId");

            migrationBuilder.RenameIndex(
                name: "IX_Lines_StoryId",
                table: "Line",
                newName: "IX_Line_StoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Lines_CharacterId",
                table: "Line",
                newName: "IX_Line_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_DictionaryWords_LineId",
                table: "DictionaryWord",
                newName: "IX_DictionaryWord_LineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StorySet",
                table: "StorySet",
                column: "StorySetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Story",
                table: "Story",
                column: "StoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Line",
                table: "Line",
                column: "LineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DictionaryWord",
                table: "DictionaryWord",
                column: "DictionaryWordId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Character",
                table: "Character",
                column: "CharacterId");

            migrationBuilder.CreateTable(
                name: "LineNumber",
                columns: table => new
                {
                    LineId = table.Column<Guid>(nullable: false),
                    Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineNumber", x => x.LineId);
                    table.ForeignKey(
                        name: "FK_LineNumber_Line_LineId",
                        column: x => x.LineId,
                        principalTable: "Line",
                        principalColumn: "LineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StorySetNumber",
                columns: table => new
                {
                    StorySetId = table.Column<Guid>(nullable: false),
                    SetNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorySetNumber", x => x.StorySetId);
                    table.ForeignKey(
                        name: "FK_StorySetNumber_StorySet_StorySetId",
                        column: x => x.StorySetId,
                        principalTable: "StorySet",
                        principalColumn: "StorySetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DictionaryWord_Line_LineId",
                table: "DictionaryWord",
                column: "LineId",
                principalTable: "Line",
                principalColumn: "LineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Line_Character_CharacterId",
                table: "Line",
                column: "CharacterId",
                principalTable: "Character",
                principalColumn: "CharacterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Line_Story_StoryId",
                table: "Line",
                column: "StoryId",
                principalTable: "Story",
                principalColumn: "StoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Story_StorySet_StorySetId",
                table: "Story",
                column: "StorySetId",
                principalTable: "StorySet",
                principalColumn: "StorySetId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DictionaryWord_Line_LineId",
                table: "DictionaryWord");

            migrationBuilder.DropForeignKey(
                name: "FK_Line_Character_CharacterId",
                table: "Line");

            migrationBuilder.DropForeignKey(
                name: "FK_Line_Story_StoryId",
                table: "Line");

            migrationBuilder.DropForeignKey(
                name: "FK_Story_StorySet_StorySetId",
                table: "Story");

            migrationBuilder.DropTable(
                name: "LineNumber");

            migrationBuilder.DropTable(
                name: "StorySetNumber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StorySet",
                table: "StorySet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Story",
                table: "Story");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Line",
                table: "Line");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DictionaryWord",
                table: "DictionaryWord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Character",
                table: "Character");

            migrationBuilder.RenameTable(
                name: "StorySet",
                newName: "StorySets");

            migrationBuilder.RenameTable(
                name: "Story",
                newName: "Stories");

            migrationBuilder.RenameTable(
                name: "Line",
                newName: "Lines");

            migrationBuilder.RenameTable(
                name: "DictionaryWord",
                newName: "DictionaryWords");

            migrationBuilder.RenameTable(
                name: "Character",
                newName: "Characters");

            migrationBuilder.RenameIndex(
                name: "IX_Story_StorySetId",
                table: "Stories",
                newName: "IX_Stories_StorySetId");

            migrationBuilder.RenameIndex(
                name: "IX_Line_StoryId",
                table: "Lines",
                newName: "IX_Lines_StoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Line_CharacterId",
                table: "Lines",
                newName: "IX_Lines_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_DictionaryWord_LineId",
                table: "DictionaryWords",
                newName: "IX_DictionaryWords_LineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StorySets",
                table: "StorySets",
                column: "StorySetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stories",
                table: "Stories",
                column: "StoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lines",
                table: "Lines",
                column: "LineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DictionaryWords",
                table: "DictionaryWords",
                column: "DictionaryWordId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Characters",
                table: "Characters",
                column: "CharacterId");

            migrationBuilder.CreateTable(
                name: "LineSequences",
                columns: table => new
                {
                    LineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SequenceNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineSequences", x => x.LineId);
                    table.ForeignKey(
                        name: "FK_LineSequences_Lines_LineId",
                        column: x => x.LineId,
                        principalTable: "Lines",
                        principalColumn: "LineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StorySetsSequences",
                columns: table => new
                {
                    StorySetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SetNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorySetsSequences", x => x.StorySetId);
                    table.ForeignKey(
                        name: "FK_StorySetsSequences_StorySets_StorySetId",
                        column: x => x.StorySetId,
                        principalTable: "StorySets",
                        principalColumn: "StorySetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "CharacterAvatar", "CharacterName" },
                values: new object[,]
                {
                    { new Guid("8e7c45ab-6805-4c27-bb42-4be6548bdaf0"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/FannyHatter.jpg", "Fanny" },
                    { new Guid("a247f0d7-c23f-41e7-b66d-628dfd0d06ee"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/Sophie.jfif", "Sophie" },
                    { new Guid("b4162d1f-52e8-4872-b9dc-dc6a6fcfdf40"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister1.jfif", "Sophie's sister" },
                    { new Guid("107c0d9f-1c8d-4832-b25f-737779b4c604"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister2.jfif", "Sophie's sister" },
                    { new Guid("4274eaf5-de9a-4fbc-a6fd-e59f3f8158b8"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/LettieHatter.png", "Sophie's sister" }
                });

            migrationBuilder.InsertData(
                table: "StorySets",
                columns: new[] { "StorySetId", "StorySetName" },
                values: new object[] { new Guid("ac225e0d-ef1e-48c0-9050-5f9eda46d513"), "Set One" });

            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "StoryId", "StoryCoverImage", "StoryName", "StorySetId" },
                values: new object[] { new Guid("170d55ca-9254-48e9-8535-e463dde768a5"), "/images/StoriesData/MovingCastleOpeningStory/HowlsMovingCastleCover.jfif", "Opening Story of Howl's Moving Castle", new Guid("ac225e0d-ef1e-48c0-9050-5f9eda46d513") });

            migrationBuilder.InsertData(
                table: "StorySetsSequences",
                columns: new[] { "StorySetId", "SetNumber" },
                values: new object[] { new Guid("ac225e0d-ef1e-48c0-9050-5f9eda46d513"), 1 });

            migrationBuilder.InsertData(
                table: "Lines",
                columns: new[] { "LineId", "CharacterId", "LineContent", "StoryId" },
                values: new object[,]
                {
                    { new Guid("b69fdb5a-19ed-4be0-a160-1d7970fe6b70"), new Guid("8e7c45ab-6805-4c27-bb42-4be6548bdaf0"), "Sophie, we have just closed the shop. You have done enough work, why won't you come out with us this time?", new Guid("170d55ca-9254-48e9-8535-e463dde768a5") },
                    { new Guid("2ce0f84b-bf87-4c29-92ac-1b68cbbf66ba"), new Guid("a247f0d7-c23f-41e7-b66d-628dfd0d06ee"), "No, I would better finish this. Go have some fun.", new Guid("170d55ca-9254-48e9-8535-e463dde768a5") },
                    { new Guid("94507b55-2690-439a-bcf0-a1d0aac881f5"), new Guid("b4162d1f-52e8-4872-b9dc-dc6a6fcfdf40"), "Look, it is Howl's castle!", new Guid("170d55ca-9254-48e9-8535-e463dde768a5") },
                    { new Guid("ed9f81ef-8ac5-4a6c-babe-a254303059a4"), new Guid("107c0d9f-1c8d-4832-b25f-737779b4c604"), "Never seen it so close before!", new Guid("170d55ca-9254-48e9-8535-e463dde768a5") },
                    { new Guid("d726c01c-c4a1-46a0-a92d-a3e097cecfa4"), new Guid("b4162d1f-52e8-4872-b9dc-dc6a6fcfdf40"), "Oh, my... I wonder if Howl is in town.", new Guid("170d55ca-9254-48e9-8535-e463dde768a5") },
                    { new Guid("ae500c1f-e734-423d-a0fa-d862f7ff69b3"), new Guid("4274eaf5-de9a-4fbc-a6fd-e59f3f8158b8"), "Oh, it is gone!", new Guid("170d55ca-9254-48e9-8535-e463dde768a5") },
                    { new Guid("167a92c5-7f34-4be1-b6c8-ee396c7ae122"), new Guid("b4162d1f-52e8-4872-b9dc-dc6a6fcfdf40"), "No, he is just hiding in the fog from all of those planes.", new Guid("170d55ca-9254-48e9-8535-e463dde768a5") },
                    { new Guid("d5502289-46d5-4eea-aebf-7f5ef2bc64d8"), new Guid("107c0d9f-1c8d-4832-b25f-737779b4c604"), "Remember Martha, from South Heaven? They say Howl tore her heart out.", new Guid("170d55ca-9254-48e9-8535-e463dde768a5") },
                    { new Guid("4450397c-ebfa-4e40-98e9-83a88337bc27"), new Guid("4274eaf5-de9a-4fbc-a6fd-e59f3f8158b8"), "Remember Martha, from South Heaven? They say Howl tore her heart out.", new Guid("170d55ca-9254-48e9-8535-e463dde768a5") },
                    { new Guid("f8bc27ca-f5d4-41e1-8a11-8ebb228654b6"), new Guid("107c0d9f-1c8d-4832-b25f-737779b4c604"), "Now I am scared to go out!", new Guid("170d55ca-9254-48e9-8535-e463dde768a5") },
                    { new Guid("6a23b4f0-6524-410d-8466-c8b9f0a4676c"), new Guid("b4162d1f-52e8-4872-b9dc-dc6a6fcfdf40"), "Don't worry, he only prays on pretty girls!", new Guid("170d55ca-9254-48e9-8535-e463dde768a5") },
                    { new Guid("863ee926-37ff-4ab8-97dd-94d14883f85b"), new Guid("8e7c45ab-6805-4c27-bb42-4be6548bdaf0"), "Come on, girls! Hurry up!", new Guid("170d55ca-9254-48e9-8535-e463dde768a5") }
                });

            migrationBuilder.InsertData(
                table: "LineSequences",
                columns: new[] { "LineId", "SequenceNumber" },
                values: new object[,]
                {
                    { new Guid("b69fdb5a-19ed-4be0-a160-1d7970fe6b70"), 1 },
                    { new Guid("2ce0f84b-bf87-4c29-92ac-1b68cbbf66ba"), 2 },
                    { new Guid("94507b55-2690-439a-bcf0-a1d0aac881f5"), 3 },
                    { new Guid("ed9f81ef-8ac5-4a6c-babe-a254303059a4"), 4 },
                    { new Guid("d726c01c-c4a1-46a0-a92d-a3e097cecfa4"), 5 },
                    { new Guid("ae500c1f-e734-423d-a0fa-d862f7ff69b3"), 6 },
                    { new Guid("167a92c5-7f34-4be1-b6c8-ee396c7ae122"), 7 },
                    { new Guid("d5502289-46d5-4eea-aebf-7f5ef2bc64d8"), 8 },
                    { new Guid("4450397c-ebfa-4e40-98e9-83a88337bc27"), 9 },
                    { new Guid("f8bc27ca-f5d4-41e1-8a11-8ebb228654b6"), 10 },
                    { new Guid("6a23b4f0-6524-410d-8466-c8b9f0a4676c"), 11 },
                    { new Guid("863ee926-37ff-4ab8-97dd-94d14883f85b"), 12 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DictionaryWords_Lines_LineId",
                table: "DictionaryWords",
                column: "LineId",
                principalTable: "Lines",
                principalColumn: "LineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lines_Characters_CharacterId",
                table: "Lines",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "CharacterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lines_Stories_StoryId",
                table: "Lines",
                column: "StoryId",
                principalTable: "Stories",
                principalColumn: "StoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_StorySets_StorySetId",
                table: "Stories",
                column: "StorySetId",
                principalTable: "StorySets",
                principalColumn: "StorySetId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
