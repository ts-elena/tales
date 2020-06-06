using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TalesApp.Data.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Character",
                columns: table => new
                {
                    CharacterId = table.Column<Guid>(nullable: false),
                    CharacterName = table.Column<string>(maxLength: 254, nullable: false),
                    CharacterAvatar = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Character", x => x.CharacterId);
                });

            migrationBuilder.CreateTable(
                name: "StorySet",
                columns: table => new
                {
                    StorySetId = table.Column<Guid>(nullable: false),
                    StorySetName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorySet", x => x.StorySetId);
                });

            migrationBuilder.CreateTable(
                name: "Story",
                columns: table => new
                {
                    StoryId = table.Column<Guid>(nullable: false),
                    StoryName = table.Column<string>(nullable: false),
                    StoryCoverImage = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    StorySetId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Story", x => x.StoryId);
                    table.ForeignKey(
                        name: "FK_Story_StorySet_StorySetId",
                        column: x => x.StorySetId,
                        principalTable: "StorySet",
                        principalColumn: "StorySetId",
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

            migrationBuilder.CreateTable(
                name: "Line",
                columns: table => new
                {
                    LineId = table.Column<Guid>(nullable: false),
                    StoryId = table.Column<Guid>(nullable: false),
                    LineContent = table.Column<string>(nullable: false),
                    CharacterId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Line", x => new { x.LineId, x.StoryId });
                    table.ForeignKey(
                        name: "FK_Line_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Line_Story_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Story",
                        principalColumn: "StoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DictionaryWord",
                columns: table => new
                {
                    DictionaryWordId = table.Column<Guid>(nullable: false),
                    LineId1 = table.Column<Guid>(nullable: true),
                    LineStoryId = table.Column<Guid>(nullable: true),
                    DictionaryWordText = table.Column<string>(nullable: false),
                    WordAddedTime = table.Column<DateTime>(nullable: false),
                    LineId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictionaryWord", x => x.DictionaryWordId);
                    table.ForeignKey(
                        name: "FK_DictionaryWord_Line_LineId1_LineStoryId",
                        columns: x => new { x.LineId1, x.LineStoryId },
                        principalTable: "Line",
                        principalColumns: new[] { "LineId", "StoryId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LineNumber",
                columns: table => new
                {
                    LineId = table.Column<Guid>(nullable: false),
                    StoryId = table.Column<Guid>(nullable: false),
                    Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineNumber", x => new { x.LineId, x.StoryId });
                    table.ForeignKey(
                        name: "FK_LineNumber_Line_LineId_StoryId",
                        columns: x => new { x.LineId, x.StoryId },
                        principalTable: "Line",
                        principalColumns: new[] { "LineId", "StoryId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "CharacterAvatar", "CharacterName" },
                values: new object[,]
                {
                    { new Guid("a099544c-150e-4558-b9fd-00df9f391384"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/FannyHatter.jpg", "Fanny" },
                    { new Guid("136b056d-e165-4b06-993d-a52830470b7a"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/Sophie.jfif", "Sophie" },
                    { new Guid("41cf6f15-7982-468f-b4b4-67ba9c178953"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister1.jfif", "Sophie's sister" },
                    { new Guid("451f4b8f-8314-4698-9094-dae4f425b975"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister2.jfif", "Sophie's sister" },
                    { new Guid("8e36a954-aa7e-4047-85c1-94e5b40f4783"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/LettieHatter.png", "Sophie's sister" }
                });

            migrationBuilder.InsertData(
                table: "StorySet",
                columns: new[] { "StorySetId", "StorySetName" },
                values: new object[] { new Guid("21e6de0a-6d44-4cd8-92ed-ab50d7d2730b"), "Set One" });

            migrationBuilder.InsertData(
                table: "Story",
                columns: new[] { "StoryId", "IsActive", "StoryCoverImage", "StoryName", "StorySetId" },
                values: new object[] { new Guid("cf72a438-8242-4211-a974-6415571a42c8"), false, "/images/StoriesData/MovingCastleOpeningStory/HowlsMovingCastleCover.jfif", "Opening Story of Howl's Moving Castle", new Guid("21e6de0a-6d44-4cd8-92ed-ab50d7d2730b") });

            migrationBuilder.InsertData(
                table: "StorySetNumber",
                columns: new[] { "StorySetId", "SetNumber" },
                values: new object[] { new Guid("21e6de0a-6d44-4cd8-92ed-ab50d7d2730b"), 1 });

            migrationBuilder.InsertData(
                table: "Line",
                columns: new[] { "LineId", "StoryId", "CharacterId", "LineContent" },
                values: new object[,]
                {
                    { new Guid("7699725c-00be-4db0-832b-bec10d609f39"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), new Guid("a099544c-150e-4558-b9fd-00df9f391384"), "Sophie, we have just closed the shop. You have done enough work, why won't you come out with us this time?" },
                    { new Guid("10e74286-03c9-442a-a956-762904804b5d"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), new Guid("136b056d-e165-4b06-993d-a52830470b7a"), "No, I would better finish this. Go have some fun." },
                    { new Guid("0adffb34-de4a-4dce-ba4e-f8f450ff2507"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), new Guid("41cf6f15-7982-468f-b4b4-67ba9c178953"), "Look, it is Howl's castle!" },
                    { new Guid("56ad5649-60f9-4958-b802-22d32ed35bea"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), new Guid("451f4b8f-8314-4698-9094-dae4f425b975"), "Never seen it so close before!" },
                    { new Guid("0d8cb57c-993d-4829-ace6-13c7927d54e7"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), new Guid("41cf6f15-7982-468f-b4b4-67ba9c178953"), "Oh, my... I wonder if Howl is in town." },
                    { new Guid("6926e033-f24d-4dc9-b465-a8577bddb8d2"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), new Guid("8e36a954-aa7e-4047-85c1-94e5b40f4783"), "Oh, it is gone!" },
                    { new Guid("67abc004-265c-464f-bed3-f4de2764e446"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), new Guid("41cf6f15-7982-468f-b4b4-67ba9c178953"), "No, he is just hiding in the fog from all of those planes." },
                    { new Guid("f6d9a365-ccc2-47e2-94eb-89c529548853"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), new Guid("451f4b8f-8314-4698-9094-dae4f425b975"), "Remember Martha, from South Heaven? They say Howl tore her heart out." },
                    { new Guid("7ec57893-2219-4015-811e-f3c520ba125c"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), new Guid("8e36a954-aa7e-4047-85c1-94e5b40f4783"), "Remember Martha, from South Heaven? They say Howl tore her heart out." },
                    { new Guid("8e859168-021d-4eb6-9b13-1bf8169dda1e"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), new Guid("451f4b8f-8314-4698-9094-dae4f425b975"), "Now I am scared to go out!" },
                    { new Guid("3465982c-6d40-4fe2-9824-768bb087fe9f"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), new Guid("41cf6f15-7982-468f-b4b4-67ba9c178953"), "Don't worry, he only prays on pretty girls!" },
                    { new Guid("6f4486fd-8261-46e0-bb0b-010a7924dcfe"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), new Guid("a099544c-150e-4558-b9fd-00df9f391384"), "Come on, girls! Hurry up!" }
                });

            migrationBuilder.InsertData(
                table: "LineNumber",
                columns: new[] { "LineId", "StoryId", "Number" },
                values: new object[,]
                {
                    { new Guid("7699725c-00be-4db0-832b-bec10d609f39"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), 1 },
                    { new Guid("10e74286-03c9-442a-a956-762904804b5d"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), 2 },
                    { new Guid("0adffb34-de4a-4dce-ba4e-f8f450ff2507"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), 3 },
                    { new Guid("56ad5649-60f9-4958-b802-22d32ed35bea"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), 4 },
                    { new Guid("0d8cb57c-993d-4829-ace6-13c7927d54e7"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), 5 },
                    { new Guid("6926e033-f24d-4dc9-b465-a8577bddb8d2"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), 6 },
                    { new Guid("67abc004-265c-464f-bed3-f4de2764e446"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), 7 },
                    { new Guid("f6d9a365-ccc2-47e2-94eb-89c529548853"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), 8 },
                    { new Guid("7ec57893-2219-4015-811e-f3c520ba125c"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), 9 },
                    { new Guid("8e859168-021d-4eb6-9b13-1bf8169dda1e"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), 10 },
                    { new Guid("3465982c-6d40-4fe2-9824-768bb087fe9f"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), 11 },
                    { new Guid("6f4486fd-8261-46e0-bb0b-010a7924dcfe"), new Guid("cf72a438-8242-4211-a974-6415571a42c8"), 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DictionaryWord_LineId1_LineStoryId",
                table: "DictionaryWord",
                columns: new[] { "LineId1", "LineStoryId" });

            migrationBuilder.CreateIndex(
                name: "IX_Line_CharacterId",
                table: "Line",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Line_StoryId",
                table: "Line",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Story_StorySetId",
                table: "Story",
                column: "StorySetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DictionaryWord");

            migrationBuilder.DropTable(
                name: "LineNumber");

            migrationBuilder.DropTable(
                name: "StorySetNumber");

            migrationBuilder.DropTable(
                name: "Line");

            migrationBuilder.DropTable(
                name: "Character");

            migrationBuilder.DropTable(
                name: "Story");

            migrationBuilder.DropTable(
                name: "StorySet");
        }
    }
}
