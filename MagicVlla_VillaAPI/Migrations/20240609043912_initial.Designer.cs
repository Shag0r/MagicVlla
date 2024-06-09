﻿// <auto-generated />
using System;
using MagicVlla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVlla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240609043912_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVlla_VillaAPI.Models.Villa", b =>
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

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("sqft")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "Pool, WiFi, Parking",
                            CreatedDate = new DateTime(2024, 6, 9, 10, 39, 12, 124, DateTimeKind.Local).AddTicks(4995),
                            Description = "A beautiful villa with a view of the pool.",
                            ImageUrl = "https://images.unsplash.com/photo-1610641818989-c2051b5e2cfd?q=80&w=1470&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            Name = "Pool View",
                            Occupancy = 4,
                            Rate = 200.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            sqft = 1500
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "Ocean View, WiFi, Parking",
                            CreatedDate = new DateTime(2024, 6, 9, 10, 39, 12, 124, DateTimeKind.Local).AddTicks(5008),
                            Description = "A relaxing villa with an ocean breeze.",
                            ImageUrl = "https://images.unsplash.com/photo-1582719508461-905c673771fd?q=80&w=1450&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            Name = "Ocean Breeze",
                            Occupancy = 6,
                            Rate = 300.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            sqft = 2000
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "Mountain View, Fireplace, WiFi",
                            CreatedDate = new DateTime(2024, 6, 9, 10, 39, 12, 124, DateTimeKind.Local).AddTicks(5009),
                            Description = "A peaceful retreat in the mountains.",
                            ImageUrl = "https://images.unsplash.com/photo-1540541338287-41700207dee6?q=80&w=1470&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            Name = "Mountain Retreat",
                            Occupancy = 8,
                            Rate = 250.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            sqft = 2500
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "Sunset View, WiFi, Parking",
                            CreatedDate = new DateTime(2024, 6, 9, 10, 39, 12, 124, DateTimeKind.Local).AddTicks(5011),
                            Description = "A haven with beautiful sunset views.",
                            ImageUrl = "https://plus.unsplash.com/premium_photo-1681922761648-d5e2c3972982?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NXx8cmVzb3J0fGVufDB8fDB8fHww",
                            Name = "Sunset Haven",
                            Occupancy = 5,
                            Rate = 220.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            sqft = 1800
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "Garden, WiFi, Parking",
                            CreatedDate = new DateTime(2024, 6, 9, 10, 39, 12, 124, DateTimeKind.Local).AddTicks(5013),
                            Description = "An oasis surrounded by gardens.",
                            ImageUrl = "https://images.unsplash.com/photo-1563911302283-d2bc129e7570?q=80&w=1470&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            Name = "Garden Oasis",
                            Occupancy = 3,
                            Rate = 180.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            sqft = 1200
                        },
                        new
                        {
                            Id = 6,
                            Amenity = "Beachfront, WiFi, Parking",
                            CreatedDate = new DateTime(2024, 6, 9, 10, 39, 12, 124, DateTimeKind.Local).AddTicks(5014),
                            Description = "A blissful villa right on the beach.",
                            ImageUrl = "https://images.unsplash.com/photo-1566073771259-6a8506099945?q=80&w=1470&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            Name = "Beachfront Bliss",
                            Occupancy = 7,
                            Rate = 350.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            sqft = 2200
                        });
                });

            modelBuilder.Entity("MagicVlla_VillaAPI.Models.VillaNumber", b =>
                {
                    b.Property<int>("villaNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialDetailes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("villaID")
                        .HasColumnType("int");

                    b.HasKey("villaNo");

                    b.HasIndex("villaID");

                    b.ToTable("VillaNumber");
                });

            modelBuilder.Entity("MagicVlla_VillaAPI.Models.VillaNumber", b =>
                {
                    b.HasOne("MagicVlla_VillaAPI.Models.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("villaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });
#pragma warning restore 612, 618
        }
    }
}
