using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TalesApp.Data.Migrations
{
    public partial class ReseedData14Jun2020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("0adffb34-de4a-4dce-ba4e-f8f450ff2507"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("0d8cb57c-993d-4829-ace6-13c7927d54e7"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("10e74286-03c9-442a-a956-762904804b5d"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("3465982c-6d40-4fe2-9824-768bb087fe9f"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("56ad5649-60f9-4958-b802-22d32ed35bea"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("67abc004-265c-464f-bed3-f4de2764e446"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("6926e033-f24d-4dc9-b465-a8577bddb8d2"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("6f4486fd-8261-46e0-bb0b-010a7924dcfe"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("7699725c-00be-4db0-832b-bec10d609f39"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("7ec57893-2219-4015-811e-f3c520ba125c"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("8e859168-021d-4eb6-9b13-1bf8169dda1e"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("f6d9a365-ccc2-47e2-94eb-89c529548853"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "StorySetNumber",
                keyColumn: "StorySetId",
                keyValue: new Guid("21e6de0a-6d44-4cd8-92ed-ab50d7d2730b"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("0adffb34-de4a-4dce-ba4e-f8f450ff2507"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("0d8cb57c-993d-4829-ace6-13c7927d54e7"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("10e74286-03c9-442a-a956-762904804b5d"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("3465982c-6d40-4fe2-9824-768bb087fe9f"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("56ad5649-60f9-4958-b802-22d32ed35bea"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("67abc004-265c-464f-bed3-f4de2764e446"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("6926e033-f24d-4dc9-b465-a8577bddb8d2"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("6f4486fd-8261-46e0-bb0b-010a7924dcfe"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("7699725c-00be-4db0-832b-bec10d609f39"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("7ec57893-2219-4015-811e-f3c520ba125c"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("8e859168-021d-4eb6-9b13-1bf8169dda1e"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("f6d9a365-ccc2-47e2-94eb-89c529548853"), new Guid("cf72a438-8242-4211-a974-6415571a42c8") });

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("136b056d-e165-4b06-993d-a52830470b7a"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("41cf6f15-7982-468f-b4b4-67ba9c178953"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("451f4b8f-8314-4698-9094-dae4f425b975"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("8e36a954-aa7e-4047-85c1-94e5b40f4783"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("a099544c-150e-4558-b9fd-00df9f391384"));

            migrationBuilder.DeleteData(
                table: "Story",
                keyColumn: "StoryId",
                keyValue: new Guid("cf72a438-8242-4211-a974-6415571a42c8"));

            migrationBuilder.DeleteData(
                table: "StorySet",
                keyColumn: "StorySetId",
                keyValue: new Guid("21e6de0a-6d44-4cd8-92ed-ab50d7d2730b"));

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "CharacterAvatar", "CharacterName" },
                values: new object[,]
                {
                    { new Guid("d567769b-c7d2-4122-b391-8f3a8a973420"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/FannyHatter.jpg", "Fanny" },
                    { new Guid("da48caf4-40d3-4ca2-8580-007274df62c2"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/Sophie.jfif", "Sophie" },
                    { new Guid("fbf09b11-825a-4fce-b692-d9b2b63b1459"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister1.jfif", "Sophie's sister" },
                    { new Guid("6d3861e7-2a7f-4944-ad88-38750da82e54"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister2.jfif", "Sophie's sister" },
                    { new Guid("767a0aee-08e5-42db-b6c1-1832946cee22"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/LettieHatter.png", "Sophie's sister" }
                });

            migrationBuilder.InsertData(
                table: "StorySet",
                columns: new[] { "StorySetId", "StorySetName" },
                values: new object[] { new Guid("224f7410-05e1-465d-b1e7-dac3e7606caa"), "Set One" });

            migrationBuilder.InsertData(
                table: "Story",
                columns: new[] { "StoryId", "IsActive", "StoryCoverImage", "StoryName", "StorySetId" },
                values: new object[] { new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), false, "/images/StoriesData/MovingCastleOpeningStory/HowlsMovingCastleCover.jfif", "Opening Story of Howl's Moving Castle", new Guid("224f7410-05e1-465d-b1e7-dac3e7606caa") });

            migrationBuilder.InsertData(
                table: "StorySetNumber",
                columns: new[] { "StorySetId", "SetNumber" },
                values: new object[] { new Guid("224f7410-05e1-465d-b1e7-dac3e7606caa"), 1 });

            migrationBuilder.InsertData(
                table: "Line",
                columns: new[] { "LineId", "StoryId", "CharacterId", "LineContent" },
                values: new object[,]
                {
                    { new Guid("9e047e88-74aa-4413-aca3-441fbc75897f"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), new Guid("d567769b-c7d2-4122-b391-8f3a8a973420"), "Sophie, we have just closed the shop. You have done enough work, why won't you come out with us this time?" },
                    { new Guid("710fa512-a657-40b6-804a-5f02b40dbf95"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), new Guid("da48caf4-40d3-4ca2-8580-007274df62c2"), "No, I would better finish this. Go have some fun." },
                    { new Guid("410c1200-05f8-47a2-93c7-3581c70c5565"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), new Guid("fbf09b11-825a-4fce-b692-d9b2b63b1459"), "Look, it is Howl's castle!" },
                    { new Guid("041c15f0-b252-438e-a817-4597b0453143"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), new Guid("6d3861e7-2a7f-4944-ad88-38750da82e54"), "Never seen it so close before!" },
                    { new Guid("9877e925-4cef-4a8f-9698-ca03ff7b3846"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), new Guid("fbf09b11-825a-4fce-b692-d9b2b63b1459"), "Oh, my... I wonder if Howl is in town." },
                    { new Guid("19508bab-808d-499a-928f-30c45f17400d"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), new Guid("767a0aee-08e5-42db-b6c1-1832946cee22"), "Oh, it is gone!" },
                    { new Guid("6c4a3248-0805-41ab-9384-792f9af1bad8"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), new Guid("fbf09b11-825a-4fce-b692-d9b2b63b1459"), "No, he is just hiding in the fog from all of those planes." },
                    { new Guid("792355db-a32b-436d-85b9-c326ac01de99"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), new Guid("6d3861e7-2a7f-4944-ad88-38750da82e54"), "Remember Martha, from South Heaven? They say Howl tore her heart out." },
                    { new Guid("88fd9c32-12a3-4b7a-9ad9-7484ffc1870c"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), new Guid("767a0aee-08e5-42db-b6c1-1832946cee22"), "Remember Martha, from South Heaven? They say Howl tore her heart out." },
                    { new Guid("17021557-144b-4721-b707-713c2d7e9995"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), new Guid("6d3861e7-2a7f-4944-ad88-38750da82e54"), "Now I am scared to go out!" },
                    { new Guid("f38c481a-5dc3-4669-afe9-a914419bc827"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), new Guid("fbf09b11-825a-4fce-b692-d9b2b63b1459"), "Don't worry, he only prays on pretty girls!" },
                    { new Guid("b8c8b788-531f-4706-8961-092abec40b80"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), new Guid("d567769b-c7d2-4122-b391-8f3a8a973420"), "Come on, girls! Hurry up!" }
                });

            migrationBuilder.InsertData(
                table: "LineNumber",
                columns: new[] { "LineId", "StoryId", "Number" },
                values: new object[,]
                {
                    { new Guid("9e047e88-74aa-4413-aca3-441fbc75897f"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), 1 },
                    { new Guid("710fa512-a657-40b6-804a-5f02b40dbf95"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), 2 },
                    { new Guid("410c1200-05f8-47a2-93c7-3581c70c5565"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), 3 },
                    { new Guid("041c15f0-b252-438e-a817-4597b0453143"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), 4 },
                    { new Guid("9877e925-4cef-4a8f-9698-ca03ff7b3846"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), 5 },
                    { new Guid("19508bab-808d-499a-928f-30c45f17400d"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), 6 },
                    { new Guid("6c4a3248-0805-41ab-9384-792f9af1bad8"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), 7 },
                    { new Guid("792355db-a32b-436d-85b9-c326ac01de99"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), 8 },
                    { new Guid("88fd9c32-12a3-4b7a-9ad9-7484ffc1870c"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), 9 },
                    { new Guid("17021557-144b-4721-b707-713c2d7e9995"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), 10 },
                    { new Guid("f38c481a-5dc3-4669-afe9-a914419bc827"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), 11 },
                    { new Guid("b8c8b788-531f-4706-8961-092abec40b80"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"), 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("041c15f0-b252-438e-a817-4597b0453143"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("17021557-144b-4721-b707-713c2d7e9995"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("19508bab-808d-499a-928f-30c45f17400d"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("410c1200-05f8-47a2-93c7-3581c70c5565"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("6c4a3248-0805-41ab-9384-792f9af1bad8"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("710fa512-a657-40b6-804a-5f02b40dbf95"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("792355db-a32b-436d-85b9-c326ac01de99"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("88fd9c32-12a3-4b7a-9ad9-7484ffc1870c"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("9877e925-4cef-4a8f-9698-ca03ff7b3846"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("9e047e88-74aa-4413-aca3-441fbc75897f"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("b8c8b788-531f-4706-8961-092abec40b80"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "LineNumber",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("f38c481a-5dc3-4669-afe9-a914419bc827"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "StorySetNumber",
                keyColumn: "StorySetId",
                keyValue: new Guid("224f7410-05e1-465d-b1e7-dac3e7606caa"));

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("041c15f0-b252-438e-a817-4597b0453143"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("17021557-144b-4721-b707-713c2d7e9995"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("19508bab-808d-499a-928f-30c45f17400d"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("410c1200-05f8-47a2-93c7-3581c70c5565"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("6c4a3248-0805-41ab-9384-792f9af1bad8"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("710fa512-a657-40b6-804a-5f02b40dbf95"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("792355db-a32b-436d-85b9-c326ac01de99"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("88fd9c32-12a3-4b7a-9ad9-7484ffc1870c"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("9877e925-4cef-4a8f-9698-ca03ff7b3846"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("9e047e88-74aa-4413-aca3-441fbc75897f"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("b8c8b788-531f-4706-8961-092abec40b80"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "Line",
                keyColumns: new[] { "LineId", "StoryId" },
                keyValues: new object[] { new Guid("f38c481a-5dc3-4669-afe9-a914419bc827"), new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56") });

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("6d3861e7-2a7f-4944-ad88-38750da82e54"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("767a0aee-08e5-42db-b6c1-1832946cee22"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("d567769b-c7d2-4122-b391-8f3a8a973420"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("da48caf4-40d3-4ca2-8580-007274df62c2"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: new Guid("fbf09b11-825a-4fce-b692-d9b2b63b1459"));

            migrationBuilder.DeleteData(
                table: "Story",
                keyColumn: "StoryId",
                keyValue: new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"));

            migrationBuilder.DeleteData(
                table: "StorySet",
                keyColumn: "StorySetId",
                keyValue: new Guid("224f7410-05e1-465d-b1e7-dac3e7606caa"));

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
        }
    }
}
