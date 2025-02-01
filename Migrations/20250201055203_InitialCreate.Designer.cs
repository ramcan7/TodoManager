﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoManager.Data;

#nullable disable

namespace TodoManager.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250201055203_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("TodoManager.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ClientId"));

                    b.Property<string>("ClientEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ClientPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ClientUsername")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("TodoManager.Models.Todo", b =>
                {
                    b.Property<int>("TodoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("TodoId"));

                    b.Property<string>("TodoDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("TodoDueDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("TodoIsCompleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("TodoPriority")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<TimeSpan>("TodoTimeSpan")
                        .HasColumnType("time(6)");

                    b.Property<string>("TodoTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TodoId");

                    b.ToTable("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
