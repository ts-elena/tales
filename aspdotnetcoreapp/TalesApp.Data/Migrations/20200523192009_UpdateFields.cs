using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TalesApp.Data.Migrations
{
    public partial class UpdateFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "StorySetName",
                table: "StorySet",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "CharacterAvatar", "CharacterName" },
                values: new object[,]
                {
                    { new Guid("f9043c0b-0457-4648-bd34-3f373369ba86"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/FannyHatter.jpg", "Fanny" },
                    { new Guid("f5753b26-be64-4efa-83ea-5e84e51441c1"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/Sophie.jfif", "Sophie" },
                    { new Guid("d803563f-d59e-48db-92cf-b6088aa9eff0"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister1.jfif", "Sophie's sister" },
                    { new Guid("a1452de9-680e-436c-835b-adf1647b6bc0"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister2.jfif", "Sophie's sister" },
                    { new Guid("8479d28a-1147-419c-8157-45f359883490"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/LettieHatter.png", "Sophie's sister" }
                });

            migrationBuilder.InsertData(
                table: "StorySet",
                columns: new[] { "StorySetId", "StorySetName" },
                values: new object[] { new Guid("7991b278-958e-40eb-ace9-9a337a350934"), "Set One" });

            migrationBuilder.InsertData(
                table: "Story",
                columns: new[] { "StoryId", "StoryCoverImage", "StoryName", "StorySetId" },
                values: new object[] { new Guid("be84da75-fc6e-43a2-a7e2-655b9f86fcd8"), "/images/StoriesData/MovingCastleOpeningStory/HowlsMovingCastleCover.jfif", "Opening Story of Howl's Moving Castle", new Guid("7991b278-958e-40eb-ace9-9a337a350934") });

            migrationBuilder.InsertData(
                table: "StorySetNumber",
                columns: new[] { "StorySetId", "SetNumber" },
                values: new object[] { new Guid("7991b278-958e-40eb-ace9-9a337a350934"), 1 });

            migrationBuilder.InsertData(
                table: "Line",
                columns: new[] { "LineId", "CharacterId", "LineContent", "StoryId" },
                values: new object[,]
                {
                    { new Guid("1c19c998-a28b-4cde-ba96-cb9bc3cd718d"), new Guid("f9043c0b-0457-4648-bd34-3f373369ba86"), "Sophie, we have just closed the shop. You have done enough work, why won't you come out with us this time?", new Guid("be84da75-fc6e-43a2-a7e2-655b9f86fcd8") },
                    { new Guid("e3c6a231-8e62-49de-9131-2957cbcd5fd6"), new Guid("f5753b26-be64-4efa-83ea-5e84e51441c1"), "No, I would better finish this. Go have some fun.", new Guid("be84da75-fc6e-43a2-a7e2-655b9f86fcd8") },
                    { new Guid("445cbed2-c472-4d84-9c06-90ec861a651f"), new Guid("d803563f-d59e-48db-92cf-b6088aa9eff0"), "Look, it is Howl's castle!", new Guid("be84da75-fc6e-43a2-a7e2-655b9f86fcd8") },
                    { new Guid("66b284e4-a272-42fa-a8c9-8e7b0af9c646"), new Guid("a1452de9-680e-436c-835b-adf1647b6bc0"), "Never seen it so close before!", new Guid("be84da75-fc6e-43a2-a7e2-655b9f86fcd8") },
                    { new Guid("c33e5c69-3503-487b-803e-f7ed60cc74b1"), new Guid("d803563f-d59e-48db-92cf-b6088aa9eff0"), "Oh, my... I wonder if Howl is in town.", new Guid("be84da75-fc6e-43a2-a7e2-655b9f86fcd8") },
                    { new Guid("d8b23816-17eb-4825-ad44-99c566b1593c"), new Guid("8479d28a-1147-419c-8157-45f359883490"), "Oh, it is gone!", new Guid("be84da75-fc6e-43a2-a7e2-655b9f86fcd8") },
                    { new Guid("849a68b1-7c1d-484e-9ccc-a672bdedc0c5"), new Guid("d803563f-d59e-48db-92cf-b6088aa9eff0"), "No, he is just hiding in the fog from all of those planes.", new Guid("be84da75-fc6e-43a2-a7e2-655b9f86fcd8") },
                    { new Guid("c94bed16-4263-4a8f-b57c-3fa91d04f0e3"), new Guid("a1452de9-680e-436c-835b-adf1647b6bc0"), "Remember Martha, from South Heaven? They say Howl tore her heart out.", new Guid("be84da75-fc6e-43a2-a7e2-655b9f86fcd8") },
                    { new Guid("a80c2892-073c-4c8b-af39-ea41de6bd1ab"), new Guid("8479d28a-1147-419c-8157-45f359883490"), "Remember Martha, from South Heaven? They say Howl tore her heart out.", new Guid("be84da75-fc6e-43a2-a7e2-655b9f86fcd8") },
                    { new Guid("6fb2e385-fc52-4756-8559-cfa21197b108"), new Guid("a1452de9-680e-436c-835b-adf1647b6bc0"), "Now I am scared to go out!", new Guid("be84da75-fc6e-43a2-a7e2-655b9f86fcd8") },
                    { new Guid("70120b08-8dd1-4a99-ab44-e0025a93dd93"), new Guid("d803563f-d59e-48db-92cf-b6088aa9eff0"), "Don't worry, he only prays on pretty girls!", new Guid("be84da75-fc6e-43a2-a7e2-655b9f86fcd8") },
                    { new Guid("725b82ee-87a6-401b-98bb-2ae018ad52a5"), new Guid("f9043c0b-0457-4648-bd34-3f373369ba86"), "Come on, girls! Hurry up!", new Guid("be84da75-fc6e-43a2-a7e2-655b9f86fcd8") }
                });

            migrationBuilder.InsertData(
                table: "LineNumber",
                columns: new[] { "LineId", "Number" },
                values: new object[,]
                {
                    { new Guid("1c19c998-a28b-4cde-ba96-cb9bc3cd718d"), 1 },
                    { new Guid("e3c6a231-8e62-49de-9131-2957cbcd5fd6"), 2 },
                    { new Guid("445cbed2-c472-4d84-9c06-90ec861a651f"), 3 },
                    { new Guid("66b284e4-a272-42fa-a8c9-8e7b0af9c646"), 4 },
                    { new Guid("c33e5c69-3503-487b-803e-f7ed60cc74b1"), 5 },
                    { new Guid("d8b23816-17eb-4825-ad44-99c566b1593c"), 6 },
                    { new Guid("849a68b1-7c1d-484e-9ccc-a672bdedc0c5"), 7 },
                    { new Guid("c94bed16-4263-4a8f-b57c-3fa91d04f0e3"), 8 },
                    { new Guid("a80c2892-073c-4c8b-af39-ea41de6bd1ab"), 9 },
                    { new Guid("6fb2e385-fc52-4756-8559-cfa21197b108"), 10 },
                    { new Guid("70120b08-8dd1-4a99-ab44-e0025a93dd93"), 11 },
                    { new Guid("725b82ee-87a6-401b-98bb-2ae018ad52a5"), 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("1c19c998-a28b-4cde-ba96-cb9bc3cd718d"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("445cbed2-c472-4d84-9c06-90ec861a651f"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("66b284e4-a272-42fa-a8c9-8e7b0af9c646"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("6fb2e385-fc52-4756-8559-cfa21197b108"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("70120b08-8dd1-4a99-ab44-e0025a93dd93"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("725b82ee-87a6-401b-98bb-2ae018ad52a5"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("849a68b1-7c1d-484e-9ccc-a672bdedc0c5"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("a80c2892-073c-4c8b-af39-ea41de6bd1ab"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("c33e5c69-3503-487b-803e-f7ed60cc74b1"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("c94bed16-4263-4a8f-b57c-3fa91d04f0e3"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("d8b23816-17eb-4825-ad44-99c566b1593c"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("e3c6a231-8e62-49de-9131-2957cbcd5fd6"));

            migrationBuilder.DeleteData(
                table: "StorySetNumber",
                keyColumn: "StorySetId",
                keyValue: new Guid("7991b278-958e-40eb-ace9-9a337a350934"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("1c19c998-a28b-4cde-ba96-cb9bc3cd718d"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("445cbed2-c472-4d84-9c06-90ec861a651f"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("66b284e4-a272-42fa-a8c9-8e7b0af9c646"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("6fb2e385-fc52-4756-8559-cfa21197b108"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("70120b08-8dd1-4a99-ab44-e0025a93dd93"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("725b82ee-87a6-401b-98bb-2ae018ad52a5"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("849a68b1-7c1d-484e-9ccc-a672bdedc0c5"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("a80c2892-073c-4c8b-af39-ea41de6bd1ab"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("c33e5c69-3503-487b-803e-f7ed60cc74b1"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("c94bed16-4263-4a8f-b57c-3fa91d04f0e3"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("d8b23816-17eb-4825-ad44-99c566b1593c"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("e3c6a231-8e62-49de-9131-2957cbcd5fd6"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("8479d28a-1147-419c-8157-45f359883490"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("a1452de9-680e-436c-835b-adf1647b6bc0"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("d803563f-d59e-48db-92cf-b6088aa9eff0"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("f5753b26-be64-4efa-83ea-5e84e51441c1"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("f9043c0b-0457-4648-bd34-3f373369ba86"));

            migrationBuilder.DeleteData(
                table: "Story",
                keyColumn: "StoryId",
                keyValue: new Guid("be84da75-fc6e-43a2-a7e2-655b9f86fcd8"));

            migrationBuilder.DeleteData(
                table: "StorySet",
                keyColumn: "StorySetId",
                keyValue: new Guid("7991b278-958e-40eb-ace9-9a337a350934"));

            migrationBuilder.AlterColumn<string>(
                name: "StorySetName",
                table: "StorySet",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

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
    }
}
