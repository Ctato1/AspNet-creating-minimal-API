﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tester1.DBContexts;

#nullable disable

namespace BeetleMovies.API.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        },
                        new
                        {
                            Id = 3,
                            Name = "Adrian Molina"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Lee Unkrich"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Brad Bird"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Peter Ramsey"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Bob Persichetti"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Rodney Rothman"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Makoto Shinkai"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Chris Sanders"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Dean DeBlois"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Angus MacLane"
                        },
                        new
                        {
                            Id = 13,
                            Name = "David Fincher"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Anthony Russo"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Joe Russo"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Antoine Fuqua"
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
                        },
                        new
                        {
                            Id = 3,
                            Rating = 8.4000000000000004,
                            Title = "Coco",
                            Year = 2017
                        },
                        new
                        {
                            Id = 4,
                            Rating = 8.0999999999999996,
                            Title = "The Iron Giant",
                            Year = 1999
                        },
                        new
                        {
                            Id = 5,
                            Rating = 8.4000000000000004,
                            Title = "Spider-Man - Into the spider-verse",
                            Year = 2018
                        },
                        new
                        {
                            Id = 6,
                            Rating = 8.4000000000000004,
                            Title = "Your Name",
                            Year = 2016
                        },
                        new
                        {
                            Id = 7,
                            Rating = 8.0999999999999996,
                            Title = "How to Train Your Dragon",
                            Year = 2010
                        },
                        new
                        {
                            Id = 8,
                            Rating = 5.7000000000000002,
                            Title = "Lightyear",
                            Year = 2022
                        },
                        new
                        {
                            Id = 9,
                            Rating = 7.7999999999999998,
                            Title = "The Girl with the Dragon Tattoo",
                            Year = 2011
                        },
                        new
                        {
                            Id = 10,
                            Rating = 8.4000000000000004,
                            Title = "Avengers: Endgame",
                            Year = 2019
                        },
                        new
                        {
                            Id = 11,
                            Rating = 7.2000000000000002,
                            Title = "The Equalizer",
                            Year = 2014
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
                        },
                        new
                        {
                            DirectorsId = 3,
                            MoviesId = 3
                        },
                        new
                        {
                            DirectorsId = 4,
                            MoviesId = 3
                        },
                        new
                        {
                            DirectorsId = 5,
                            MoviesId = 4
                        },
                        new
                        {
                            DirectorsId = 6,
                            MoviesId = 5
                        },
                        new
                        {
                            DirectorsId = 7,
                            MoviesId = 5
                        },
                        new
                        {
                            DirectorsId = 8,
                            MoviesId = 5
                        },
                        new
                        {
                            DirectorsId = 9,
                            MoviesId = 6
                        },
                        new
                        {
                            DirectorsId = 10,
                            MoviesId = 7
                        },
                        new
                        {
                            DirectorsId = 11,
                            MoviesId = 7
                        },
                        new
                        {
                            DirectorsId = 12,
                            MoviesId = 8
                        },
                        new
                        {
                            DirectorsId = 13,
                            MoviesId = 9
                        },
                        new
                        {
                            DirectorsId = 14,
                            MoviesId = 10
                        },
                        new
                        {
                            DirectorsId = 15,
                            MoviesId = 10
                        },
                        new
                        {
                            DirectorsId = 16,
                            MoviesId = 11
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
