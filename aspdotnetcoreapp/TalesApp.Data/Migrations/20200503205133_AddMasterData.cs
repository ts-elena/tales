using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TalesApp.Data.Migrations
{
    public partial class AddMasterData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "CharacterAvatar", "CharacterName" },
                values: new object[,]
                {
                    { new Guid("6282e937-1c9c-4c0c-bdd8-4f38edd7d1c1"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/FannyHatter.jpg", "Fanny" },
                    { new Guid("695dc826-8a58-4639-948f-0b11bdff91aa"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/Sophie.jfif", "Sophie" },
                    { new Guid("6629a74e-a5e5-43e3-9a30-d42a3821f853"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister1.jfif", "Sophie's sister" },
                    { new Guid("2228dd3b-287c-48cb-b236-e4bcee5b5dd9"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister2.jfif", "Sophie's sister" },
                    { new Guid("0908d87c-b5c4-4c3a-8fc7-5ff3f54a0213"), "/images/StoriesData/MovingCastleOpeningStory/Avatars/LettieHatter.png", "Sophie's sister" }
                });

            migrationBuilder.InsertData(
                table: "StorySets",
                columns: new[] { "StorySetId", "StorySetName" },
                values: new object[] { new Guid("ddb32c39-bc4b-47ad-a932-ced444044dc6"), "Set One" });

            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "StoryId", "StoryCoverImage", "StoryName", "StorySetId" },
                values: new object[] { new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1"), "/images/StoriesData/MovingCastleOpeningStory/HowlsMovingCastleCover.jfif", "Opening Story of Howl's Moving Castle", new Guid("ddb32c39-bc4b-47ad-a932-ced444044dc6") });

            migrationBuilder.InsertData(
                table: "StorySetsSequences",
                columns: new[] { "StorySetId", "SetNumber" },
                values: new object[] { new Guid("ddb32c39-bc4b-47ad-a932-ced444044dc6"), 1 });

            migrationBuilder.InsertData(
                table: "Lines",
                columns: new[] { "LineId", "CharacterId", "LineContent", "StoryId" },
                values: new object[,]
                {
                    { new Guid("1b33fdf4-98d9-41c2-8919-a9c029dfe338"), new Guid("6282e937-1c9c-4c0c-bdd8-4f38edd7d1c1"), "Sophie, we have just closed the shop. You have done enough work, why won't you come out with us this time?", new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1") },
                    { new Guid("50cb0b90-209a-4048-8417-51367ea12c1d"), new Guid("695dc826-8a58-4639-948f-0b11bdff91aa"), "No, I would better finish this. Go have some fun.", new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1") },
                    { new Guid("4c3f51ac-176d-4c67-b320-4e4e9b26af65"), new Guid("6629a74e-a5e5-43e3-9a30-d42a3821f853"), "Look, it is Howl's castle!", new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1") },
                    { new Guid("c9922d61-2875-437e-ad08-c52b2b8bae89"), new Guid("2228dd3b-287c-48cb-b236-e4bcee5b5dd9"), "Never seen it so close before!", new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1") },
                    { new Guid("a176d5df-19ea-4c6d-8397-df8c143dc256"), new Guid("6629a74e-a5e5-43e3-9a30-d42a3821f853"), "Oh, my... I wonder if Howl is in town.", new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1") },
                    { new Guid("82160a4f-846a-45cc-9a19-dfd52a1f6b1f"), new Guid("0908d87c-b5c4-4c3a-8fc7-5ff3f54a0213"), "Oh, it is gone!", new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1") },
                    { new Guid("6b0588a4-ab6b-42a7-abfc-978e62f30435"), new Guid("6629a74e-a5e5-43e3-9a30-d42a3821f853"), "No, he is just hiding in the fog from all of those planes.", new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1") },
                    { new Guid("d0bb3d21-24fe-400f-8e3f-4adaa599f826"), new Guid("2228dd3b-287c-48cb-b236-e4bcee5b5dd9"), "Remember Martha, from South Heaven? They say Howl tore her heart out.", new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1") },
                    { new Guid("d8afac43-1ac8-4958-b3a1-a421e57f2dad"), new Guid("0908d87c-b5c4-4c3a-8fc7-5ff3f54a0213"), "Remember Martha, from South Heaven? They say Howl tore her heart out.", new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1") },
                    { new Guid("257a8f1c-7858-41d4-b7a1-6f55e469d2c8"), new Guid("2228dd3b-287c-48cb-b236-e4bcee5b5dd9"), "Now I am scared to go out!", new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1") },
                    { new Guid("9adb5c5c-76d4-47f4-9900-34c9776d88f8"), new Guid("6629a74e-a5e5-43e3-9a30-d42a3821f853"), "Don't worry, he only prays on pretty girls!", new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1") },
                    { new Guid("d5ed2319-6d55-47fb-b93f-3ba745c25fed"), new Guid("6282e937-1c9c-4c0c-bdd8-4f38edd7d1c1"), "Come on, girls! Hurry up!", new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1") }
                });

            migrationBuilder.InsertData(
                table: "LineSequences",
                columns: new[] { "LineId", "SequenceNumber" },
                values: new object[,]
                {
                    { new Guid("1b33fdf4-98d9-41c2-8919-a9c029dfe338"), 1 },
                    { new Guid("50cb0b90-209a-4048-8417-51367ea12c1d"), 2 },
                    { new Guid("4c3f51ac-176d-4c67-b320-4e4e9b26af65"), 3 },
                    { new Guid("c9922d61-2875-437e-ad08-c52b2b8bae89"), 4 },
                    { new Guid("a176d5df-19ea-4c6d-8397-df8c143dc256"), 5 },
                    { new Guid("82160a4f-846a-45cc-9a19-dfd52a1f6b1f"), 6 },
                    { new Guid("6b0588a4-ab6b-42a7-abfc-978e62f30435"), 7 },
                    { new Guid("d0bb3d21-24fe-400f-8e3f-4adaa599f826"), 8 },
                    { new Guid("d8afac43-1ac8-4958-b3a1-a421e57f2dad"), 9 },
                    { new Guid("257a8f1c-7858-41d4-b7a1-6f55e469d2c8"), 10 },
                    { new Guid("9adb5c5c-76d4-47f4-9900-34c9776d88f8"), 11 },
                    { new Guid("d5ed2319-6d55-47fb-b93f-3ba745c25fed"), 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("1b33fdf4-98d9-41c2-8919-a9c029dfe338"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("257a8f1c-7858-41d4-b7a1-6f55e469d2c8"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("4c3f51ac-176d-4c67-b320-4e4e9b26af65"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("50cb0b90-209a-4048-8417-51367ea12c1d"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("6b0588a4-ab6b-42a7-abfc-978e62f30435"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("82160a4f-846a-45cc-9a19-dfd52a1f6b1f"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("9adb5c5c-76d4-47f4-9900-34c9776d88f8"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("a176d5df-19ea-4c6d-8397-df8c143dc256"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("c9922d61-2875-437e-ad08-c52b2b8bae89"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("d0bb3d21-24fe-400f-8e3f-4adaa599f826"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("d5ed2319-6d55-47fb-b93f-3ba745c25fed"));

            migrationBuilder.DeleteData(
                table: "LineSequences",
                keyColumn: "LineId",
                keyValue: new Guid("d8afac43-1ac8-4958-b3a1-a421e57f2dad"));

            migrationBuilder.DeleteData(
                table: "StorySetsSequences",
                keyColumn: "StorySetId",
                keyValue: new Guid("ddb32c39-bc4b-47ad-a932-ced444044dc6"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("1b33fdf4-98d9-41c2-8919-a9c029dfe338"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("257a8f1c-7858-41d4-b7a1-6f55e469d2c8"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("4c3f51ac-176d-4c67-b320-4e4e9b26af65"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("50cb0b90-209a-4048-8417-51367ea12c1d"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("6b0588a4-ab6b-42a7-abfc-978e62f30435"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("82160a4f-846a-45cc-9a19-dfd52a1f6b1f"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("9adb5c5c-76d4-47f4-9900-34c9776d88f8"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("a176d5df-19ea-4c6d-8397-df8c143dc256"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("c9922d61-2875-437e-ad08-c52b2b8bae89"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("d0bb3d21-24fe-400f-8e3f-4adaa599f826"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("d5ed2319-6d55-47fb-b93f-3ba745c25fed"));

            migrationBuilder.DeleteData(
                table: "Lines",
                keyColumn: "LineId",
                keyValue: new Guid("d8afac43-1ac8-4958-b3a1-a421e57f2dad"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("0908d87c-b5c4-4c3a-8fc7-5ff3f54a0213"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("2228dd3b-287c-48cb-b236-e4bcee5b5dd9"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("6282e937-1c9c-4c0c-bdd8-4f38edd7d1c1"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("6629a74e-a5e5-43e3-9a30-d42a3821f853"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("695dc826-8a58-4639-948f-0b11bdff91aa"));

            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "StoryId",
                keyValue: new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1"));

            migrationBuilder.DeleteData(
                table: "StorySets",
                keyColumn: "StorySetId",
                keyValue: new Guid("ddb32c39-bc4b-47ad-a932-ced444044dc6"));
        }
    }
}
