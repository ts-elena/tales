﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TalesApp.Data;

namespace TalesApp.Data.Migrations
{
    [DbContext(typeof(TalesContext))]
    partial class TalesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            CharacterId = new Guid("6282e937-1c9c-4c0c-bdd8-4f38edd7d1c1"),
                            CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/FannyHatter.jpg",
                            CharacterName = "Fanny"
                        },
                        new
                        {
                            CharacterId = new Guid("695dc826-8a58-4639-948f-0b11bdff91aa"),
                            CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/Sophie.jfif",
                            CharacterName = "Sophie"
                        },
                        new
                        {
                            CharacterId = new Guid("6629a74e-a5e5-43e3-9a30-d42a3821f853"),
                            CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister1.jfif",
                            CharacterName = "Sophie's sister"
                        },
                        new
                        {
                            CharacterId = new Guid("2228dd3b-287c-48cb-b236-e4bcee5b5dd9"),
                            CharacterAvatar = "/images/StoriesData/MovingCastleOpeningStory/Avatars/SophiesSister2.jfif",
                            CharacterName = "Sophie's sister"
                        },
                        new
                        {
                            CharacterId = new Guid("0908d87c-b5c4-4c3a-8fc7-5ff3f54a0213"),
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

                    b.ToTable("DictionaryWords");
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

                    b.ToTable("Lines");

                    b.HasData(
                        new
                        {
                            LineId = new Guid("1b33fdf4-98d9-41c2-8919-a9c029dfe338"),
                            CharacterId = new Guid("6282e937-1c9c-4c0c-bdd8-4f38edd7d1c1"),
                            LineContent = "Sophie, we have just closed the shop. You have done enough work, why won't you come out with us this time?",
                            StoryId = new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1")
                        },
                        new
                        {
                            LineId = new Guid("50cb0b90-209a-4048-8417-51367ea12c1d"),
                            CharacterId = new Guid("695dc826-8a58-4639-948f-0b11bdff91aa"),
                            LineContent = "No, I would better finish this. Go have some fun.",
                            StoryId = new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1")
                        },
                        new
                        {
                            LineId = new Guid("4c3f51ac-176d-4c67-b320-4e4e9b26af65"),
                            CharacterId = new Guid("6629a74e-a5e5-43e3-9a30-d42a3821f853"),
                            LineContent = "Look, it is Howl's castle!",
                            StoryId = new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1")
                        },
                        new
                        {
                            LineId = new Guid("c9922d61-2875-437e-ad08-c52b2b8bae89"),
                            CharacterId = new Guid("2228dd3b-287c-48cb-b236-e4bcee5b5dd9"),
                            LineContent = "Never seen it so close before!",
                            StoryId = new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1")
                        },
                        new
                        {
                            LineId = new Guid("a176d5df-19ea-4c6d-8397-df8c143dc256"),
                            CharacterId = new Guid("6629a74e-a5e5-43e3-9a30-d42a3821f853"),
                            LineContent = "Oh, my... I wonder if Howl is in town.",
                            StoryId = new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1")
                        },
                        new
                        {
                            LineId = new Guid("82160a4f-846a-45cc-9a19-dfd52a1f6b1f"),
                            CharacterId = new Guid("0908d87c-b5c4-4c3a-8fc7-5ff3f54a0213"),
                            LineContent = "Oh, it is gone!",
                            StoryId = new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1")
                        },
                        new
                        {
                            LineId = new Guid("6b0588a4-ab6b-42a7-abfc-978e62f30435"),
                            CharacterId = new Guid("6629a74e-a5e5-43e3-9a30-d42a3821f853"),
                            LineContent = "No, he is just hiding in the fog from all of those planes.",
                            StoryId = new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1")
                        },
                        new
                        {
                            LineId = new Guid("d0bb3d21-24fe-400f-8e3f-4adaa599f826"),
                            CharacterId = new Guid("2228dd3b-287c-48cb-b236-e4bcee5b5dd9"),
                            LineContent = "Remember Martha, from South Heaven? They say Howl tore her heart out.",
                            StoryId = new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1")
                        },
                        new
                        {
                            LineId = new Guid("d8afac43-1ac8-4958-b3a1-a421e57f2dad"),
                            CharacterId = new Guid("0908d87c-b5c4-4c3a-8fc7-5ff3f54a0213"),
                            LineContent = "Remember Martha, from South Heaven? They say Howl tore her heart out.",
                            StoryId = new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1")
                        },
                        new
                        {
                            LineId = new Guid("257a8f1c-7858-41d4-b7a1-6f55e469d2c8"),
                            CharacterId = new Guid("2228dd3b-287c-48cb-b236-e4bcee5b5dd9"),
                            LineContent = "Now I am scared to go out!",
                            StoryId = new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1")
                        },
                        new
                        {
                            LineId = new Guid("9adb5c5c-76d4-47f4-9900-34c9776d88f8"),
                            CharacterId = new Guid("6629a74e-a5e5-43e3-9a30-d42a3821f853"),
                            LineContent = "Don't worry, he only prays on pretty girls!",
                            StoryId = new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1")
                        },
                        new
                        {
                            LineId = new Guid("d5ed2319-6d55-47fb-b93f-3ba745c25fed"),
                            CharacterId = new Guid("6282e937-1c9c-4c0c-bdd8-4f38edd7d1c1"),
                            LineContent = "Come on, girls! Hurry up!",
                            StoryId = new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1")
                        });
                });

            modelBuilder.Entity("TalesApp.Domain.LineSequence", b =>
                {
                    b.Property<Guid>("LineId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SequenceNumber")
                        .HasColumnType("int");

                    b.HasKey("LineId");

                    b.ToTable("LineSequences");

                    b.HasData(
                        new
                        {
                            LineId = new Guid("1b33fdf4-98d9-41c2-8919-a9c029dfe338"),
                            SequenceNumber = 1
                        },
                        new
                        {
                            LineId = new Guid("50cb0b90-209a-4048-8417-51367ea12c1d"),
                            SequenceNumber = 2
                        },
                        new
                        {
                            LineId = new Guid("4c3f51ac-176d-4c67-b320-4e4e9b26af65"),
                            SequenceNumber = 3
                        },
                        new
                        {
                            LineId = new Guid("c9922d61-2875-437e-ad08-c52b2b8bae89"),
                            SequenceNumber = 4
                        },
                        new
                        {
                            LineId = new Guid("a176d5df-19ea-4c6d-8397-df8c143dc256"),
                            SequenceNumber = 5
                        },
                        new
                        {
                            LineId = new Guid("82160a4f-846a-45cc-9a19-dfd52a1f6b1f"),
                            SequenceNumber = 6
                        },
                        new
                        {
                            LineId = new Guid("6b0588a4-ab6b-42a7-abfc-978e62f30435"),
                            SequenceNumber = 7
                        },
                        new
                        {
                            LineId = new Guid("d0bb3d21-24fe-400f-8e3f-4adaa599f826"),
                            SequenceNumber = 8
                        },
                        new
                        {
                            LineId = new Guid("d8afac43-1ac8-4958-b3a1-a421e57f2dad"),
                            SequenceNumber = 9
                        },
                        new
                        {
                            LineId = new Guid("257a8f1c-7858-41d4-b7a1-6f55e469d2c8"),
                            SequenceNumber = 10
                        },
                        new
                        {
                            LineId = new Guid("9adb5c5c-76d4-47f4-9900-34c9776d88f8"),
                            SequenceNumber = 11
                        },
                        new
                        {
                            LineId = new Guid("d5ed2319-6d55-47fb-b93f-3ba745c25fed"),
                            SequenceNumber = 12
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

                    b.ToTable("Stories");

                    b.HasData(
                        new
                        {
                            StoryId = new Guid("d9880c22-05b0-4fe0-b3bb-c941beaf80e1"),
                            StoryCoverImage = "/images/StoriesData/MovingCastleOpeningStory/HowlsMovingCastleCover.jfif",
                            StoryName = "Opening Story of Howl's Moving Castle",
                            StorySetId = new Guid("ddb32c39-bc4b-47ad-a932-ced444044dc6")
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

                    b.ToTable("StorySets");

                    b.HasData(
                        new
                        {
                            StorySetId = new Guid("ddb32c39-bc4b-47ad-a932-ced444044dc6"),
                            StorySetName = "Set One"
                        });
                });

            modelBuilder.Entity("TalesApp.Domain.StorySetsSequence", b =>
                {
                    b.Property<Guid>("StorySetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SetNumber")
                        .HasColumnType("int");

                    b.HasKey("StorySetId");

                    b.ToTable("StorySetsSequences");

                    b.HasData(
                        new
                        {
                            StorySetId = new Guid("ddb32c39-bc4b-47ad-a932-ced444044dc6"),
                            SetNumber = 1
                        });
                });

            modelBuilder.Entity("TalesApp.Domain.DictionaryWord", b =>
                {
                    b.HasOne("TalesApp.Domain.Line", "Line")
                        .WithMany("DictionaryWord")
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

            modelBuilder.Entity("TalesApp.Domain.LineSequence", b =>
                {
                    b.HasOne("TalesApp.Domain.Line", "Line")
                        .WithOne("LineSequence")
                        .HasForeignKey("TalesApp.Domain.LineSequence", "LineId")
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

            modelBuilder.Entity("TalesApp.Domain.StorySetsSequence", b =>
                {
                    b.HasOne("TalesApp.Domain.StorySet", "StorySet")
                        .WithOne("StorySetsSequence")
                        .HasForeignKey("TalesApp.Domain.StorySetsSequence", "StorySetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
