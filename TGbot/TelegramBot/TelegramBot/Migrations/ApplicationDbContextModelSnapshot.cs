﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using TelegramBot;

namespace TelegramBot.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TelegramBot.Models.Carry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Carrys");
                });

            modelBuilder.Entity("TelegramBot.Models.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CarryId");

                    b.Property<int>("Score");

                    b.Property<Guid>("SupportId");

                    b.Property<long>("TelegramId");

                    b.HasKey("Id");

                    b.HasIndex("CarryId");

                    b.HasIndex("SupportId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("TelegramBot.Models.Support", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Supports");
                });

            modelBuilder.Entity("TelegramBot.Models.Player", b =>
                {
                    b.HasOne("TelegramBot.Models.Carry", "Carry")
                        .WithMany()
                        .HasForeignKey("CarryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TelegramBot.Models.Support", "Support")
                        .WithMany()
                        .HasForeignKey("SupportId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
