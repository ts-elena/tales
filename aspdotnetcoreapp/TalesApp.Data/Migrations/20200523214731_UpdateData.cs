using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TalesApp.Data.Migrations
{
    public partial class UpdateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "CharacterAvatar", "CharacterName" },
                values: new object[,]
                {
                    { new Guid("f5447d23-7618-4d4a-9e65-0918c776c380"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/FannyHatter.jpg", "Fanny" },
                    { new Guid("055d8f22-74b9-48a3-93b4-20e3342033ed"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/Sophie.jfif", "Sophie" },
                    { new Guid("14a9f638-5eff-49d2-8113-9b27bd924c48"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister1.jfif", "Sophie's sister" },
                    { new Guid("374de42d-a6d4-4480-b912-29c761f8564f"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister2.jfif", "Sophie's sister" },
                    { new Guid("0e4a9b40-096e-4257-bc7c-81a44ff07237"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/LettieHatter.png", "Sophie's sister" }
                });

            migrationBuilder.InsertData(
                table: "StorySet",
                columns: new[] { "StorySetId", "StorySetName" },
                values: new object[] { new Guid("b565f90a-5183-46cf-bc4f-961290b13fed"), "Set One" });

            migrationBuilder.InsertData(
                table: "Story",
                columns: new[] { "StoryId", "StoryCoverImage", "StoryName", "StorySetId" },
                values: new object[] { new Guid("23a5d12c-3cea-49e2-8ebe-84311d039298"), "/images/StoriesData/MovingCastleOpeningStory/HowlsMovingCastleCover.jfif", "Opening Story of Howl's Moving Castle", new Guid("b565f90a-5183-46cf-bc4f-961290b13fed") });

            migrationBuilder.InsertData(
                table: "StorySetNumber",
                columns: new[] { "StorySetId", "SetNumber" },
                values: new object[] { new Guid("b565f90a-5183-46cf-bc4f-961290b13fed"), 1 });

            migrationBuilder.InsertData(
                table: "Line",
                columns: new[] { "LineId", "CharacterId", "LineContent", "StoryId" },
                values: new object[,]
                {
                    { new Guid("27c253d0-05d0-4daf-9273-55e80f151aa0"), new Guid("f5447d23-7618-4d4a-9e65-0918c776c380"), "Sophie, we have just closed the shop. You have done enough work, why won't you come out with us this time?", new Guid("23a5d12c-3cea-49e2-8ebe-84311d039298") },
                    { new Guid("23626604-af65-43a0-a8c7-1997672cd597"), new Guid("055d8f22-74b9-48a3-93b4-20e3342033ed"), "No, I would better finish this. Go have some fun.", new Guid("23a5d12c-3cea-49e2-8ebe-84311d039298") },
                    { new Guid("60254cc1-08ab-443f-a660-507c56a8dfe5"), new Guid("14a9f638-5eff-49d2-8113-9b27bd924c48"), "Look, it is Howl's castle!", new Guid("23a5d12c-3cea-49e2-8ebe-84311d039298") },
                    { new Guid("f0b15a82-7cd5-4e27-b0fb-b0289ec11c59"), new Guid("374de42d-a6d4-4480-b912-29c761f8564f"), "Never seen it so close before!", new Guid("23a5d12c-3cea-49e2-8ebe-84311d039298") },
                    { new Guid("cae12067-27bb-4887-b9a3-0f79a2bc4be8"), new Guid("14a9f638-5eff-49d2-8113-9b27bd924c48"), "Oh, my... I wonder if Howl is in town.", new Guid("23a5d12c-3cea-49e2-8ebe-84311d039298") },
                    { new Guid("712d83b8-98c8-4e8d-a7d5-10a84359c706"), new Guid("0e4a9b40-096e-4257-bc7c-81a44ff07237"), "Oh, it is gone!", new Guid("23a5d12c-3cea-49e2-8ebe-84311d039298") },
                    { new Guid("936f5613-6aad-4e58-b9d5-7881073a3754"), new Guid("14a9f638-5eff-49d2-8113-9b27bd924c48"), "No, he is just hiding in the fog from all of those planes.", new Guid("23a5d12c-3cea-49e2-8ebe-84311d039298") },
                    { new Guid("ab65d99b-fe7f-44e7-8a94-36ac1174ba5e"), new Guid("374de42d-a6d4-4480-b912-29c761f8564f"), "Remember Martha, from South Heaven? They say Howl tore her heart out.", new Guid("23a5d12c-3cea-49e2-8ebe-84311d039298") },
                    { new Guid("9075ad2f-b447-4080-9f3b-d0891a34e3cd"), new Guid("0e4a9b40-096e-4257-bc7c-81a44ff07237"), "Remember Martha, from South Heaven? They say Howl tore her heart out.", new Guid("23a5d12c-3cea-49e2-8ebe-84311d039298") },
                    { new Guid("ef182f17-4404-4b16-8606-4a691245b3fa"), new Guid("374de42d-a6d4-4480-b912-29c761f8564f"), "Now I am scared to go out!", new Guid("23a5d12c-3cea-49e2-8ebe-84311d039298") },
                    { new Guid("ea854290-c158-4ade-bc16-3dc6378586e4"), new Guid("14a9f638-5eff-49d2-8113-9b27bd924c48"), "Don't worry, he only prays on pretty girls!", new Guid("23a5d12c-3cea-49e2-8ebe-84311d039298") },
                    { new Guid("8d0b726d-9b8d-4def-9fcc-119e1f0c2271"), new Guid("f5447d23-7618-4d4a-9e65-0918c776c380"), "Come on, girls! Hurry up!", new Guid("23a5d12c-3cea-49e2-8ebe-84311d039298") }
                });

            migrationBuilder.InsertData(
                table: "LineNumber",
                columns: new[] { "LineId", "Number" },
                values: new object[,]
                {
                    { new Guid("27c253d0-05d0-4daf-9273-55e80f151aa0"), 1 },
                    { new Guid("23626604-af65-43a0-a8c7-1997672cd597"), 2 },
                    { new Guid("60254cc1-08ab-443f-a660-507c56a8dfe5"), 3 },
                    { new Guid("f0b15a82-7cd5-4e27-b0fb-b0289ec11c59"), 4 },
                    { new Guid("cae12067-27bb-4887-b9a3-0f79a2bc4be8"), 5 },
                    { new Guid("712d83b8-98c8-4e8d-a7d5-10a84359c706"), 6 },
                    { new Guid("936f5613-6aad-4e58-b9d5-7881073a3754"), 7 },
                    { new Guid("ab65d99b-fe7f-44e7-8a94-36ac1174ba5e"), 8 },
                    { new Guid("9075ad2f-b447-4080-9f3b-d0891a34e3cd"), 9 },
                    { new Guid("ef182f17-4404-4b16-8606-4a691245b3fa"), 10 },
                    { new Guid("ea854290-c158-4ade-bc16-3dc6378586e4"), 11 },
                    { new Guid("8d0b726d-9b8d-4def-9fcc-119e1f0c2271"), 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("23626604-af65-43a0-a8c7-1997672cd597"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("27c253d0-05d0-4daf-9273-55e80f151aa0"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("60254cc1-08ab-443f-a660-507c56a8dfe5"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("712d83b8-98c8-4e8d-a7d5-10a84359c706"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("8d0b726d-9b8d-4def-9fcc-119e1f0c2271"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("9075ad2f-b447-4080-9f3b-d0891a34e3cd"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("936f5613-6aad-4e58-b9d5-7881073a3754"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("ab65d99b-fe7f-44e7-8a94-36ac1174ba5e"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("cae12067-27bb-4887-b9a3-0f79a2bc4be8"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("ea854290-c158-4ade-bc16-3dc6378586e4"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("ef182f17-4404-4b16-8606-4a691245b3fa"));

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumn: "LineId",
                keyValue: new Guid("f0b15a82-7cd5-4e27-b0fb-b0289ec11c59"));

            migrationBuilder.DeleteData(
                table: "StorySetNumber",
                keyColumn: "StorySetId",
                keyValue: new Guid("b565f90a-5183-46cf-bc4f-961290b13fed"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("23626604-af65-43a0-a8c7-1997672cd597"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("27c253d0-05d0-4daf-9273-55e80f151aa0"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("60254cc1-08ab-443f-a660-507c56a8dfe5"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("712d83b8-98c8-4e8d-a7d5-10a84359c706"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("8d0b726d-9b8d-4def-9fcc-119e1f0c2271"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("9075ad2f-b447-4080-9f3b-d0891a34e3cd"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("936f5613-6aad-4e58-b9d5-7881073a3754"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("ab65d99b-fe7f-44e7-8a94-36ac1174ba5e"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("cae12067-27bb-4887-b9a3-0f79a2bc4be8"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("ea854290-c158-4ade-bc16-3dc6378586e4"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("ef182f17-4404-4b16-8606-4a691245b3fa"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumn: "LineId",
                keyValue: new Guid("f0b15a82-7cd5-4e27-b0fb-b0289ec11c59"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("055d8f22-74b9-48a3-93b4-20e3342033ed"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("0e4a9b40-096e-4257-bc7c-81a44ff07237"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("14a9f638-5eff-49d2-8113-9b27bd924c48"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("374de42d-a6d4-4480-b912-29c761f8564f"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("f5447d23-7618-4d4a-9e65-0918c776c380"));

            migrationBuilder.DeleteData(
                table: "Story",
                keyColumn: "StoryId",
                keyValue: new Guid("23a5d12c-3cea-49e2-8ebe-84311d039298"));

            migrationBuilder.DeleteData(
                table: "StorySet",
                keyColumn: "StorySetId",
                keyValue: new Guid("b565f90a-5183-46cf-bc4f-961290b13fed"));

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
    }
}
