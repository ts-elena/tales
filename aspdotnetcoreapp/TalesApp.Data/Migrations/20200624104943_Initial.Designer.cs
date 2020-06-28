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
    [Migration("20200624104943_Initial")]
    partial class Initial
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
                            CharacterId = new Guid("da6e1bd0-c970-43c1-8516-1e814807c9ca"),
                            CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/FannyHatter.jpg",
                            CharacterName = "Fanny"
                        },
                        new
                        {
                            CharacterId = new Guid("567b0bb4-1e3b-4007-bd8b-12327d5983a9"),
                            CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/Sophie.jfif",
                            CharacterName = "Sophie"
                        },
                        new
                        {
                            CharacterId = new Guid("de4b251f-e985-492b-abe3-0256e4ac3da5"),
                            CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister1.jfif",
                            CharacterName = "Sophie's sister"
                        },
                        new
                        {
                            CharacterId = new Guid("68526821-1a33-42a8-a01e-855867644119"),
                            CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister2.jfif",
                            CharacterName = "Sophie's sister"
                        },
                        new
                        {
                            CharacterId = new Guid("b85bf3d6-7014-43f0-8051-727c9745517d"),
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
                            LineId = new Guid("daa31b35-9859-4b4a-b053-b65a9ecd8d15"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            CharacterId = new Guid("da6e1bd0-c970-43c1-8516-1e814807c9ca"),
                            LineContent = "Sophie, we have just closed the shop. You have done enough work, why won't you come out with us this time?"
                        },
                        new
                        {
                            LineId = new Guid("564d4795-ebca-4e8a-8bb5-2089c1f0e6ea"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            CharacterId = new Guid("567b0bb4-1e3b-4007-bd8b-12327d5983a9"),
                            LineContent = "No, I would better finish this. Go have some fun."
                        },
                        new
                        {
                            LineId = new Guid("54f7cacf-b2aa-4778-92a4-8ac86fb57b3c"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            CharacterId = new Guid("de4b251f-e985-492b-abe3-0256e4ac3da5"),
                            LineContent = "Look, it is Howl's castle!"
                        },
                        new
                        {
                            LineId = new Guid("c8061cc0-a281-4ca4-ad3c-3edc321a6929"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            CharacterId = new Guid("68526821-1a33-42a8-a01e-855867644119"),
                            LineContent = "Never seen it so close before!"
                        },
                        new
                        {
                            LineId = new Guid("0b9550af-8637-4373-8873-de2cb7131b79"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            CharacterId = new Guid("de4b251f-e985-492b-abe3-0256e4ac3da5"),
                            LineContent = "Oh, my... I wonder if Howl is in town."
                        },
                        new
                        {
                            LineId = new Guid("efc7b9c5-c16d-4d7b-b4f7-3f84eb329118"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            CharacterId = new Guid("b85bf3d6-7014-43f0-8051-727c9745517d"),
                            LineContent = "Oh, it is gone!"
                        },
                        new
                        {
                            LineId = new Guid("a57b5392-d025-4792-89b4-2809746371c5"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            CharacterId = new Guid("de4b251f-e985-492b-abe3-0256e4ac3da5"),
                            LineContent = "No, he is just hiding in the fog from all of those planes."
                        },
                        new
                        {
                            LineId = new Guid("6a1fde30-d496-477f-a982-7bccace88c50"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            CharacterId = new Guid("68526821-1a33-42a8-a01e-855867644119"),
                            LineContent = "Ah, now I see!"
                        },
                        new
                        {
                            LineId = new Guid("c49cb2ae-b328-43ca-a968-bbaeff925f3c"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            CharacterId = new Guid("b85bf3d6-7014-43f0-8051-727c9745517d"),
                            LineContent = "Remember Martha, from South Heaven? They say Howl tore her heart out."
                        },
                        new
                        {
                            LineId = new Guid("1a9db9ee-c830-4cc9-811b-9a9be198d187"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            CharacterId = new Guid("68526821-1a33-42a8-a01e-855867644119"),
                            LineContent = "Now I am scared to go out!"
                        },
                        new
                        {
                            LineId = new Guid("cef31226-c93b-4847-b8ca-fb152d7cebf1"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            CharacterId = new Guid("de4b251f-e985-492b-abe3-0256e4ac3da5"),
                            LineContent = "Don't worry, he only prays on pretty girls!"
                        },
                        new
                        {
                            LineId = new Guid("885b77ba-8349-4640-becf-282d12404904"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            CharacterId = new Guid("da6e1bd0-c970-43c1-8516-1e814807c9ca"),
                            LineContent = "Come on, girls! Hurry up!"
                        });
                });

            modelBuilder.Entity("TalesApp.Domain.LineNumber", b =>
                {
                    b.Property<Guid>("LineId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsLast")
                        .HasColumnType("bit");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("LineId", "StoryId");

                    b.ToTable("LineNumber");

                    b.HasData(
                        new
                        {
                            LineId = new Guid("daa31b35-9859-4b4a-b053-b65a9ecd8d15"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            IsLast = false,
                            Number = 1
                        },
                        new
                        {
                            LineId = new Guid("564d4795-ebca-4e8a-8bb5-2089c1f0e6ea"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            IsLast = false,
                            Number = 2
                        },
                        new
                        {
                            LineId = new Guid("54f7cacf-b2aa-4778-92a4-8ac86fb57b3c"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            IsLast = false,
                            Number = 3
                        },
                        new
                        {
                            LineId = new Guid("c8061cc0-a281-4ca4-ad3c-3edc321a6929"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            IsLast = false,
                            Number = 4
                        },
                        new
                        {
                            LineId = new Guid("0b9550af-8637-4373-8873-de2cb7131b79"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            IsLast = false,
                            Number = 5
                        },
                        new
                        {
                            LineId = new Guid("efc7b9c5-c16d-4d7b-b4f7-3f84eb329118"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            IsLast = false,
                            Number = 6
                        },
                        new
                        {
                            LineId = new Guid("a57b5392-d025-4792-89b4-2809746371c5"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            IsLast = false,
                            Number = 7
                        },
                        new
                        {
                            LineId = new Guid("6a1fde30-d496-477f-a982-7bccace88c50"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            IsLast = false,
                            Number = 8
                        },
                        new
                        {
                            LineId = new Guid("c49cb2ae-b328-43ca-a968-bbaeff925f3c"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            IsLast = false,
                            Number = 9
                        },
                        new
                        {
                            LineId = new Guid("1a9db9ee-c830-4cc9-811b-9a9be198d187"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            IsLast = false,
                            Number = 10
                        },
                        new
                        {
                            LineId = new Guid("cef31226-c93b-4847-b8ca-fb152d7cebf1"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            IsLast = false,
                            Number = 11
                        },
                        new
                        {
                            LineId = new Guid("885b77ba-8349-4640-becf-282d12404904"),
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            IsLast = true,
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
                            StoryId = new Guid("99b43ca2-dcac-419a-9725-2413202bb624"),
                            IsActive = false,
                            StoryCoverImage = "/images/StoriesData/MovingCastleOpeningStory/HowlsMovingCastleCover.jfif",
                            StoryName = "Opening Story of Howl's Moving Castle",
                            StorySetId = new Guid("4f26cc1c-9748-4c37-ab31-6ea40d66550a")
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
                            StorySetId = new Guid("4f26cc1c-9748-4c37-ab31-6ea40d66550a"),
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
                            StorySetId = new Guid("4f26cc1c-9748-4c37-ab31-6ea40d66550a"),
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