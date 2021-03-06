﻿// <auto-generated />
using lab17DatabaseDesign.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace lab17DatabaseDesign.Migrations
{
    [DbContext(typeof(lab17DatabaseDesignContext))]
    [Migration("20171005173936_addedDSTable")]
    partial class addedDSTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("lab17DatabaseDesign.Models.Destinations", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<string>("Currncy");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("lab17DatabaseDesign.Models.Recomended", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DestinationsID");

                    b.Property<string>("Name");

                    b.Property<int>("Size");

                    b.Property<int>("Weight");

                    b.HasKey("ID");

                    b.HasIndex("DestinationsID");

                    b.ToTable("Recomended");
                });

            modelBuilder.Entity("lab17DatabaseDesign.Models.Required", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DestinationsID");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("DestinationsID");

                    b.ToTable("Required");
                });

            modelBuilder.Entity("lab17DatabaseDesign.Models.Recomended", b =>
                {
                    b.HasOne("lab17DatabaseDesign.Models.Destinations")
                        .WithMany("Recomended")
                        .HasForeignKey("DestinationsID");
                });

            modelBuilder.Entity("lab17DatabaseDesign.Models.Required", b =>
                {
                    b.HasOne("lab17DatabaseDesign.Models.Destinations")
                        .WithMany("Required")
                        .HasForeignKey("DestinationsID");
                });
#pragma warning restore 612, 618
        }
    }
}
