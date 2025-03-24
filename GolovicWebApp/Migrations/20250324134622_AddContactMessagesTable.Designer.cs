﻿// <auto-generated />
using System;
using GolovicWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GolovicWebApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250324134622_AddContactMessagesTable")]
    partial class AddContactMessagesTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GolovicWebApp.Models.ContactMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("SentAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ContactMessages");
                });

            modelBuilder.Entity("GolovicWebApp.Models.PortfolioItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PortfolioItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A cat-motivated Tetris game for Windows featuring 20 blocks, standard tetrominoes, and an original BPS scoring system.",
                            ImageUrl = "/images/meowtris.jpg",
                            Name = "Meowtris",
                            ProjectUrl = "https://github.com/igolovic/meowtris"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Cross-platform GUI desktop application that compares files in two folders based on size and binary content, identifying matches and unique files.",
                            ImageUrl = "/images/cmpbin.jpg",
                            Name = "CmpBin",
                            ProjectUrl = "https://github.com/igolovic/cmpbin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
