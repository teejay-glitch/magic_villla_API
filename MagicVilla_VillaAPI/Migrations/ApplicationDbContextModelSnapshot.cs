﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPI.Model.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2024, 1, 30, 15, 22, 20, 533, DateTimeKind.Local).AddTicks(4273),
                            Details = "Details",
                            ImageUrl = "",
                            Name = "Beach Villa",
                            Occupancy = 10,
                            Rate = 20.0,
                            Sqft = 220,
                            UpdatedDate = new DateTime(2024, 1, 30, 15, 22, 20, 533, DateTimeKind.Local).AddTicks(4286)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2024, 1, 30, 15, 22, 20, 533, DateTimeKind.Local).AddTicks(4288),
                            Details = "Details",
                            ImageUrl = "",
                            Name = "Beach Villa",
                            Occupancy = 10,
                            Rate = 20.0,
                            Sqft = 220,
                            UpdatedDate = new DateTime(2024, 1, 30, 15, 22, 20, 533, DateTimeKind.Local).AddTicks(4289)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2024, 1, 30, 15, 22, 20, 533, DateTimeKind.Local).AddTicks(4291),
                            Details = "Details",
                            ImageUrl = "",
                            Name = "Lake Villa",
                            Occupancy = 10,
                            Rate = 20.0,
                            Sqft = 220,
                            UpdatedDate = new DateTime(2024, 1, 30, 15, 22, 20, 533, DateTimeKind.Local).AddTicks(4292)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
