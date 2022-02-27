﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizApp.DL.Database;

#nullable disable

namespace QuizApp.DL.Migrations
{
    [DbContext(typeof(QuizAppDbContext))]
    partial class QuizAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("QuizApp.DL.Domain.Answers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Correct")
                        .HasColumnType("bit");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6e6e2ef9-22d6-4e0d-bbe7-8f430b700307"),
                            Correct = true,
                            QuestionId = new Guid("6cf76c06-901d-40b2-8ba7-7d12506a4faa"),
                            Text = "22 Months"
                        },
                        new
                        {
                            Id = new Guid("e4570234-10ea-4698-85d8-9a58923a42a8"),
                            Correct = false,
                            QuestionId = new Guid("6cf76c06-901d-40b2-8ba7-7d12506a4faa"),
                            Text = "28 Months"
                        },
                        new
                        {
                            Id = new Guid("5c7d1550-90df-467d-bc83-26435548eef5"),
                            Correct = false,
                            QuestionId = new Guid("6cf76c06-901d-40b2-8ba7-7d12506a4faa"),
                            Text = "18 Months"
                        });
                });

            modelBuilder.Entity("QuizApp.DL.Domain.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0022ede5-f8f5-4de3-9db0-7742f9c9b933"),
                            Name = "Animal"
                        },
                        new
                        {
                            Id = new Guid("e7776350-4164-4176-9a87-15a32990ef66"),
                            Name = "Geography"
                        },
                        new
                        {
                            Id = new Guid("a8499f2f-a23d-428d-9369-8f8b7e2b4085"),
                            Name = "Sport"
                        },
                        new
                        {
                            Id = new Guid("271df7c1-6b22-416e-95b1-8dee7e27486d"),
                            Name = "Music"
                        });
                });

            modelBuilder.Entity("QuizApp.DL.Domain.Questions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6cf76c06-901d-40b2-8ba7-7d12506a4faa"),
                            CategoryId = new Guid("0022ede5-f8f5-4de3-9db0-7742f9c9b933"),
                            Text = "How long is an elephant pregnant before it gives birth?"
                        },
                        new
                        {
                            Id = new Guid("e42b3dd0-336f-45cc-ac48-78c6a4775717"),
                            CategoryId = new Guid("0022ede5-f8f5-4de3-9db0-7742f9c9b933"),
                            Text = "How far away can a wolf smell its prey?"
                        },
                        new
                        {
                            Id = new Guid("034a693c-dc37-464c-b61d-5b1a8a12aeaf"),
                            CategoryId = new Guid("0022ede5-f8f5-4de3-9db0-7742f9c9b933"),
                            Text = "Which animal is known to spend 90% of its day, sleeping?"
                        });
                });

            modelBuilder.Entity("QuizApp.DL.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nickname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalPoints")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("664d038a-90b0-4c88-baaf-8da05b9ab304"),
                            Nickname = "AjlaBise",
                            TotalPoints = 150
                        },
                        new
                        {
                            Id = new Guid("548fc16c-36f3-472b-997a-6c4a75f9c9f3"),
                            Nickname = "GargEvil",
                            TotalPoints = 150
                        });
                });

            modelBuilder.Entity("QuizApp.DL.Domain.UserQuestion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserQuestions");
                });
#pragma warning restore 612, 618
        }
    }
}
