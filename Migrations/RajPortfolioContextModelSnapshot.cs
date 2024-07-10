﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RajPortfolio.Data;

#nullable disable

namespace RajPortfolio.Migrations
{
    [DbContext(typeof(RajPortfolioContext))]
    partial class RajPortfolioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
