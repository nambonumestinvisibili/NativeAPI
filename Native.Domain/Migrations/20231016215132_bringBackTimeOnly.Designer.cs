﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Native.Domain.DataAccess;

#nullable disable

namespace Native.Domain.Migrations
{
    [DbContext(typeof(NativeContext))]
    [Migration("20231016215132_bringBackTimeOnly")]
    partial class bringBackTimeOnly
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventInterest", b =>
                {
                    b.Property<int>("EventsId")
                        .HasColumnType("int");

                    b.Property<int>("InterestsId")
                        .HasColumnType("int");

                    b.HasKey("EventsId", "InterestsId");

                    b.HasIndex("InterestsId");

                    b.ToTable("EventInterest");
                });

            modelBuilder.Entity("InterestProfile", b =>
                {
                    b.Property<int>("InterestsId")
                        .HasColumnType("int");

                    b.Property<int>("ProfilesId")
                        .HasColumnType("int");

                    b.HasKey("InterestsId", "ProfilesId");

                    b.HasIndex("ProfilesId");

                    b.ToTable("InterestProfile");
                });

            modelBuilder.Entity("InterestVenue", b =>
                {
                    b.Property<int>("InterestsId")
                        .HasColumnType("int");

                    b.Property<int>("VenuesId")
                        .HasColumnType("int");

                    b.HasKey("InterestsId", "VenuesId");

                    b.HasIndex("VenuesId");

                    b.ToTable("InterestVenue");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "a03a576d-406e-4294-ac87-f059b1d81624",
                            Name = "user",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "834b343f-827b-4a12-a9b1-b92ebc514961",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Native.Domain.Models.City", b =>
                {
                    b.Property<string>("CountryIsoCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("CountryIsoCode", "PostalCode");

                    b.HasIndex("LocationId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Native.Domain.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Charge")
                        .HasColumnType("decimal(18,2)");

                    b.Property<TimeSpan>("ClosingTime")
                        .HasColumnType("time");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("OpeningTime")
                        .HasColumnType("time");

                    b.Property<int>("OrganiserId")
                        .HasColumnType("int");

                    b.Property<int>("ResidenceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrganiserId");

                    b.HasIndex("ResidenceId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Native.Domain.Models.Interest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Interests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Guid = new Guid("8b36b8a7-68e0-4144-897e-706bd2188374"),
                            Name = "Coffe & chat"
                        },
                        new
                        {
                            Id = 2,
                            Guid = new Guid("9d55aaa1-715d-4010-88df-5a2e0df25007"),
                            Name = "Walk & talk"
                        },
                        new
                        {
                            Id = 3,
                            Guid = new Guid("1e4e676f-525f-43bf-8ef3-d1b330c96562"),
                            Name = "Networking"
                        },
                        new
                        {
                            Id = 4,
                            Guid = new Guid("6f13dd55-438d-4a6c-892b-2045ffda4540"),
                            Name = "Cinema"
                        },
                        new
                        {
                            Id = 5,
                            Guid = new Guid("3009faf9-20a6-4fc1-b38e-963065069135"),
                            Name = "Theatre"
                        },
                        new
                        {
                            Id = 6,
                            Guid = new Guid("9dd3f057-e9ae-4340-b6e4-a42eede8a5c1"),
                            Name = "Gigs & concerts"
                        },
                        new
                        {
                            Id = 7,
                            Guid = new Guid("d889f5cc-415e-4b99-b1fd-5403ff6c91ef"),
                            Name = "Shopping"
                        },
                        new
                        {
                            Id = 8,
                            Guid = new Guid("61414e9c-491d-4259-b325-2e0718d3f9f8"),
                            Name = "Bowling"
                        },
                        new
                        {
                            Id = 9,
                            Guid = new Guid("5c434aea-054f-4cfd-b19c-2c3f41b64808"),
                            Name = "Poker"
                        },
                        new
                        {
                            Id = 10,
                            Guid = new Guid("9d5ea3de-b8c3-4363-97c0-5349174fca6e"),
                            Name = "Karting"
                        },
                        new
                        {
                            Id = 11,
                            Guid = new Guid("11e74a6b-3231-4d4f-bdb8-c9b1ee3e88cf"),
                            Name = "Pub quiz"
                        },
                        new
                        {
                            Id = 12,
                            Guid = new Guid("03f6e0c1-5a10-4fe0-8dfe-9a8e310675df"),
                            Name = "Dancing"
                        },
                        new
                        {
                            Id = 13,
                            Guid = new Guid("d2bda9b8-63ee-4366-b86e-7dd33fe5bf25"),
                            Name = "Languages"
                        },
                        new
                        {
                            Id = 14,
                            Guid = new Guid("70560b9c-e99d-4451-9c5d-7047b5779083"),
                            Name = "Photography"
                        },
                        new
                        {
                            Id = 15,
                            Guid = new Guid("67420291-213c-489d-b513-e938bcbeef9d"),
                            Name = "Baking"
                        },
                        new
                        {
                            Id = 16,
                            Guid = new Guid("2b6031d3-7960-400a-ae14-d9bf63e5ba08"),
                            Name = "Satrtups & enterpreneurship"
                        },
                        new
                        {
                            Id = 17,
                            Guid = new Guid("044d6763-ef30-4f73-ba34-962ace807b98"),
                            Name = "Hollistic wellness"
                        },
                        new
                        {
                            Id = 18,
                            Guid = new Guid("1ae8e656-6097-44e7-ad45-a07013e7036c"),
                            Name = "Nutrition"
                        },
                        new
                        {
                            Id = 19,
                            Guid = new Guid("3558d6ee-fbe6-4916-bca2-546151de151b"),
                            Name = "Reading"
                        },
                        new
                        {
                            Id = 20,
                            Guid = new Guid("a1ddef72-94f1-4a56-959d-42976150f1e3"),
                            Name = "Writing"
                        },
                        new
                        {
                            Id = 21,
                            Guid = new Guid("c8927c07-f772-438e-bc81-174b27b65d37"),
                            Name = "Gardening"
                        },
                        new
                        {
                            Id = 22,
                            Guid = new Guid("215ad8be-c2b9-48e2-87eb-fc7729ca04a9"),
                            Name = "Neighbourhood "
                        },
                        new
                        {
                            Id = 23,
                            Guid = new Guid("d7e2f9f9-fd94-4f3e-9114-806850951820"),
                            Name = "Hiking"
                        },
                        new
                        {
                            Id = 24,
                            Guid = new Guid("9ca04a05-70ea-476b-9d68-367cc8b3ddce"),
                            Name = "Picnic"
                        },
                        new
                        {
                            Id = 25,
                            Guid = new Guid("dca131f5-b303-41f5-9cd7-fc6b8fbb6da5"),
                            Name = "Dog walking"
                        },
                        new
                        {
                            Id = 26,
                            Guid = new Guid("c079e38c-5d84-489c-a60d-416baead172a"),
                            Name = "Outdoor activities"
                        },
                        new
                        {
                            Id = 27,
                            Guid = new Guid("7706c5e7-15b9-4f9f-a437-5af6558c934a"),
                            Name = "Traveling abroad"
                        },
                        new
                        {
                            Id = 28,
                            Guid = new Guid("a0b8fd11-a255-43b1-9e01-f26772641e0e"),
                            Name = "Camping"
                        });
                });

            modelBuilder.Entity("Native.Domain.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Residences");
                });

            modelBuilder.Entity("Native.Domain.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BirthDayDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Introduction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Native.Domain.Models.ProfileCity", b =>
                {
                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("CityCountryIsoCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CityPostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsProfileNativeToTheCity")
                        .HasColumnType("bit");

                    b.HasKey("ProfileId", "CityId");

                    b.HasIndex("CityCountryIsoCode", "CityPostalCode");

                    b.ToTable("ProfileCity");
                });

            modelBuilder.Entity("Native.Domain.Models.ProfileEvent", b =>
                {
                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("InvitedById")
                        .HasColumnType("int");

                    b.Property<int>("StatusOfAppearance")
                        .HasColumnType("int");

                    b.HasKey("ProfileId", "EventId");

                    b.HasIndex("EventId");

                    b.HasIndex("InvitedById");

                    b.ToTable("ProfileEvents");
                });

            modelBuilder.Entity("Native.Domain.Models.ProfileVenue", b =>
                {
                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int>("VenueId")
                        .HasColumnType("int");

                    b.Property<bool>("ProfileDownvoted")
                        .HasColumnType("bit");

                    b.Property<bool>("ProfileUpvoted")
                        .HasColumnType("bit");

                    b.HasKey("ProfileId", "VenueId");

                    b.HasIndex("VenueId");

                    b.ToTable("ProfileVenues");
                });

            modelBuilder.Entity("Native.Domain.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("ProfileId");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Native.Domain.Models.Venue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<TimeSpan>("ClosingTime")
                        .HasColumnType("time");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("OpeningTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("Venues");
                });

            modelBuilder.Entity("EventInterest", b =>
                {
                    b.HasOne("Native.Domain.Models.Event", null)
                        .WithMany()
                        .HasForeignKey("EventsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Native.Domain.Models.Interest", null)
                        .WithMany()
                        .HasForeignKey("InterestsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InterestProfile", b =>
                {
                    b.HasOne("Native.Domain.Models.Interest", null)
                        .WithMany()
                        .HasForeignKey("InterestsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Native.Domain.Models.Profile", null)
                        .WithMany()
                        .HasForeignKey("ProfilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InterestVenue", b =>
                {
                    b.HasOne("Native.Domain.Models.Interest", null)
                        .WithMany()
                        .HasForeignKey("InterestsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Native.Domain.Models.Venue", null)
                        .WithMany()
                        .HasForeignKey("VenuesId")
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
                    b.HasOne("Native.Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Native.Domain.Models.User", null)
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

                    b.HasOne("Native.Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Native.Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Native.Domain.Models.City", b =>
                {
                    b.HasOne("Native.Domain.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Native.Domain.Models.Event", b =>
                {
                    b.HasOne("Native.Domain.Models.Profile", "Organiser")
                        .WithMany()
                        .HasForeignKey("OrganiserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Native.Domain.Models.Location", "Residence")
                        .WithMany()
                        .HasForeignKey("ResidenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organiser");

                    b.Navigation("Residence");
                });

            modelBuilder.Entity("Native.Domain.Models.ProfileCity", b =>
                {
                    b.HasOne("Native.Domain.Models.Profile", "Profile")
                        .WithMany("CitiesThatTheProfileVisited")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Native.Domain.Models.City", "City")
                        .WithMany("ProfilesWhichVisitedTheCity")
                        .HasForeignKey("CityCountryIsoCode", "CityPostalCode")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Native.Domain.Models.ProfileEvent", b =>
                {
                    b.HasOne("Native.Domain.Models.Event", "Event")
                        .WithMany("InvitedGuests")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Native.Domain.Models.Profile", "InvitedBy")
                        .WithMany()
                        .HasForeignKey("InvitedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Native.Domain.Models.Profile", "Profile")
                        .WithMany("ProfileEvents")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("InvitedBy");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Native.Domain.Models.ProfileVenue", b =>
                {
                    b.HasOne("Native.Domain.Models.Profile", "Profile")
                        .WithMany("VisitedVenues")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Native.Domain.Models.Venue", "Venue")
                        .WithMany("ProfilesThatVisitedVenue")
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Profile");

                    b.Navigation("Venue");
                });

            modelBuilder.Entity("Native.Domain.Models.User", b =>
                {
                    b.HasOne("Native.Domain.Models.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Native.Domain.Models.City", b =>
                {
                    b.Navigation("ProfilesWhichVisitedTheCity");
                });

            modelBuilder.Entity("Native.Domain.Models.Event", b =>
                {
                    b.Navigation("InvitedGuests");
                });

            modelBuilder.Entity("Native.Domain.Models.Profile", b =>
                {
                    b.Navigation("CitiesThatTheProfileVisited");

                    b.Navigation("ProfileEvents");

                    b.Navigation("VisitedVenues");
                });

            modelBuilder.Entity("Native.Domain.Models.Venue", b =>
                {
                    b.Navigation("ProfilesThatVisitedVenue");
                });
#pragma warning restore 612, 618
        }
    }
}
