﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TalesApp.Data;

namespace TalesApp.Data.Migrations
{
    [DbContext(typeof(TalesContext))]
    [Migration("20200523183149_AddNewData")]
    partial class AddNewData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TalesApp.Domain.Character", b =>
                {
                    b.Property<Guid>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CharacterAvatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CharacterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CharacterId");

                    b.ToTable("Character");

                    b.HasData(
                        new
                        {
                            CharacterId = new Guid("268d8089-532f-428e-961a-e97ae90628be"),
                            CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/FannyHatter.jpg",
                            CharacterName = "Fanny"
                        },
                        new
                        {
                            CharacterId = new Guid("1336847e-f6d3-4024-a3b9-3d0c9fa37986"),
                            CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/Sophie.jfif",
                            CharacterName = "Sophie"
                        },
                        new
                        {
                            CharacterId = new Guid("32654180-4b4c-4df1-ab87-4ebc555d8354"),
                            CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister1.jfif",
                            CharacterName = "Sophie's sister"
                        },
                        new
                        {
                            CharacterId = new Guid("52d7d788-7409-4ab2-a12b-39f73392eac7"),
                            CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister2.jfif",
                            CharacterName = "Sophie's sister"
                        },
                        new
                        {
                            CharacterId = new Guid("5b805d31-0e44-46b2-99a9-166d359665d0"),
                            CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/LettieHatter.png",
                            CharacterName = "Sophie's sister"
                        });
                });

            modelBuilder.Entity("TalesApp.Domain.DictionaryWord", b =>
                {
                    b.Property<Guid>("DictionaryWordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DictionaryWordText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LineId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("WordAddedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.HasKey("DictionaryWordId");

                    b.HasIndex("LineId");

                    b.ToTable("DictionaryWord");
                });

            modelBuilder.Entity("TalesApp.Domain.Line", b =>
                {
                    b.Property<Guid>("LineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CharacterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LineContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LineId");

                    b.HasIndex("CharacterId");

                    b.HasIndex("StoryId");

                    b.ToTable("Line");

                    b.HasData(
                        new
                        {
                            LineId = new Guid("4a6b931b-55db-4e35-a0e5-b0f7f5b63ef0"),
                            CharacterId = new Guid("268d8089-532f-428e-961a-e97ae90628be"),
                            LineContent = "Sophie, we have just closed the shop. You have done enough work, why won't you come out with us this time?",
                            StoryId = new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc")
                        },
                        new
                        {
                            LineId = new Guid("ea7b7c6c-db82-4369-946b-7b7a5397148f"),
                            CharacterId = new Guid("1336847e-f6d3-4024-a3b9-3d0c9fa37986"),
                            LineContent = "No, I would better finish this. Go have some fun.",
                            StoryId = new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc")
                        },
                        new
                        {
                            LineId = new Guid("fa2c8997-fe27-4431-beeb-588d4997b02c"),
                            CharacterId = new Guid("32654180-4b4c-4df1-ab87-4ebc555d8354"),
                            LineContent = "Look, it is Howl's castle!",
                            StoryId = new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc")
                        },
                        new
                        {
                            LineId = new Guid("6dcd01b2-e95d-40ba-987d-b805f0a16ef5"),
                            CharacterId = new Guid("52d7d788-7409-4ab2-a12b-39f73392eac7"),
                            LineContent = "Never seen it so close before!",
                            StoryId = new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc")
                        },
                        new
                        {
                            LineId = new Guid("fb08e7a1-c096-4c0b-a61a-e67353182c98"),
                            CharacterId = new Guid("32654180-4b4c-4df1-ab87-4ebc555d8354"),
                            LineContent = "Oh, my... I wonder if Howl is in town.",
                            StoryId = new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc")
                        },
                        new
                        {
                            LineId = new Guid("364ff5c0-c9c0-40f7-b0f2-9d1b8badd912"),
                            CharacterId = new Guid("5b805d31-0e44-46b2-99a9-166d359665d0"),
                            LineContent = "Oh, it is gone!",
                            StoryId = new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc")
                        },
                        new
                        {
                            LineId = new Guid("8e3577d3-d2ba-4230-8a8a-f43b07175b03"),
                            CharacterId = new Guid("32654180-4b4c-4df1-ab87-4ebc555d8354"),
                            LineContent = "No, he is just hiding in the fog from all of those planes.",
                            StoryId = new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc")
                        },
                        new
                        {
                            LineId = new Guid("d3676082-b2a5-44a6-be5b-ada29c5f3dd7"),
                            CharacterId = new Guid("52d7d788-7409-4ab2-a12b-39f73392eac7"),
                            LineContent = "Remember Martha, from South Heaven? They say Howl tore her heart out.",
                            StoryId = new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc")
                        },
                        new
                        {
                            LineId = new Guid("e801a81a-1cd0-48a6-a2f5-848ef9e88ba7"),
                            CharacterId = new Guid("5b805d31-0e44-46b2-99a9-166d359665d0"),
                            LineContent = "Remember Martha, from South Heaven? They say Howl tore her heart out.",
                            StoryId = new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc")
                        },
                        new
                        {
                            LineId = new Guid("be091ae8-a3a5-4b78-a2cc-37c6cba1a6eb"),
                            CharacterId = new Guid("52d7d788-7409-4ab2-a12b-39f73392eac7"),
                            LineContent = "Now I am scared to go out!",
                            StoryId = new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc")
                        },
                        new
                        {
                            LineId = new Guid("b391acb9-0dac-4e8f-9c58-5e65900fcfd9"),
                            CharacterId = new Guid("32654180-4b4c-4df1-ab87-4ebc555d8354"),
                            LineContent = "Don't worry, he only prays on pretty girls!",
                            StoryId = new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc")
                        },
                        new
                        {
                            LineId = new Guid("030a4e40-24b5-4555-8d12-3d66b52669ab"),
                            CharacterId = new Guid("268d8089-532f-428e-961a-e97ae90628be"),
                            LineContent = "Come on, girls! Hurry up!",
                            StoryId = new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc")
                        });
                });

            modelBuilder.Entity("TalesApp.Domain.LineNumber", b =>
                {
                    b.Property<Guid>("LineId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("LineId");

                    b.ToTable("LineNumber");

                    b.HasData(
                        new
                        {
                            LineId = new Guid("4a6b931b-55db-4e35-a0e5-b0f7f5b63ef0"),
                            Number = 1
                        },
                        new
                        {
                            LineId = new Guid("ea7b7c6c-db82-4369-946b-7b7a5397148f"),
                            Number = 2
                        },
                        new
                        {
                            LineId = new Guid("fa2c8997-fe27-4431-beeb-588d4997b02c"),
                            Number = 3
                        },
                        new
                        {
                            LineId = new Guid("6dcd01b2-e95d-40ba-987d-b805f0a16ef5"),
                            Number = 4
                        },
                        new
                        {
                            LineId = new Guid("fb08e7a1-c096-4c0b-a61a-e67353182c98"),
                            Number = 5
                        },
                        new
                        {
                            LineId = new Guid("364ff5c0-c9c0-40f7-b0f2-9d1b8badd912"),
                            Number = 6
                        },
                        new
                        {
                            LineId = new Guid("8e3577d3-d2ba-4230-8a8a-f43b07175b03"),
                            Number = 7
                        },
                        new
                        {
                            LineId = new Guid("d3676082-b2a5-44a6-be5b-ada29c5f3dd7"),
                            Number = 8
                        },
                        new
                        {
                            LineId = new Guid("e801a81a-1cd0-48a6-a2f5-848ef9e88ba7"),
                            Number = 9
                        },
                        new
                        {
                            LineId = new Guid("be091ae8-a3a5-4b78-a2cc-37c6cba1a6eb"),
                            Number = 10
                        },
                        new
                        {
                            LineId = new Guid("b391acb9-0dac-4e8f-9c58-5e65900fcfd9"),
                            Number = 11
                        },
                        new
                        {
                            LineId = new Guid("030a4e40-24b5-4555-8d12-3d66b52669ab"),
                            Number = 12
                        });
                });

            modelBuilder.Entity("TalesApp.Domain.Story", b =>
                {
                    b.Property<Guid>("StoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StoryCoverImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StorySetId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StoryId");

                    b.HasIndex("StorySetId");

                    b.ToTable("Story");

                    b.HasData(
                        new
                        {
                            StoryId = new Guid("ad30fe94-5f80-496f-9afe-74c18ce715fc"),
                            StoryCoverImage = "/images/StoriesData/MovingCastleOpeningStory/HowlsMovingCastleCover.jfif",
                            StoryName = "Opening Story of Howl's Moving Castle",
                            StorySetId = new Guid("11325591-1e14-48a2-bab7-d0d1232114e5")
                        });
                });

            modelBuilder.Entity("TalesApp.Domain.StorySet", b =>
                {
                    b.Property<Guid>("StorySetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StorySetName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StorySetId");

                    b.ToTable("StorySet");

                    b.HasData(
                        new
                        {
                            StorySetId = new Guid("11325591-1e14-48a2-bab7-d0d1232114e5"),
                            StorySetName = "Set One"
                        });
                });

            modelBuilder.Entity("TalesApp.Domain.StorySetNumber", b =>
                {
                    b.Property<Guid>("StorySetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SetNumber")
                        .HasColumnType("int");

                    b.HasKey("StorySetId");

                    b.ToTable("StorySetNumber");

                    b.HasData(
                        new
                        {
                            StorySetId = new Guid("11325591-1e14-48a2-bab7-d0d1232114e5"),
                            SetNumber = 1
                        });
                });

            modelBuilder.Entity("TalesApp.Domain.DictionaryWord", b =>
                {
                    b.HasOne("TalesApp.Domain.Line", "Line")
                        .WithMany("DictionaryWords")
                        .HasForeignKey("LineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TalesApp.Domain.Line", b =>
                {
                    b.HasOne("TalesApp.Domain.Character", "Character")
                        .WithMany("Lines")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TalesApp.Domain.Story", "Story")
                        .WithMany("Lines")
                        .HasForeignKey("StoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TalesApp.Domain.LineNumber", b =>
                {
                    b.HasOne("TalesApp.Domain.Line", "Line")
                        .WithOne("LineNumber")
                        .HasForeignKey("TalesApp.Domain.LineNumber", "LineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TalesApp.Domain.Story", b =>
                {
                    b.HasOne("TalesApp.Domain.StorySet", "StorySet")
                        .WithMany("Stories")
                        .HasForeignKey("StorySetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TalesApp.Domain.StorySetNumber", b =>
                {
                    b.HasOne("TalesApp.Domain.StorySet", "StorySet")
                        .WithOne("StorySetNumber")
                        .HasForeignKey("TalesApp.Domain.StorySetNumber", "StorySetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
