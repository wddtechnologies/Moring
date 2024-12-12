﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Morning.Infrastructure.Data;

#nullable disable

namespace Morning.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Morning.Domain.Entities.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 12, 12, 9, 22, 2, 17, DateTimeKind.Local).AddTicks(5448),
                            Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Royal Villa",
                            Occupancy = 4,
                            Price = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2024, 12, 12, 9, 22, 2, 17, DateTimeKind.Local).AddTicks(5509)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 12, 12, 9, 22, 2, 17, DateTimeKind.Local).AddTicks(5512),
                            Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Premium Pool Villa",
                            Occupancy = 4,
                            Price = 300.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2024, 12, 12, 9, 22, 2, 17, DateTimeKind.Local).AddTicks(5513)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 12, 12, 9, 22, 2, 17, DateTimeKind.Local).AddTicks(5516),
                            Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Luxury Pool Villa",
                            Occupancy = 4,
                            Price = 400.0,
                            Sqft = 750,
                            UpdateDate = new DateTime(2024, 12, 12, 9, 22, 2, 17, DateTimeKind.Local).AddTicks(5517)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 12, 12, 9, 22, 2, 17, DateTimeKind.Local).AddTicks(5519),
                            Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Diamond Villa",
                            Occupancy = 4,
                            Price = 550.0,
                            Sqft = 900,
                            UpdateDate = new DateTime(2024, 12, 12, 9, 22, 2, 17, DateTimeKind.Local).AddTicks(5521)
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 12, 12, 9, 22, 2, 17, DateTimeKind.Local).AddTicks(5523),
                            Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Diamond Pool Villa",
                            Occupancy = 4,
                            Price = 600.0,
                            Sqft = 1100,
                            UpdateDate = new DateTime(2024, 12, 12, 9, 22, 2, 17, DateTimeKind.Local).AddTicks(5524)
                        });
                });

            modelBuilder.Entity("Morning.Domain.Entities.VillaNumber", b =>
                {
                    b.Property<int>("Villa_Number")
                        .HasColumnType("int");

                    b.Property<string>("SpecialDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VillaId")
                        .HasColumnType("int");

                    b.HasKey("Villa_Number");

                    b.HasIndex("VillaId");

                    b.ToTable("VillaNumbers");

                    b.HasData(
                        new
                        {
                            Villa_Number = 101,
                            VillaId = 1
                        },
                        new
                        {
                            Villa_Number = 201,
                            VillaId = 2
                        },
                        new
                        {
                            Villa_Number = 301,
                            VillaId = 3
                        },
                        new
                        {
                            Villa_Number = 401,
                            VillaId = 4
                        },
                        new
                        {
                            Villa_Number = 501,
                            VillaId = 5
                        });
                });

            modelBuilder.Entity("Morning.Domain.Entities.VillaNumber", b =>
                {
                    b.HasOne("Morning.Domain.Entities.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });
#pragma warning restore 612, 618
        }
    }
}
