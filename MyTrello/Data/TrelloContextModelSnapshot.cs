﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTrello.Data
{
    [DbContext(typeof(TrelloCloneContext))]
    partial class TrelloContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TrelloClone.Models.Board", b =>
            {
                b.Property<int>("ID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("ID");

                b.ToTable("Board");
            });

            modelBuilder.Entity("TrelloClone.Models.Task", b =>
            {
                b.Property<int>("ID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("TaskListID")
                    .HasColumnType("int");

                b.Property<string>("Text")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("ID");

                b.HasIndex("TaskListID");

                b.ToTable("Task");
            });

            modelBuilder.Entity("TrelloClone.Models.TaskList", b =>
            {
                b.Property<int>("ID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("BoardID")
                    .HasColumnType("int");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("ID");

                b.HasIndex("BoardID");

                b.ToTable("TaskList");
            });

            modelBuilder.Entity("TrelloClone.Models.Task", b =>
            {
                b.HasOne("TrelloClone.Models.TaskList", null)
                    .WithMany("Tasks")
                    .HasForeignKey("TaskListID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("TrelloClone.Models.TaskList", b =>
            {
                b.HasOne("TrelloClone.Models.Board", null)
                    .WithMany("TaskLists")
                    .HasForeignKey("BoardID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });
#pragma warning restore 612, 618
        }
    }
}
