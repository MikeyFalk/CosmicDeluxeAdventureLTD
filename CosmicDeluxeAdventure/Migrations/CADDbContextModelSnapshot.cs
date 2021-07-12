﻿// <auto-generated />
using System;
using CosmicDeluxeAdventure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CosmicDeluxeAdventure.Migrations
{
    [DbContext(typeof(CADDbContext))]
    partial class CADDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CosmicDeluxeAdventure.Model.Flight", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Arrival")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Departure")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LocationID")
                        .HasColumnType("int");

                    b.Property<long>("Miles")
                        .HasColumnType("bigint");

                    b.Property<int?>("ShipIdID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("LocationID");

                    b.HasIndex("ShipIdID");

                    b.ToTable("Flight");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Arrival = new DateTime(2022, 10, 23, 23, 10, 0, 0, DateTimeKind.Unspecified),
                            Departure = new DateTime(2022, 10, 23, 7, 56, 0, 0, DateTimeKind.Unspecified),
                            Miles = 0L,
                            Status = 1
                        });
                });

            modelBuilder.Entity("CosmicDeluxeAdventure.Model.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Originally built as a science and exploration space.  Since the growth of inter-planetary travel has become the premier gateway to other planets",
                            Name = "Internation Space Station"
                        });
                });

            modelBuilder.Entity("CosmicDeluxeAdventure.Model.Ship", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Ship");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "First and the finest of the Adventure Class Ships.",
                            Name = "Orbital Horizons"
                        });
                });

            modelBuilder.Entity("CosmicDeluxeAdventure.Model.UserInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("UserInfo");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "1234 Corneria Way",
                            City = "Imperial Base",
                            Country = "Corneria",
                            FirstName = "Fox",
                            LastName = "McCloud",
                            PhoneNumber = 1112223333,
                            State = "Alpha",
                            UserName = "barrelRoll1",
                            ZipCode = 12345
                        });
                });

            modelBuilder.Entity("CosmicDeluxeAdventure.Model.Flight", b =>
                {
                    b.HasOne("CosmicDeluxeAdventure.Model.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationID");

                    b.HasOne("CosmicDeluxeAdventure.Model.Ship", "ShipId")
                        .WithMany()
                        .HasForeignKey("ShipIdID");

                    b.Navigation("Location");

                    b.Navigation("ShipId");
                });
#pragma warning restore 612, 618
        }
    }
}
