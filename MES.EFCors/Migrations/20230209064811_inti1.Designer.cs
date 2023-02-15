﻿// <auto-generated />
using System;
using MES.EFCors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MES.EFCors.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230209064811_inti1")]
    partial class inti1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DeviceClasses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceGrouping")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeviceStatus")
                        .HasColumnType("int");

                    b.Property<string>("Organization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("device");
                });

            modelBuilder.Entity("Domain.Production", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodeOfDieFixture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoldStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameOfTheFixture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Packet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specifications")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToolingType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("production");
                });

            modelBuilder.Entity("Mes.Domain.Meteriel.BasicUnits", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("basicunits");
                });

            modelBuilder.Entity("Mes.Domain.Meteriel.CheckSystem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CheckSystemName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("checkSystem");
                });

            modelBuilder.Entity("Mes.Domain.Meteriel.MaterielProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MaterielPropertyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("materielProperty");
                });

            modelBuilder.Entity("Mes.Domain.Meteriel.Meteriel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BasicUnitsId")
                        .HasColumnType("int");

                    b.Property<int>("CheckSystemId")
                        .HasColumnType("int");

                    b.Property<string>("DefaultDepot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DefaultPositions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DrawingNumber")
                        .HasColumnType("int");

                    b.Property<string>("EnableSequenceNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FinalInspection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GrossWeight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarketingUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<string>("MaterielName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaterielPropertyId")
                        .HasColumnType("int");

                    b.Property<string>("MaterielType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaximumInventory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MinPackage")
                        .HasColumnType("int");

                    b.Property<string>("MinimumQuantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Net")
                        .HasColumnType("int");

                    b.Property<string>("Nimikedimensio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoFeeding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PacketId")
                        .HasColumnType("int");

                    b.Property<string>("PurchaseUnitId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SafetyStock")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specifications")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StockKeepingUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Taxrate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdPartySerialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Useorganization")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("meteriel");
                });

            modelBuilder.Entity("Mes.Domain.Meteriel.Packet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PacketName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("packet");
                });

            modelBuilder.Entity("Mes.Domain.Meteriel.PurchaseUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("purchaseUnit");
                });
#pragma warning restore 612, 618
        }
    }
}
