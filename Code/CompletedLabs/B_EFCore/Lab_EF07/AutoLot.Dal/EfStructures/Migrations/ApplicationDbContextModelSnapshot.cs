﻿// <auto-generated />
using System;
using System.Collections.Generic;
using AutoLot.Dal.EfStructures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutoLot.Dal.EfStructures.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AutoLot.Models.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("DateBuilt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Display")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("nvarchar(max)")
                        .HasComputedColumnSql("[PetName] + ' (' + [Color] + ')'", true);

                    b.Property<bool>("IsDrivable")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("MakeId")
                        .HasColumnType("int");

                    b.Property<string>("PetName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "MakeId" }, "IX_Inventory_MakeId");

                    b.ToTable("Inventory", "dbo");
                });

            modelBuilder.Entity("AutoLot.Models.Entities.CarDriver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("InventoryId");

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("CarId", "DriverId")
                        .IsUnique();

                    b.ToTable("InventoryToDrivers", "dbo");
                });

            modelBuilder.Entity("AutoLot.Models.Entities.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.ComplexProperty<Dictionary<string, object>>("PersonInformation", "AutoLot.Models.Entities.Driver.PersonInformation#Person", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("FullName")
                                .ValueGeneratedOnAddOrUpdate()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("FullName")
                                .HasComputedColumnSql("[LastName] + ', ' + [FirstName]");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)")
                                .HasColumnName("LastName");
                        });

                    b.HasKey("Id");

                    b.ToTable("Drivers", "dbo");
                });

            modelBuilder.Entity("AutoLot.Models.Entities.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("Makes", "dbo");
                });

            modelBuilder.Entity("AutoLot.Models.Entities.Radio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("InventoryId");

                    b.Property<bool>("HasSubWoofers")
                        .HasColumnType("bit");

                    b.Property<bool>("HasTweeters")
                        .HasColumnType("bit");

                    b.Property<string>("RadioId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CarId" }, "IX_Radios_CarId")
                        .IsUnique();

                    b.ToTable("Radios", "dbo");
                });

            modelBuilder.Entity("AutoLot.Models.Entities.SeriLogEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ActionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exception")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int?>("LineNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("LogEvent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageTemplate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Properties")
                        .HasColumnType("Xml");

                    b.Property<string>("RequestPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SourceContext")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Id");

                    b.ToTable("SeriLogs", "Logging");
                });

            modelBuilder.Entity("AutoLot.Models.ViewModels.CarViewModel", b =>
                {
                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateBuilt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsDrivable")
                        .HasColumnType("bit");

                    b.Property<int>("MakeId")
                        .HasColumnType("int");

                    b.Property<string>("PetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.ToTable("CarViewModel", t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("AutoLot.Models.Entities.Car", b =>
                {
                    b.HasOne("AutoLot.Models.Entities.Make", "MakeNavigation")
                        .WithMany("Cars")
                        .HasForeignKey("MakeId")
                        .IsRequired()
                        .HasConstraintName("FK_Inventory_Makes_MakeId");

                    b.Navigation("MakeNavigation");
                });

            modelBuilder.Entity("AutoLot.Models.Entities.CarDriver", b =>
                {
                    b.HasOne("AutoLot.Models.Entities.Car", "CarNavigation")
                        .WithMany("CarDrivers")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired()
                        .HasConstraintName("FK_InventoryDriver_Inventory_InventoryId");

                    b.HasOne("AutoLot.Models.Entities.Driver", "DriverNavigation")
                        .WithMany("CarDrivers")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_InventoryDriver_Drivers_DriverId");

                    b.Navigation("CarNavigation");

                    b.Navigation("DriverNavigation");
                });

            modelBuilder.Entity("AutoLot.Models.Entities.Radio", b =>
                {
                    b.HasOne("AutoLot.Models.Entities.Car", "CarNavigation")
                        .WithOne("RadioNavigation")
                        .HasForeignKey("AutoLot.Models.Entities.Radio", "CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarNavigation");
                });

            modelBuilder.Entity("AutoLot.Models.Entities.Car", b =>
                {
                    b.Navigation("CarDrivers");

                    b.Navigation("RadioNavigation");
                });

            modelBuilder.Entity("AutoLot.Models.Entities.Driver", b =>
                {
                    b.Navigation("CarDrivers");
                });

            modelBuilder.Entity("AutoLot.Models.Entities.Make", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
