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
    [Migration("20200501115811_initial")]
    partial class initial
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

                    b.ToTable("Characters");
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

                    b.Property<Guid>("LineId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LineStoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("WordAddedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.HasKey("DictionaryWordId");

                    b.HasIndex("LineId1", "LineStoryId");

                    b.ToTable("DictionaryWords");
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

                    b.ToTable("Lines");
                });

            modelBuilder.Entity("TalesApp.Domain.LineSequence", b =>
                {
                    b.Property<Guid>("LineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LineId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("LineNumber")
                        .HasColumnType("int");

                    b.Property<Guid>("LineStoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LineId");

                    b.HasIndex("LineId1", "LineStoryId");

                    b.ToTable("LineSequences");
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
                });

            modelBuilder.Entity("TalesApp.Domain.DictionaryWord", b =>
                {
                    b.HasOne("TalesApp.Domain.Line", "Line")
                        .WithMany("DictionaryWords")
                        .HasForeignKey("LineId1", "LineStoryId")
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
                        .WithMany()
                        .HasForeignKey("LineId1", "LineStoryId")
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
#pragma warning restore 612, 618
        }
    }
}
