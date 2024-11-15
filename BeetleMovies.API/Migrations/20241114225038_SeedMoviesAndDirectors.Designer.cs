﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tester1.DBContexts;

#nullable disable

namespace BeetleMovies.API.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20241114225038_SeedMoviesAndDirectors")]
    partial class SeedMoviesAndDirectors
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("BeetleMovies.API.Entities.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Directors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Brian De Palma"
                        },
                        new
                        {
                            Id = 2,
                            Name = "John Lasseter"
                        });
                });

            modelBuilder.Entity("BeetleMovies.API.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Rating")
                        .HasColumnType("REAL");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Rating = 7.0999999999999996,
                            Title = "Mission Impossible",
                            Year = 1996
                        },
                        new
                        {
                            Id = 2,
                            Rating = 8.3000000000000007,
                            Title = "Toy Story",
                            Year = 1995
                        });
                });

            modelBuilder.Entity("DirectorMovie", b =>
                {
                    b.Property<int>("DirectorsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MoviesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DirectorsId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("DirectorMovie");

                    b.HasData(
                        new
                        {
                            DirectorsId = 1,
                            MoviesId = 1
                        },
                        new
                        {
                            DirectorsId = 2,
                            MoviesId = 2
                        });
                });

            modelBuilder.Entity("DirectorMovie", b =>
                {
                    b.HasOne("BeetleMovies.API.Entities.Director", null)
                        .WithMany()
                        .HasForeignKey("DirectorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeetleMovies.API.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
