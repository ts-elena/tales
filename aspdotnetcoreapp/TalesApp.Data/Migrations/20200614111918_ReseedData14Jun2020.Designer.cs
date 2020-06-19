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
    [Migration("20200614111918_ReseedData14Jun2020")]
    partial class ReseedData14Jun2020
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
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("CharacterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(254)")
                        .HasMaxLength(254);

                    b.HasKey("CharacterId");

                    b.ToTable("Character");

                    b.HasData(
                        new
                        {
                            CharacterId = new Guid("d567769b-c7d2-4122-b391-8f3a8a973420"),
                            CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/FannyHatter.jpg",
                            CharacterName = "Fanny"
                        },
                        new
                        {
                            CharacterId = new Guid("da48caf4-40d3-4ca2-8580-007274df62c2"),
                            CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/Sophie.jfif",
                            CharacterName = "Sophie"
                        },
                        new
                        {
                            CharacterId = new Guid("fbf09b11-825a-4fce-b692-d9b2b63b1459"),
                            CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister1.jfif",
                            CharacterName = "Sophie's sister"
                        },
                        new
                        {
                            CharacterId = new Guid("6d3861e7-2a7f-4944-ad88-38750da82e54"),
                            CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister2.jfif",
                            CharacterName = "Sophie's sister"
                        },
                        new
                        {
                            CharacterId = new Guid("767a0aee-08e5-42db-b6c1-1832946cee22"),
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

                    b.Property<Guid?>("LineId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LineStoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("WordAddedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.HasKey("DictionaryWordId");

                    b.HasIndex("LineId1", "LineStoryId");

                    b.ToTable("DictionaryWord");
                });

            modelBuilder.Entity("TalesApp.Domain.Line", b =>
                {
                    b.Property<Guid>("LineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CharacterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LineContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LineId", "StoryId");

                    b.HasIndex("CharacterId");

                    b.HasIndex("StoryId");

                    b.ToTable("Line");

                    b.HasData(
                        new
                        {
                            LineId = new Guid("9e047e88-74aa-4413-aca3-441fbc75897f"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            CharacterId = new Guid("d567769b-c7d2-4122-b391-8f3a8a973420"),
                            LineContent = "Sophie, we have just closed the shop. You have done enough work, why won't you come out with us this time?"
                        },
                        new
                        {
                            LineId = new Guid("710fa512-a657-40b6-804a-5f02b40dbf95"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            CharacterId = new Guid("da48caf4-40d3-4ca2-8580-007274df62c2"),
                            LineContent = "No, I would better finish this. Go have some fun."
                        },
                        new
                        {
                            LineId = new Guid("410c1200-05f8-47a2-93c7-3581c70c5565"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            CharacterId = new Guid("fbf09b11-825a-4fce-b692-d9b2b63b1459"),
                            LineContent = "Look, it is Howl's castle!"
                        },
                        new
                        {
                            LineId = new Guid("041c15f0-b252-438e-a817-4597b0453143"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            CharacterId = new Guid("6d3861e7-2a7f-4944-ad88-38750da82e54"),
                            LineContent = "Never seen it so close before!"
                        },
                        new
                        {
                            LineId = new Guid("9877e925-4cef-4a8f-9698-ca03ff7b3846"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            CharacterId = new Guid("fbf09b11-825a-4fce-b692-d9b2b63b1459"),
                            LineContent = "Oh, my... I wonder if Howl is in town."
                        },
                        new
                        {
                            LineId = new Guid("19508bab-808d-499a-928f-30c45f17400d"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            CharacterId = new Guid("767a0aee-08e5-42db-b6c1-1832946cee22"),
                            LineContent = "Oh, it is gone!"
                        },
                        new
                        {
                            LineId = new Guid("6c4a3248-0805-41ab-9384-792f9af1bad8"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            CharacterId = new Guid("fbf09b11-825a-4fce-b692-d9b2b63b1459"),
                            LineContent = "No, he is just hiding in the fog from all of those planes."
                        },
                        new
                        {
                            LineId = new Guid("792355db-a32b-436d-85b9-c326ac01de99"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            CharacterId = new Guid("6d3861e7-2a7f-4944-ad88-38750da82e54"),
                            LineContent = "Remember Martha, from South Heaven? They say Howl tore her heart out."
                        },
                        new
                        {
                            LineId = new Guid("88fd9c32-12a3-4b7a-9ad9-7484ffc1870c"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            CharacterId = new Guid("767a0aee-08e5-42db-b6c1-1832946cee22"),
                            LineContent = "Remember Martha, from South Heaven? They say Howl tore her heart out."
                        },
                        new
                        {
                            LineId = new Guid("17021557-144b-4721-b707-713c2d7e9995"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            CharacterId = new Guid("6d3861e7-2a7f-4944-ad88-38750da82e54"),
                            LineContent = "Now I am scared to go out!"
                        },
                        new
                        {
                            LineId = new Guid("f38c481a-5dc3-4669-afe9-a914419bc827"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            CharacterId = new Guid("fbf09b11-825a-4fce-b692-d9b2b63b1459"),
                            LineContent = "Don't worry, he only prays on pretty girls!"
                        },
                        new
                        {
                            LineId = new Guid("b8c8b788-531f-4706-8961-092abec40b80"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            CharacterId = new Guid("d567769b-c7d2-4122-b391-8f3a8a973420"),
                            LineContent = "Come on, girls! Hurry up!"
                        });
                });

            modelBuilder.Entity("TalesApp.Domain.LineNumber", b =>
                {
                    b.Property<Guid>("LineId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("LineId", "StoryId");

                    b.ToTable("LineNumber");

                    b.HasData(
                        new
                        {
                            LineId = new Guid("9e047e88-74aa-4413-aca3-441fbc75897f"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            Number = 1
                        },
                        new
                        {
                            LineId = new Guid("710fa512-a657-40b6-804a-5f02b40dbf95"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            Number = 2
                        },
                        new
                        {
                            LineId = new Guid("410c1200-05f8-47a2-93c7-3581c70c5565"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            Number = 3
                        },
                        new
                        {
                            LineId = new Guid("041c15f0-b252-438e-a817-4597b0453143"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            Number = 4
                        },
                        new
                        {
                            LineId = new Guid("9877e925-4cef-4a8f-9698-ca03ff7b3846"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            Number = 5
                        },
                        new
                        {
                            LineId = new Guid("19508bab-808d-499a-928f-30c45f17400d"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            Number = 6
                        },
                        new
                        {
                            LineId = new Guid("6c4a3248-0805-41ab-9384-792f9af1bad8"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            Number = 7
                        },
                        new
                        {
                            LineId = new Guid("792355db-a32b-436d-85b9-c326ac01de99"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            Number = 8
                        },
                        new
                        {
                            LineId = new Guid("88fd9c32-12a3-4b7a-9ad9-7484ffc1870c"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            Number = 9
                        },
                        new
                        {
                            LineId = new Guid("17021557-144b-4721-b707-713c2d7e9995"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            Number = 10
                        },
                        new
                        {
                            LineId = new Guid("f38c481a-5dc3-4669-afe9-a914419bc827"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            Number = 11
                        },
                        new
                        {
                            LineId = new Guid("b8c8b788-531f-4706-8961-092abec40b80"),
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            Number = 12
                        });
                });

            modelBuilder.Entity("TalesApp.Domain.Story", b =>
                {
                    b.Property<Guid>("StoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

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
                            StoryId = new Guid("bc0e12c2-3a37-4379-ab08-26698eb2da56"),
                            IsActive = false,
                            StoryCoverImage = "/images/StoriesData/MovingCastleOpeningStory/HowlsMovingCastleCover.jfif",
                            StoryName = "Opening Story of Howl's Moving Castle",
                            StorySetId = new Guid("224f7410-05e1-465d-b1e7-dac3e7606caa")
                        });
                });

            modelBuilder.Entity("TalesApp.Domain.StorySet", b =>
                {
                    b.Property<Guid>("StorySetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StorySetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StorySetId");

                    b.ToTable("StorySet");

                    b.HasData(
                        new
                        {
                            StorySetId = new Guid("224f7410-05e1-465d-b1e7-dac3e7606caa"),
                            StorySetName = "Set One"
                        });
                });

            modelBuilder.Entity("TalesApp.Domain.StorySetNumber", b =>
                {
                    b.Property<Guid>("StorySetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SetNumber")
                        .HasColumnType("int");

                    b.HasKey("StorySetId");

                    b.ToTable("StorySetNumber");

                    b.HasData(
                        new
                        {
                            StorySetId = new Guid("224f7410-05e1-465d-b1e7-dac3e7606caa"),
                            SetNumber = 1
                        });
                });

            modelBuilder.Entity("TalesApp.Domain.DictionaryWord", b =>
                {
                    b.HasOne("TalesApp.Domain.Line", "Line")
                        .WithMany("DictionaryWords")
                        .HasForeignKey("LineId1", "LineStoryId");
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
                        .HasForeignKey("TalesApp.Domain.LineNumber", "LineId", "StoryId")
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
