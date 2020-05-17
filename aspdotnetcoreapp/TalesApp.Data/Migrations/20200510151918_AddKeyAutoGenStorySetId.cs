using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TalesApp.Data.Migrations
{
    public partial class AddKeyAutoGenStorySetId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("40fbf41c-8919-4c65-962d-9287dc691f4d"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("49aad5e6-107f-4512-a58a-97bb29c08bf1"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("55f68e90-3c51-4064-8227-5f0eafee12ed"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("5c3a2fd8-00cf-4799-99fb-ad65e579896e"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("7589de9f-6561-428e-8bbe-b80f08294146"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("76f7f7b6-cadd-44c3-a05b-200459308560"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("86d2f2ca-8d7f-4ba6-a0f5-5ed06dbebb86"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("8a786f26-8c2d-4aff-b5a7-659c7741ef5d"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("8b6a5eb8-3911-4a5f-9222-78efb082d0c0"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("a8a3a9c5-b483-4948-80d6-9ece2dfaccaa"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("b47d2b97-a606-44bf-9606-2fc11b3777cd"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("fbc109e8-4bbd-45f7-ad93-858a57445b4e"));

            migrationBuilder.DeleteData(
                table: "StorySetsSequences",
                keyColumn: "StorySetId",
                keyValue: new Guid("5f415608-14bb-45da-aa31-8af5c9bd357a"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("40fbf41c-8919-4c65-962d-9287dc691f4d"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("49aad5e6-107f-4512-a58a-97bb29c08bf1"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("55f68e90-3c51-4064-8227-5f0eafee12ed"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("5c3a2fd8-00cf-4799-99fb-ad65e579896e"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("7589de9f-6561-428e-8bbe-b80f08294146"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("76f7f7b6-cadd-44c3-a05b-200459308560"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("86d2f2ca-8d7f-4ba6-a0f5-5ed06dbebb86"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("8a786f26-8c2d-4aff-b5a7-659c7741ef5d"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("8b6a5eb8-3911-4a5f-9222-78efb082d0c0"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("a8a3a9c5-b483-4948-80d6-9ece2dfaccaa"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("b47d2b97-a606-44bf-9606-2fc11b3777cd"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("fbc109e8-4bbd-45f7-ad93-858a57445b4e"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("34efd913-db35-4dfb-8330-99ed162b5e62"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("3b28f948-2d2a-4661-8675-65ad58485094"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("6e1cc3a9-12b8-49d5-b1e5-d77d56ee3ce3"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("c43be0f3-322d-42e3-b0c2-1361b9905537"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("df6dc5c2-8f6b-4d68-b2cb-12e9b721a221"));

            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "StoryId",
                keyValue: new Guid("19277692-d769-467f-9ecb-295ccb56dcbb"));

            migrationBuilder.DeleteData(
                table: "StorySets",
                keyColumn: "StorySetId",
                keyValue: new Guid("5f415608-14bb-45da-aa31-8af5c9bd357a"));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("167a92c5-7f34-4be1-b6c8-ee396c7ae122"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("2ce0f84b-bf87-4c29-92ac-1b68cbbf66ba"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("4450397c-ebfa-4e40-98e9-83a88337bc27"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("6a23b4f0-6524-410d-8466-c8b9f0a4676c"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("863ee926-37ff-4ab8-97dd-94d14883f85b"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("94507b55-2690-439a-bcf0-a1d0aac881f5"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("ae500c1f-e734-423d-a0fa-d862f7ff69b3"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("b69fdb5a-19ed-4be0-a160-1d7970fe6b70"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("d5502289-46d5-4eea-aebf-7f5ef2bc64d8"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("d726c01c-c4a1-46a0-a92d-a3e097cecfa4"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("ed9f81ef-8ac5-4a6c-babe-a254303059a4"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("f8bc27ca-f5d4-41e1-8a11-8ebb228654b6"));

            migrationBuilder.DeleteData(
                table: "StorySetsSequences",
                keyColumn: "StorySetId",
                keyValue: new Guid("ac225e0d-ef1e-48c0-9050-5f9eda46d513"));

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

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "CharacterAvatar", "CharacterName" },
                values: new object[,]
                {
                    { new Guid("34efd913-db35-4dfb-8330-99ed162b5e62"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/FannyHatter.jpg", "Fanny" },
                    { new Guid("c43be0f3-322d-42e3-b0c2-1361b9905537"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/Sophie.jfif", "Sophie" },
                    { new Guid("6e1cc3a9-12b8-49d5-b1e5-d77d56ee3ce3"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister1.jfif", "Sophie's sister" },
                    { new Guid("3b28f948-2d2a-4661-8675-65ad58485094"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister2.jfif", "Sophie's sister" },
                    { new Guid("df6dc5c2-8f6b-4d68-b2cb-12e9b721a221"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/LettieHatter.png", "Sophie's sister" }
                });

            migrationBuilder.InsertData(
                table: "StorySets",
                columns: new[] { "StorySetId", "StorySetName" },
                values: new object[] { new Guid("5f415608-14bb-45da-aa31-8af5c9bd357a"), "Set One" });

            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "StoryId", "StoryCoverImage", "StoryName", "StorySetId" },
                values: new object[] { new Guid("19277692-d769-467f-9ecb-295ccb56dcbb"), "/images/StoriesData/MovingCastleOpeningStory/HowlsMovingCastleCover.jfif", "Opening Story of Howl's Moving Castle", new Guid("5f415608-14bb-45da-aa31-8af5c9bd357a") });

            migrationBuilder.InsertData(
                table: "StorySetsSequences",
                columns: new[] { "StorySetId", "SetNumber" },
                values: new object[] { new Guid("5f415608-14bb-45da-aa31-8af5c9bd357a"), 1 });

            migrationBuilder.InsertData(
                table: "Lines",
                columns: new[] { "LineId", "CharacterId", "LineContent", "StoryId" },
                values: new object[,]
                {
                    { new Guid("49aad5e6-107f-4512-a58a-97bb29c08bf1"), new Guid("34efd913-db35-4dfb-8330-99ed162b5e62"), "Sophie, we have just closed the shop. You have done enough work, why won't you come out with us this time?", new Guid("19277692-d769-467f-9ecb-295ccb56dcbb") },
                    { new Guid("86d2f2ca-8d7f-4ba6-a0f5-5ed06dbebb86"), new Guid("c43be0f3-322d-42e3-b0c2-1361b9905537"), "No, I would better finish this. Go have some fun.", new Guid("19277692-d769-467f-9ecb-295ccb56dcbb") },
                    { new Guid("5c3a2fd8-00cf-4799-99fb-ad65e579896e"), new Guid("6e1cc3a9-12b8-49d5-b1e5-d77d56ee3ce3"), "Look, it is Howl's castle!", new Guid("19277692-d769-467f-9ecb-295ccb56dcbb") },
                    { new Guid("40fbf41c-8919-4c65-962d-9287dc691f4d"), new Guid("3b28f948-2d2a-4661-8675-65ad58485094"), "Never seen it so close before!", new Guid("19277692-d769-467f-9ecb-295ccb56dcbb") },
                    { new Guid("8a786f26-8c2d-4aff-b5a7-659c7741ef5d"), new Guid("6e1cc3a9-12b8-49d5-b1e5-d77d56ee3ce3"), "Oh, my... I wonder if Howl is in town.", new Guid("19277692-d769-467f-9ecb-295ccb56dcbb") },
                    { new Guid("a8a3a9c5-b483-4948-80d6-9ece2dfaccaa"), new Guid("df6dc5c2-8f6b-4d68-b2cb-12e9b721a221"), "Oh, it is gone!", new Guid("19277692-d769-467f-9ecb-295ccb56dcbb") },
                    { new Guid("7589de9f-6561-428e-8bbe-b80f08294146"), new Guid("6e1cc3a9-12b8-49d5-b1e5-d77d56ee3ce3"), "No, he is just hiding in the fog from all of those planes.", new Guid("19277692-d769-467f-9ecb-295ccb56dcbb") },
                    { new Guid("fbc109e8-4bbd-45f7-ad93-858a57445b4e"), new Guid("3b28f948-2d2a-4661-8675-65ad58485094"), "Remember Martha, from South Heaven? They say Howl tore her heart out.", new Guid("19277692-d769-467f-9ecb-295ccb56dcbb") },
                    { new Guid("76f7f7b6-cadd-44c3-a05b-200459308560"), new Guid("df6dc5c2-8f6b-4d68-b2cb-12e9b721a221"), "Remember Martha, from South Heaven? They say Howl tore her heart out.", new Guid("19277692-d769-467f-9ecb-295ccb56dcbb") },
                    { new Guid("b47d2b97-a606-44bf-9606-2fc11b3777cd"), new Guid("3b28f948-2d2a-4661-8675-65ad58485094"), "Now I am scared to go out!", new Guid("19277692-d769-467f-9ecb-295ccb56dcbb") },
                    { new Guid("8b6a5eb8-3911-4a5f-9222-78efb082d0c0"), new Guid("6e1cc3a9-12b8-49d5-b1e5-d77d56ee3ce3"), "Don't worry, he only prays on pretty girls!", new Guid("19277692-d769-467f-9ecb-295ccb56dcbb") },
                    { new Guid("55f68e90-3c51-4064-8227-5f0eafee12ed"), new Guid("34efd913-db35-4dfb-8330-99ed162b5e62"), "Come on, girls! Hurry up!", new Guid("19277692-d769-467f-9ecb-295ccb56dcbb") }
                });

            migrationBuilder.InsertData(
                table: "LineSequences",
                columns: new[] { "LineId", "SequenceNumber" },
                values: new object[,]
                {
                    { new Guid("49aad5e6-107f-4512-a58a-97bb29c08bf1"), 1 },
                    { new Guid("86d2f2ca-8d7f-4ba6-a0f5-5ed06dbebb86"), 2 },
                    { new Guid("5c3a2fd8-00cf-4799-99fb-ad65e579896e"), 3 },
                    { new Guid("40fbf41c-8919-4c65-962d-9287dc691f4d"), 4 },
                    { new Guid("8a786f26-8c2d-4aff-b5a7-659c7741ef5d"), 5 },
                    { new Guid("a8a3a9c5-b483-4948-80d6-9ece2dfaccaa"), 6 },
                    { new Guid("7589de9f-6561-428e-8bbe-b80f08294146"), 7 },
                    { new Guid("fbc109e8-4bbd-45f7-ad93-858a57445b4e"), 8 },
                    { new Guid("76f7f7b6-cadd-44c3-a05b-200459308560"), 9 },
                    { new Guid("b47d2b97-a606-44bf-9606-2fc11b3777cd"), 10 },
                    { new Guid("8b6a5eb8-3911-4a5f-9222-78efb082d0c0"), 11 },
                    { new Guid("55f68e90-3c51-4064-8227-5f0eafee12ed"), 12 }
                });
        }
    }
}
