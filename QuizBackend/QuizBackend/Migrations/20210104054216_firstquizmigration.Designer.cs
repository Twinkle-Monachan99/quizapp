﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizBackend;

namespace QuizBackend.Migrations
{
    [DbContext(typeof(QuizDbContext))]
    [Migration("20210104054216_firstquizmigration")]
    partial class firstquizmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("QuizBackend.Models.Question", b =>
                {
                    b.Property<int>("QuestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("answer1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("answer2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("answer3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correctAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestId");

                    b.ToTable("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
