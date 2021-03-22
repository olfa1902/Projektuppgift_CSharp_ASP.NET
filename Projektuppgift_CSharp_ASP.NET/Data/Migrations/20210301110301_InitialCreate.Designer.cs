﻿// <auto-generated />

namespace Projektuppgift_CSharp_ASP.NET.Migrations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.EntityFrameworkCore.Migrations;
    using Projektuppgift_CSharp_ASP.NET.Data;

    /// <summary>
    /// Defines the <see cref="InitialCreate" />.
    /// </summary>
    [DbContext(typeof(MovieContext))]
    [Migration("20210301110301_InitialCreate")]
    internal partial class InitialCreate
    {
        /// <summary>
        /// The BuildTargetModel.
        /// </summary>
        /// <param name="modelBuilder">The modelBuilder<see cref="ModelBuilder"/>.</param>
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("Projektuppgift_CSharp_ASP.NET.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasMaxLength(70)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(499)
                        .HasColumnType("TEXT");

                    b.Property<string>("Length")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasMaxLength(70)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });
        }
    }
}
