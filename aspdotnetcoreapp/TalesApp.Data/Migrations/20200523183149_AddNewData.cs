using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TalesApp.Data.Migrations
{
    public partial class AddNewData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "CharacterAvatar", "CharacterName" },
                values: new object[,]
                {
                    { new Guid("268d8089-532f-428e-961a-e97ae90628be"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/FannyHatter.jpg", "Fanny" },
                    { new Guid("1336847e-f6d3-4024-a3b9-3d0c9fa37986"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/Sophie.jfif", "Sophie" },
                    { new Guid("32654180-4b4c-4df1-ab87-4ebc555d8354"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister1.jfif", "Sophie's sister" },
                    { new Guid("52d7d788-7409-4ab2-a12b-39f73392eac7"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister2.jfif", "Sophie's sister" },
                    { new Guid("5b805d31-0e44-46b2-99a9-166d359665d0"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/LettieHatter.png", "Sophie's sister" }
                });

            migrationBuilder.InsertData(
                table: "StorySet",
                columns: new[] { "StorySetId", "StorySetName" },
                values: new object[] { new Guid("11325591-1e14-48a2-bab7-d0d1232114e5"), "Set One" });

            migrationBuilder.InsertData(
                table: "Story",
                columns: new[] { "StoryId", "StoryCoverImage", "StoryName", "StorySetId" },
                values: new object[] { new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc"), "/images/StoriesData/MovingCastleOpeningStory/HowlsMovingCastleCover.jfif", "Opening Story of Howl's Moving Castle", new Guid("11325591-1e14-48a2-bab7-d0d1232114e5") });

            migrationBuilder.InsertData(
                table: "StorySetNumber",
                columns: new[] { "StorySetId", "SetNumber" },
                values: new object[] { new Guid("11325591-1e14-48a2-bab7-d0d1232114e5"), 1 });

            migrationBuilder.InsertData(
                table: "Line",
                columns: new[] { "LineId", "CharacterId", "LineContent", "StoryId" },
                values: new object[,]
                {
                    { new Guid("4a6b931b-55db-4e35-a0e5-b0f7f5b63ef0"), new Guid("268d8089-532f-428e-961a-e97ae90628be"), "Sophie, we have just closed the shop. You have done enough work, why won't you come out with us this time?", new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc") },
                    { new Guid("ea7b7c6c-db82-4369-946b-7b7a5397148f"), new Guid("1336847e-f6d3-4024-a3b9-3d0c9fa37986"), "No, I would better finish this. Go have some fun.", new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc") },
                    { new Guid("fa2c8997-fe27-4431-beeb-588d4997b02c"), new Guid("32654180-4b4c-4df1-ab87-4ebc555d8354"), "Look, it is Howl's castle!", new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc") },
                    { new Guid("6dcd01b2-e95d-40ba-987d-b805f0a16ef5"), new Guid("52d7d788-7409-4ab2-a12b-39f73392eac7"), "Never seen it so close before!", new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc") },
                    { new Guid("fb08e7a1-c096-4c0b-a61a-e67353182c98"), new Guid("32654180-4b4c-4df1-ab87-4ebc555d8354"), "Oh, my... I wonder if Howl is in town.", new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc") },
                    { new Guid("364ff5c0-c9c0-40f7-b0f2-9d1b8badd912"), new Guid("5b805d31-0e44-46b2-99a9-166d359665d0"), "Oh, it is gone!", new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc") },
                    { new Guid("8e3577d3-d2ba-4230-8a8a-f43b07175b03"), new Guid("32654180-4b4c-4df1-ab87-4ebc555d8354"), "No, he is just hiding in the fog from all of those planes.", new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc") },
                    { new Guid("d3676082-b2a5-44a6-be5b-ada29c5f3dd7"), new Guid("52d7d788-7409-4ab2-a12b-39f73392eac7"), "Remember Martha, from South Heaven? They say Howl tore her heart out.", new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc") },
                    { new Guid("e801a81a-1cd0-48a6-a2f5-848ef9e88ba7"), new Guid("5b805d31-0e44-46b2-99a9-166d359665d0"), "Remember Martha, from South Heaven? They say Howl tore her heart out.", new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc") },
                    { new Guid("be091ae8-a3a5-4b78-a2cc-37c6cba1a6eb"), new Guid("52d7d788-7409-4ab2-a12b-39f73392eac7"), "Now I am scared to go out!", new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc") },
                    { new Guid("b391acb9-0dac-4e8f-9c58-5e65900fcfd9"), new Guid("32654180-4b4c-4df1-ab87-4ebc555d8354"), "Don't worry, he only prays on pretty girls!", new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc") },
                    { new Guid("030a4e40-24b5-4555-8d12-3d66b52669ab"), new Guid("268d8089-532f-428e-961a-e97ae90628be"), "Come on, girls! Hurry up!", new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc") }
                });

            migrationBuilder.InsertData(
                table: "LineNumber",
                columns: new[] { "LineId", "Number" },
                values: new object[,]
                {
                    { new Guid("4a6b931b-55db-4e35-a0e5-b0f7f5b63ef0"), 1 },
                    { new Guid("ea7b7c6c-db82-4369-946b-7b7a5397148f"), 2 },
                    { new Guid("fa2c8997-fe27-4431-beeb-588d4997b02c"), 3 },
                    { new Guid("6dcd01b2-e95d-40ba-987d-b805f0a16ef5"), 4 },
                    { new Guid("fb08e7a1-c096-4c0b-a61a-e67353182c98"), 5 },
                    { new Guid("364ff5c0-c9c0-40f7-b0f2-9d1b8badd912"), 6 },
                    { new Guid("8e3577d3-d2ba-4230-8a8a-f43b07175b03"), 7 },
                    { new Guid("d3676082-b2a5-44a6-be5b-ada29c5f3dd7"), 8 },
                    { new Guid("e801a81a-1cd0-48a6-a2f5-848ef9e88ba7"), 9 },
                    { new Guid("be091ae8-a3a5-4b78-a2cc-37c6cba1a6eb"), 10 },
                    { new Guid("b391acb9-0dac-4e8f-9c58-5e65900fcfd9"), 11 },
                    { new Guid("030a4e40-24b5-4555-8d12-3d66b52669ab"), 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("030a4e40-24b5-4555-8d12-3d66b52669ab"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("364ff5c0-c9c0-40f7-b0f2-9d1b8badd912"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("4a6b931b-55db-4e35-a0e5-b0f7f5b63ef0"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("6dcd01b2-e95d-40ba-987d-b805f0a16ef5"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("8e3577d3-d2ba-4230-8a8a-f43b07175b03"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("b391acb9-0dac-4e8f-9c58-5e65900fcfd9"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("be091ae8-a3a5-4b78-a2cc-37c6cba1a6eb"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("d3676082-b2a5-44a6-be5b-ada29c5f3dd7"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("e801a81a-1cd0-48a6-a2f5-848ef9e88ba7"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("ea7b7c6c-db82-4369-946b-7b7a5397148f"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("fa2c8997-fe27-4431-beeb-588d4997b02c"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("fb08e7a1-c096-4c0b-a61a-e67353182c98"));

            migrationBuilder.DeleteData(
                table: "StorySetNumber",
                keyColumn: "StorySetId",
                keyValue: new Guid("11325591-1e14-48a2-bab7-d0d1232114e5"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("030a4e40-24b5-4555-8d12-3d66b52669ab"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("364ff5c0-c9c0-40f7-b0f2-9d1b8badd912"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("4a6b931b-55db-4e35-a0e5-b0f7f5b63ef0"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("6dcd01b2-e95d-40ba-987d-b805f0a16ef5"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("8e3577d3-d2ba-4230-8a8a-f43b07175b03"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("b391acb9-0dac-4e8f-9c58-5e65900fcfd9"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("be091ae8-a3a5-4b78-a2cc-37c6cba1a6eb"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("d3676082-b2a5-44a6-be5b-ada29c5f3dd7"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("e801a81a-1cd0-48a6-a2f5-848ef9e88ba7"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("ea7b7c6c-db82-4369-946b-7b7a5397148f"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("fa2c8997-fe27-4431-beeb-588d4997b02c"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("fb08e7a1-c096-4c0b-a61a-e67353182c98"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("1336847e-f6d3-4024-a3b9-3d0c9fa37986"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("268d8089-532f-428e-961a-e97ae90628be"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("32654180-4b4c-4df1-ab87-4ebc555d8354"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("52d7d788-7409-4ab2-a12b-39f73392eac7"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("5b805d31-0e44-46b2-99a9-166d359665d0"));

            migrationBuilder.DeleteData(
                table: "Story",
                keyColumn: "StoryId",
                keyValue: new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc"));

            migrationBuilder.DeleteData(
                table: "StorySet",
                keyColumn: "StorySetId",
                keyValue: new Guid("11325591-1e14-48a2-bab7-d0d1232114e5"));
        }
    }
}
