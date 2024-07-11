﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RajPortfolio.Data;

#nullable disable

namespace RajPortfolio.Migrations
{
    [DbContext(typeof(RajPortfolioContext))]
    [Migration("20240711140922_New_DataAnnotations")]
    partial class New_DataAnnotations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("RajPortfolio.Models.Track", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<double>("length")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.ToTable("Track");
                });
#pragma warning restore 612, 618
        }
    }
}
