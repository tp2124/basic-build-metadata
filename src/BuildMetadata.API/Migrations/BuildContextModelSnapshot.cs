﻿// <auto-generated />
using BuildMetadata.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BuildMetadata.Migrations
{
    [DbContext(typeof(BuildContext))]
    partial class BuildContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("BuildMetadata.Models.Build", b =>
                {
                    b.Property<uint>("ChangelistNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasPackagedBinaries")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsNightly")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("KnownGoodClient")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("KnownGoodEditor")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<bool>("QVCompleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("QVIsTesting")
                        .HasColumnType("INTEGER");

                    b.HasKey("ChangelistNumber");

                    b.ToTable("Builds");
                });
#pragma warning restore 612, 618
        }
    }
}
