using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TalesApp.Data.Migrations
{
    public partial class Initial : Migration
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
                    Number = table.Column<int>(nullable: false),
                    IsLast = table.Column<bool>(nullable: false)
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
                    { new Guid("da6e1bd0-c970-43c1-8516-1e814807c9ca"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/FannyHatter.jpg", "Fanny" },
                    { new Guid("567b0bb4-1e3b-4007-bd8b-12327d5983a9"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/Sophie.jfif", "Sophie" },
                    { new Guid("de4b251f-e985-492b-abe3-0256e4ac3da5"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister1.jfif", "Sophie's sister" },
                    { new Guid("68526821-1a33-42a8-a01e-855867644119"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister2.jfif", "Sophie's sister" },
                    { new Guid("b85bf3d6-7014-43f0-8051-727c9745517d"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/LettieHatter.png", "Sophie's sister" }
                });

            migrationBuilder.InsertData(
                table: "StorySet",
                columns: new[] { "StorySetId", "StorySetName" },
                values: new object[] { new Guid("4f26cc1c-9748-4c37-ab31-6ea40d66550a"), "Set One" });

            migrationBuilder.InsertData(
                table: "Story",
                columns: new[] { "StoryId", "IsActive", "StoryCoverImage", "StoryName", "StorySetId" },
                values: new object[] { new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), false, "/images/StoriesData/MovingCastleOpeningStory/HowlsMovingCastleCover.jfif", "Opening Story of Howl's Moving Castle", new Guid("4f26cc1c-9748-4c37-ab31-6ea40d66550a") });

            migrationBuilder.InsertData(
                table: "StorySetNumber",
                columns: new[] { "StorySetId", "SetNumber" },
                values: new object[] { new Guid("4f26cc1c-9748-4c37-ab31-6ea40d66550a"), 1 });

            migrationBuilder.InsertData(
                table: "Line",
                columns: new[] { "LineId", "StoryId", "CharacterId", "LineContent" },
                values: new object[,]
                {
                    { new Guid("daa31b35-9859-4b4a-b053-b65a9ecd8d15"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), new Guid("da6e1bd0-c970-43c1-8516-1e814807c9ca"), "Sophie, we have just closed the shop. You have done enough work, why won't you come out with us this time?" },
                    { new Guid("564d4795-ebca-4e8a-8bb5-2089c1f0e6ea"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), new Guid("567b0bb4-1e3b-4007-bd8b-12327d5983a9"), "No, I would better finish this. Go have some fun." },
                    { new Guid("54f7cacf-b2aa-4778-92a4-8ac86fb57b3c"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), new Guid("de4b251f-e985-492b-abe3-0256e4ac3da5"), "Look, it is Howl's castle!" },
                    { new Guid("c8061cc0-a281-4ca4-ad3c-3edc321a6929"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), new Guid("68526821-1a33-42a8-a01e-855867644119"), "Never seen it so close before!" },
                    { new Guid("0b9550af-8637-4373-8873-de2cb7131b79"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), new Guid("de4b251f-e985-492b-abe3-0256e4ac3da5"), "Oh, my... I wonder if Howl is in town." },
                    { new Guid("efc7b9c5-c16d-4d7b-b4f7-3f84eb329118"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), new Guid("b85bf3d6-7014-43f0-8051-727c9745517d"), "Oh, it is gone!" },
                    { new Guid("a57b5392-d025-4792-89b4-2809746371c5"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), new Guid("de4b251f-e985-492b-abe3-0256e4ac3da5"), "No, he is just hiding in the fog from all of those planes." },
                    { new Guid("6a1fde30-d496-477f-a982-7bccace88c50"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), new Guid("68526821-1a33-42a8-a01e-855867644119"), "Ah, now I see!" },
                    { new Guid("c49cb2ae-b328-43ca-a968-bbaeff925f3c"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), new Guid("b85bf3d6-7014-43f0-8051-727c9745517d"), "Remember Martha, from South Heaven? They say Howl tore her heart out." },
                    { new Guid("1a9db9ee-c830-4cc9-811b-9a9be198d187"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), new Guid("68526821-1a33-42a8-a01e-855867644119"), "Now I am scared to go out!" },
                    { new Guid("cef31226-c93b-4847-b8ca-fb152d7cebf1"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), new Guid("de4b251f-e985-492b-abe3-0256e4ac3da5"), "Don't worry, he only prays on pretty girls!" },
                    { new Guid("885b77ba-8349-4640-becf-282d12404904"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), new Guid("da6e1bd0-c970-43c1-8516-1e814807c9ca"), "Come on, girls! Hurry up!" }
                });

            migrationBuilder.InsertData(
                table: "LineNumber",
                columns: new[] { "LineId", "StoryId", "IsLast", "Number" },
                values: new object[,]
                {
                    { new Guid("daa31b35-9859-4b4a-b053-b65a9ecd8d15"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), false, 1 },
                    { new Guid("564d4795-ebca-4e8a-8bb5-2089c1f0e6ea"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), false, 2 },
                    { new Guid("54f7cacf-b2aa-4778-92a4-8ac86fb57b3c"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), false, 3 },
                    { new Guid("c8061cc0-a281-4ca4-ad3c-3edc321a6929"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), false, 4 },
                    { new Guid("0b9550af-8637-4373-8873-de2cb7131b79"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), false, 5 },
                    { new Guid("efc7b9c5-c16d-4d7b-b4f7-3f84eb329118"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), false, 6 },
                    { new Guid("a57b5392-d025-4792-89b4-2809746371c5"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), false, 7 },
                    { new Guid("6a1fde30-d496-477f-a982-7bccace88c50"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), false, 8 },
                    { new Guid("c49cb2ae-b328-43ca-a968-bbaeff925f3c"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), false, 9 },
                    { new Guid("1a9db9ee-c830-4cc9-811b-9a9be198d187"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), false, 10 },
                    { new Guid("cef31226-c93b-4847-b8ca-fb152d7cebf1"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), false, 11 },
                    { new Guid("885b77ba-8349-4640-becf-282d12404904"), new Guid("99b43ca2-dcac-419a-9725-2413202bb624"), true, 12 }
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
