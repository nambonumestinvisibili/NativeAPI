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
    [Migration("20230313223019_remove-apple")]
    partial class removeapple
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
                            Id = "1468f41b-4211-473c-bd0d-c81aa78a9ef7",
                            Name = "user",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "e60b4f72-6c9e-43c7-b411-f74ad52103ac",
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

                    b.Property<DateTime>("ClosingTime")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OpeningTime")
                        .HasColumnType("date");

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
                            Guid = new Guid("7f70501a-adf6-4bfc-b5cd-a9f977f13a3c"),
                            Name = "Coffe & chat"
                        },
                        new
                        {
                            Id = 2,
                            Guid = new Guid("1b075e76-b1f0-420c-99a1-0fb730c39eff"),
                            Name = "Walk & talk"
                        },
                        new
                        {
                            Id = 3,
                            Guid = new Guid("5e279aee-0be4-40e0-aa44-89e93dd598ab"),
                            Name = "Networking"
                        },
                        new
                        {
                            Id = 4,
                            Guid = new Guid("fa8bbd97-39be-4057-aad6-b0ef74de82cc"),
                            Name = "Cinema"
                        },
                        new
                        {
                            Id = 5,
                            Guid = new Guid("8aafaaf5-5079-4c7a-9434-8e75c5cfb5a7"),
                            Name = "Theatre"
                        },
                        new
                        {
                            Id = 6,
                            Guid = new Guid("79dd7cb4-c13d-4250-9ba9-219a4f8ac7ac"),
                            Name = "Gigs & concerts"
                        },
                        new
                        {
                            Id = 7,
                            Guid = new Guid("f86efedb-71f0-447f-959a-2ebac5bdf89b"),
                            Name = "Shopping"
                        },
                        new
                        {
                            Id = 8,
                            Guid = new Guid("0b931e7c-2cb4-44b3-ba26-78b1c1e56f81"),
                            Name = "Bowling"
                        },
                        new
                        {
                            Id = 9,
                            Guid = new Guid("5992e306-381e-4d47-8240-d0b23b22cbfd"),
                            Name = "Poker"
                        },
                        new
                        {
                            Id = 10,
                            Guid = new Guid("da136cdf-2366-4612-a780-36345e7a0934"),
                            Name = "Karting"
                        },
                        new
                        {
                            Id = 11,
                            Guid = new Guid("7364caa8-496c-4fb7-9e78-d20049971611"),
                            Name = "Pub quiz"
                        },
                        new
                        {
                            Id = 12,
                            Guid = new Guid("b403cbe4-39ba-4bcf-87c2-ac12f554f08c"),
                            Name = "Dancing"
                        },
                        new
                        {
                            Id = 13,
                            Guid = new Guid("d4131395-70d8-4383-a68d-df96d0b1eff5"),
                            Name = "Languages"
                        },
                        new
                        {
                            Id = 14,
                            Guid = new Guid("36131fe7-2666-4498-bf86-49865924db6e"),
                            Name = "Photography"
                        },
                        new
                        {
                            Id = 15,
                            Guid = new Guid("f404d1b9-5354-435f-8814-1bbd170a8ef6"),
                            Name = "Baking"
                        },
                        new
                        {
                            Id = 16,
                            Guid = new Guid("8dfd98df-7bd1-406b-9df7-8493c5fd7ea8"),
                            Name = "Satrtups & enterpreneurship"
                        },
                        new
                        {
                            Id = 17,
                            Guid = new Guid("3ea1b9b3-ee12-4b89-ba24-b954c4124017"),
                            Name = "Hollistic wellness"
                        },
                        new
                        {
                            Id = 18,
                            Guid = new Guid("873179de-2da0-4b26-ad20-073f0b06f13d"),
                            Name = "Nutrition"
                        },
                        new
                        {
                            Id = 19,
                            Guid = new Guid("30507392-e605-4095-ac2b-c94ffdaedc1f"),
                            Name = "Reading"
                        },
                        new
                        {
                            Id = 20,
                            Guid = new Guid("1e997506-7a15-43ab-8676-a83fb1c3147a"),
                            Name = "Writing"
                        },
                        new
                        {
                            Id = 21,
                            Guid = new Guid("1455648d-847f-4302-9dc8-07fffae79a48"),
                            Name = "Gardening"
                        },
                        new
                        {
                            Id = 22,
                            Guid = new Guid("bab7169a-a29a-4797-88e6-ed07ef9e8c95"),
                            Name = "Neighbourhood "
                        },
                        new
                        {
                            Id = 23,
                            Guid = new Guid("ed2c2149-e75c-4d59-8e10-6f2c19827022"),
                            Name = "Hiking"
                        },
                        new
                        {
                            Id = 24,
                            Guid = new Guid("0b62fd85-dc23-4628-a79f-4b061bcf7576"),
                            Name = "Picnic"
                        },
                        new
                        {
                            Id = 25,
                            Guid = new Guid("32a89890-e1f7-443f-a190-a27448f36557"),
                            Name = "Dog walking"
                        },
                        new
                        {
                            Id = 26,
                            Guid = new Guid("51a41961-3d68-4be6-95ed-eff43e411387"),
                            Name = "Outdoor activities"
                        },
                        new
                        {
                            Id = 27,
                            Guid = new Guid("75ff8115-dd6c-4d1e-960f-d024e4fad07b"),
                            Name = "Traveling abroad"
                        },
                        new
                        {
                            Id = 28,
                            Guid = new Guid("c75e532e-420b-432e-852a-76fa28a01fb5"),
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDayDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Introduction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .IsRequired()
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

                    b.Property<DateTime>("ClosingTime")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OpeningTime")
                        .HasColumnType("date");

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
