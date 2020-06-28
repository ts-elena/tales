using Microsoft.EntityFrameworkCore;
using System;
using TalesApp.Domain;

namespace TalesApp.Data
{
    public static class ModelBuilderExtenstion
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Guid storySetKey = Guid.NewGuid();
            Guid storyKey = Guid.NewGuid();

            // CharacterIds 
            Guid sophieKey = Guid.NewGuid();
            Guid fannyKey = Guid.NewGuid();
            Guid girlInAShop1 = Guid.NewGuid();
            Guid girlInAShop2 = Guid.NewGuid();
            Guid girlInAShop3 = Guid.NewGuid();

            // Lines
            var line1Key = Guid.NewGuid();
            var line2key = Guid.NewGuid();
            var line3key = Guid.NewGuid();
            var line4key = Guid.NewGuid();
            var line5key = Guid.NewGuid();
            var line6key = Guid.NewGuid();
            var line7key = Guid.NewGuid();
            var line8key = Guid.NewGuid();
            var line9key = Guid.NewGuid();
            var line10key = Guid.NewGuid();
            var line11key = Guid.NewGuid();
            var line12key = Guid.NewGuid();

            modelBuilder.Entity<StorySet>().HasData(
                new StorySet
                {
                    StorySetId = storySetKey,
                    StorySetName = "Set One",
                }
            );

            modelBuilder.Entity<StorySetNumber>().HasData(
                new StorySetNumber
                {
                    StorySetId = storySetKey,
                    SetNumber = 1
                }
            );

            modelBuilder.Entity<Story>().HasData(
                new Story
                {
                    StoryId = storyKey,
                    StorySetId = storySetKey,
                    StoryName = "Opening Story of Howl's Moving Castle",
                    StoryCoverImage = "/images/StoriesData/MovingCastleOpeningStory/HowlsMovingCastleCover.jfif"
                }
            );

            // Characters
            modelBuilder.Entity<Character>().HasData(
                new Character
                {
                    CharacterId = fannyKey,
                    CharacterName = "Fanny",
                    CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/FannyHatter.jpg"
                }
            );

            modelBuilder.Entity<Character>().HasData(
                new Character
                {
                    CharacterId = sophieKey,
                    CharacterName = "Sophie",
                    CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/Sophie.jfif"
                }
            );

            modelBuilder.Entity<Character>().HasData(
                new Character
                {
                    CharacterId = girlInAShop1,
                    CharacterName = "Sophie's sister",
                    CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister1.jfif"
                }
            );

            modelBuilder.Entity<Character>().HasData(
                new Character
                {
                    CharacterId = girlInAShop2,
                    CharacterName = "Sophie's sister",
                    CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister2.jfif"
                }
            );

            modelBuilder.Entity<Character>().HasData(
                new Character
                {
                    CharacterId = girlInAShop3,
                    CharacterName = "Sophie's sister",
                    CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/LettieHatter.png"
                }
            );

            // Line 1

            modelBuilder.Entity<Line>().HasData(
                new Line
                {
                    StoryId = storyKey,
                    LineId = line1Key,
                    LineContent = "Sophie, we have just closed the shop. You have done enough work, why won't you come out with us this time?",
                    CharacterId = fannyKey

                }
            );

            modelBuilder.Entity<LineNumber>().HasData(
                new LineNumber
                {
                    LineId = line1Key,
                    StoryId = storyKey,
                    Number = 1,
                    IsLast = false
                }
            );

            // Line 2
            modelBuilder.Entity<Line>().HasData(
                new Line
                {
                    StoryId = storyKey,
                    LineId = line2key,
                    LineContent = "No, I would better finish this. Go have some fun.",
                    CharacterId = sophieKey
                }
            );

            modelBuilder.Entity<LineNumber>().HasData(
                new LineNumber
                {
                    LineId = line2key,
                    StoryId = storyKey,
                    Number = 2,
                    IsLast = false
                }
            );

            // Line 3

            modelBuilder.Entity<Line>().HasData(
                new Line
                {
                    StoryId = storyKey,
                    LineId = line3key,
                    LineContent = "Look, it is Howl's castle!",
                    CharacterId = girlInAShop1
                }
            );

            modelBuilder.Entity<LineNumber>().HasData(
                new LineNumber
                {
                    LineId = line3key,
                    StoryId = storyKey,
                    Number = 3,
                    IsLast = false
                }
            );

            // Line 4

            modelBuilder.Entity<Line>().HasData(
                new Line
                {
                    StoryId = storyKey,
                    LineId = line4key,
                    LineContent = "Never seen it so close before!",
                    CharacterId = girlInAShop2
                }
            );

            modelBuilder.Entity<LineNumber>().HasData(
                new LineNumber
                {
                    LineId = line4key,
                    StoryId = storyKey,
                    Number = 4,
                    IsLast = false
                }
            );

            // Line 5

            modelBuilder.Entity<Line>().HasData(
                new Line
                {
                    StoryId = storyKey,
                    LineId = line5key,
                    LineContent = "Oh, my... I wonder if Howl is in town.",
                    CharacterId = girlInAShop1
                }
            );

            modelBuilder.Entity<LineNumber>().HasData(
                new LineNumber
                {
                    LineId = line5key,
                    StoryId = storyKey,
                    Number = 5,
                    IsLast = false
                }
            );

            // Line 6

            modelBuilder.Entity<Line>().HasData(
                new Line
                {
                    StoryId = storyKey,
                    LineId = line6key,
                    LineContent = "Oh, it is gone!",
                    CharacterId = girlInAShop3
                }
            );

            modelBuilder.Entity<LineNumber>().HasData(
                new LineNumber
                {
                    LineId = line6key,
                    StoryId = storyKey,
                    Number = 6,
                    IsLast = false
                }
            );

            // Line 7

            modelBuilder.Entity<Line>().HasData(
                new Line
                {
                    StoryId = storyKey,
                    LineId = line7key,
                    LineContent = "No, he is just hiding in the fog from all of those planes.",
                    CharacterId = girlInAShop1
                }
            );

            modelBuilder.Entity<LineNumber>().HasData(
                new LineNumber
                {
                    LineId = line7key,
                    StoryId = storyKey,
                    Number = 7,
                    IsLast = false
                }
            );

            // Line 8

            modelBuilder.Entity<Line>().HasData(
                new Line
                {
                    StoryId = storyKey,
                    LineId = line8key,
                    LineContent = "Ah, now I see!",
                    CharacterId = girlInAShop2
                }
            );

            modelBuilder.Entity<LineNumber>().HasData(
                new LineNumber
                {
                    LineId = line8key,
                    StoryId = storyKey,
                    Number = 8,
                    IsLast = false
                }
            );

            // Line 9

            modelBuilder.Entity<Line>().HasData(
                new Line
                {
                    StoryId = storyKey,
                    LineId = line9key,
                    LineContent = "Remember Martha, from South Heaven? They say Howl tore her heart out.",
                    CharacterId = girlInAShop3
                }
            );

            modelBuilder.Entity<LineNumber>().HasData(
                new LineNumber
                {
                    LineId = line9key,
                    StoryId = storyKey,
                    Number = 9,
                    IsLast = false
                }
            );

            // Line 10

            modelBuilder.Entity<Line>().HasData(
                new Line
                {
                    StoryId = storyKey,
                    LineId = line10key,
                    LineContent = "Now I am scared to go out!",
                    CharacterId = girlInAShop2
                }
            );

            modelBuilder.Entity<LineNumber>().HasData(
                new LineNumber
                {
                    LineId = line10key,
                    StoryId = storyKey,
                    Number = 10,
                    IsLast = false
                }
            );

            // Line 11

            modelBuilder.Entity<Line>().HasData(
                new Line
                {
                    StoryId = storyKey,
                    LineId = line11key,
                    LineContent = "Don't worry, he only prays on pretty girls!",
                    CharacterId = girlInAShop1
                }
            );

            modelBuilder.Entity<LineNumber>().HasData(
                new LineNumber
                {
                    LineId = line11key,
                    StoryId = storyKey,
                    Number = 11,
                    IsLast = false
                }
            );

            // Line 12

            modelBuilder.Entity<Line>().HasData(
                new Line
                {
                    StoryId = storyKey,
                    LineId = line12key,
                    LineContent = "Come on, girls! Hurry up!",
                    CharacterId = fannyKey
                }
            );

            modelBuilder.Entity<LineNumber>().HasData(
                new LineNumber
                {
                    LineId = line12key,
                    StoryId = storyKey,
                    Number = 12,
                    IsLast = true
                }
            );
        }
    }
}
