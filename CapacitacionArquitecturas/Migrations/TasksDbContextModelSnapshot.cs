﻿// <auto-generated />
using System;
using CapacitacionArquitecturas.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CapacitacionArquitecturas.Migrations
{
    [DbContext(typeof(TasksDbContext))]
    partial class TasksDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("CapacitacionArquitecturas.Domain.Tasks.ToDoTask", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsCompleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = "c2d829b0-31e9-4f0f-a253-bcf19ef3cc21",
                            Description = "Description 1",
                            IsCompleted = false,
                            Title = "Sample Task 1"
                        },
                        new
                        {
                            Id = "a56413b4-7832-4760-ab1d-b3cf3b22a89e",
                            Description = "Description 2",
                            IsCompleted = true,
                            Title = "Sample Task 2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
