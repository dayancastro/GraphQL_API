﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RealEstateManager.Database;

namespace RealEstateManager.Database.Migrations
{
    [DbContext(typeof(RealEstateContext))]
    [Migration("20190218004707_Owners")]
    partial class Owners
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RealEstateManager.Database.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<double>("PurchaseValue");

                    b.Property<DateTime>("SellDate");

                    b.Property<double>("SellValue");

                    b.HasKey("Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("RealEstateManager.Database.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateOverdue");

                    b.Property<bool>("Paid");

                    b.Property<int>("PropertyId");

                    b.Property<decimal>("Value");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("RealEstateManager.Database.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Family");

                    b.Property<string>("Name");

                    b.Property<string>("Street");

                    b.Property<decimal>("Value");

                    b.HasKey("Id");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("RealEstateManager.Database.Models.PropertyOwner", b =>
                {
                    b.Property<int>("OwnerId");

                    b.Property<int>("PropertyId");

                    b.HasKey("OwnerId", "PropertyId");

                    b.HasIndex("PropertyId");

                    b.ToTable("PropertyOwners");
                });

            modelBuilder.Entity("RealEstateManager.Database.Models.Payment", b =>
                {
                    b.HasOne("RealEstateManager.Database.Models.Property", "Property")
                        .WithMany("Payments")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RealEstateManager.Database.Models.PropertyOwner", b =>
                {
                    b.HasOne("RealEstateManager.Database.Models.Owner", "Owner")
                        .WithMany("PropertyOwners")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RealEstateManager.Database.Models.Property", "Property")
                        .WithMany("PropertyOwners")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
