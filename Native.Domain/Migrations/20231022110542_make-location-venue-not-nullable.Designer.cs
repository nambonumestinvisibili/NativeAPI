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
    [Migration("20231022110542_make-location-venue-not-nullable")]
    partial class makelocationvenuenotnullable
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
                            Id = "5c644872-0e02-4f12-944f-96b77f4c4aea",
                            Name = "user",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "3e02a697-1a84-44e4-8a9e-2bb5aacd7305",
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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryIsoCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

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
                            Guid = new Guid("b13f7d6e-2435-472b-969e-47b1bbb58b0d"),
                            Name = "Coffe & chat"
                        },
                        new
                        {
                            Id = 2,
                            Guid = new Guid("40c64612-66de-4fd9-bccb-e86ddd2ef877"),
                            Name = "Walk & talk"
                        },
                        new
                        {
                            Id = 3,
                            Guid = new Guid("f0693396-cadb-4d59-a604-a531ba21cb81"),
                            Name = "Networking"
                        },
                        new
                        {
                            Id = 4,
                            Guid = new Guid("0159b701-86b9-4751-88d1-2591e9a57d3b"),
                            Name = "Cinema"
                        },
                        new
                        {
                            Id = 5,
                            Guid = new Guid("6b19d517-4057-451f-b4ff-1af0d1049e59"),
                            Name = "Theatre"
                        },
                        new
                        {
                            Id = 6,
                            Guid = new Guid("929e5d14-0d89-4019-9f2e-d7ebf637de71"),
                            Name = "Gigs & concerts"
                        },
                        new
                        {
                            Id = 7,
                            Guid = new Guid("ff649278-5cd8-49ef-98d4-569bc3e822c9"),
                            Name = "Shopping"
                        },
                        new
                        {
                            Id = 8,
                            Guid = new Guid("a0f08a2b-2988-4f40-910e-dfe483925eff"),
                            Name = "Bowling"
                        },
                        new
                        {
                            Id = 9,
                            Guid = new Guid("e88596d6-0412-425f-9057-e36020caa266"),
                            Name = "Poker"
                        },
                        new
                        {
                            Id = 10,
                            Guid = new Guid("28417611-1a60-4216-8f60-b5eee5c3bd9e"),
                            Name = "Karting"
                        },
                        new
                        {
                            Id = 11,
                            Guid = new Guid("65e8959b-7c79-46ba-8df8-64d3ac6cf659"),
                            Name = "Pub quiz"
                        },
                        new
                        {
                            Id = 12,
                            Guid = new Guid("f0f303b9-9658-4649-a648-8f2472c6244c"),
                            Name = "Dancing"
                        },
                        new
                        {
                            Id = 13,
                            Guid = new Guid("3a3c0284-0eef-4dbc-b098-3eeb8aa9ec2d"),
                            Name = "Languages"
                        },
                        new
                        {
                            Id = 14,
                            Guid = new Guid("38a5f1c9-fad7-4db4-b3ef-8d729c2d201b"),
                            Name = "Photography"
                        },
                        new
                        {
                            Id = 15,
                            Guid = new Guid("341aebbb-78ed-4b17-a494-955178f50e6b"),
                            Name = "Baking"
                        },
                        new
                        {
                            Id = 16,
                            Guid = new Guid("33e6a11e-e2e7-4e02-80e9-ff89d683404e"),
                            Name = "Satrtups & enterpreneurship"
                        },
                        new
                        {
                            Id = 17,
                            Guid = new Guid("946da87f-b016-44f1-84ea-b0a3ee9308c4"),
                            Name = "Hollistic wellness"
                        },
                        new
                        {
                            Id = 18,
                            Guid = new Guid("c2ea845d-410a-44a1-9194-dd3686faa189"),
                            Name = "Nutrition"
                        },
                        new
                        {
                            Id = 19,
                            Guid = new Guid("d8b1cc1a-c3de-40ee-a98e-098c355b7b0b"),
                            Name = "Reading"
                        },
                        new
                        {
                            Id = 20,
                            Guid = new Guid("058732ca-6034-4798-8085-315441c48d7e"),
                            Name = "Writing"
                        },
                        new
                        {
                            Id = 21,
                            Guid = new Guid("dec8ecec-5052-4eb0-ab73-d3be45c8ffe5"),
                            Name = "Gardening"
                        },
                        new
                        {
                            Id = 22,
                            Guid = new Guid("c3dd2a51-ccf3-44bd-afd4-146c62b433a2"),
                            Name = "Neighbourhood"
                        },
                        new
                        {
                            Id = 23,
                            Guid = new Guid("72b5275f-1df8-4dad-a143-c579f9efce1d"),
                            Name = "Hiking"
                        },
                        new
                        {
                            Id = 24,
                            Guid = new Guid("93d772b0-5896-420c-b252-8555dbc8af97"),
                            Name = "Picnic"
                        },
                        new
                        {
                            Id = 25,
                            Guid = new Guid("179609c7-91f8-466f-9bd6-cf0890039817"),
                            Name = "Dog walking"
                        },
                        new
                        {
                            Id = 26,
                            Guid = new Guid("7e57df2b-57d3-4861-bde8-62a23240fa48"),
                            Name = "Outdoor activities"
                        },
                        new
                        {
                            Id = 27,
                            Guid = new Guid("efd19caf-5528-454b-99b2-cc9773a00340"),
                            Name = "Traveling abroad"
                        },
                        new
                        {
                            Id = 28,
                            Guid = new Guid("f71ab1ab-4d2b-4d6e-924e-40c493c6a8d8"),
                            Name = "Camping"
                        });
                });

            modelBuilder.Entity("Native.Domain.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Location");
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

                    b.Property<bool>("IsProfileNativeToTheCity")
                        .HasColumnType("bit");

                    b.HasKey("ProfileId", "CityId");

                    b.HasIndex("CityId");

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

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("OpeningTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

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

            modelBuilder.Entity("Native.Domain.Models.Location", b =>
                {
                    b.HasOne("Native.Domain.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Native.Domain.Models.ProfileCity", b =>
                {
                    b.HasOne("Native.Domain.Models.City", "City")
                        .WithMany("ProfilesWhichVisitedTheCity")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Native.Domain.Models.Profile", "Profile")
                        .WithMany("CitiesThatTheProfileVisited")
                        .HasForeignKey("ProfileId")
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

            modelBuilder.Entity("Native.Domain.Models.Venue", b =>
                {
                    b.HasOne("Native.Domain.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
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
