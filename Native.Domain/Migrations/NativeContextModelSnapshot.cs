﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Native.Domain.DataAccess;

#nullable disable

namespace Native.Domain.Migrations
{
    [DbContext(typeof(NativeContext))]
    partial class NativeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = "2a39cbf8-465d-424b-bf8e-b39d83d6f358",
                            Name = "user",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "29b15c02-6e79-4720-8e7d-4c3522f56222",
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
                            Guid = new Guid("c0070654-0e55-440e-b7c8-c3604478ee0f"),
                            Name = "Coffe & chat"
                        },
                        new
                        {
                            Id = 2,
                            Guid = new Guid("cebf3bce-1c1a-4566-87d1-3c6fd63aa19d"),
                            Name = "Walk & talk"
                        },
                        new
                        {
                            Id = 3,
                            Guid = new Guid("0ab0391f-46c0-4ea5-ae22-d43e01279f07"),
                            Name = "Networking"
                        },
                        new
                        {
                            Id = 4,
                            Guid = new Guid("7d87225f-241b-43d9-9d40-c58ff72a047e"),
                            Name = "Cinema"
                        },
                        new
                        {
                            Id = 5,
                            Guid = new Guid("23dc0c75-8840-4053-b3b8-39fc73e0aa2a"),
                            Name = "Theatre"
                        },
                        new
                        {
                            Id = 6,
                            Guid = new Guid("11654886-84a6-4ef6-a301-54d37a06ed60"),
                            Name = "Gigs & concerts"
                        },
                        new
                        {
                            Id = 7,
                            Guid = new Guid("764f03f7-df84-4986-a726-3d15a951e214"),
                            Name = "Shopping"
                        },
                        new
                        {
                            Id = 8,
                            Guid = new Guid("7b223912-4fe4-4ab9-90e2-78803620de65"),
                            Name = "Bowling"
                        },
                        new
                        {
                            Id = 9,
                            Guid = new Guid("5128fb3c-d594-4fff-ac9e-55481b4aa35a"),
                            Name = "Poker"
                        },
                        new
                        {
                            Id = 10,
                            Guid = new Guid("06183390-7657-4dfc-9100-e7dc457316f6"),
                            Name = "Karting"
                        },
                        new
                        {
                            Id = 11,
                            Guid = new Guid("e0ee8604-2c98-465b-ad4b-4f1c5fc6ac5e"),
                            Name = "Pub quiz"
                        },
                        new
                        {
                            Id = 12,
                            Guid = new Guid("ae200f55-9d11-4f70-b3b5-5d45843c1265"),
                            Name = "Dancing"
                        },
                        new
                        {
                            Id = 13,
                            Guid = new Guid("a17b3573-1b30-48cb-8f7f-82f4c7b34998"),
                            Name = "Languages"
                        },
                        new
                        {
                            Id = 14,
                            Guid = new Guid("99778031-a673-4cdc-9afc-7d6f12dd6062"),
                            Name = "Photography"
                        },
                        new
                        {
                            Id = 15,
                            Guid = new Guid("8aed6b4f-8ae6-487b-a197-61d795f5df96"),
                            Name = "Baking"
                        },
                        new
                        {
                            Id = 16,
                            Guid = new Guid("2685f46d-3d3b-4bdd-9750-7d45102fa180"),
                            Name = "Satrtups & enterpreneurship"
                        },
                        new
                        {
                            Id = 17,
                            Guid = new Guid("13ca60ea-258c-49bc-a600-d55c601953b8"),
                            Name = "Hollistic wellness"
                        },
                        new
                        {
                            Id = 18,
                            Guid = new Guid("35d318df-8be1-4033-8647-3a1b668872f8"),
                            Name = "Nutrition"
                        },
                        new
                        {
                            Id = 19,
                            Guid = new Guid("fabeed9f-854e-4738-9b5f-23e4a46d9744"),
                            Name = "Reading"
                        },
                        new
                        {
                            Id = 20,
                            Guid = new Guid("a3813dcb-d530-4f32-b417-e31b7279a587"),
                            Name = "Writing"
                        },
                        new
                        {
                            Id = 21,
                            Guid = new Guid("3f93bfb7-5243-4a77-a119-2346d6fca36b"),
                            Name = "Gardening"
                        },
                        new
                        {
                            Id = 22,
                            Guid = new Guid("128eb159-dc21-447b-8fe3-a15e03965304"),
                            Name = "Neighbourhood "
                        },
                        new
                        {
                            Id = 23,
                            Guid = new Guid("0eea84ab-b638-4589-94a9-1b5bfd96e2e0"),
                            Name = "Hiking"
                        },
                        new
                        {
                            Id = 24,
                            Guid = new Guid("ff39ac85-b3bc-4047-ad99-d30181081698"),
                            Name = "Picnic"
                        },
                        new
                        {
                            Id = 25,
                            Guid = new Guid("f3610984-0dff-41aa-9add-17cc8506f352"),
                            Name = "Dog walking"
                        },
                        new
                        {
                            Id = 26,
                            Guid = new Guid("f275505d-0263-4d4a-b2c5-d24d62bc8b8c"),
                            Name = "Outdoor activities"
                        },
                        new
                        {
                            Id = 27,
                            Guid = new Guid("392bfbe8-dc6c-4082-bcb2-e7c5786fafda"),
                            Name = "Traveling abroad"
                        },
                        new
                        {
                            Id = 28,
                            Guid = new Guid("3f3eee03-9e84-4bff-8bed-159a6f3ccac4"),
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

                    b.Property<string>("AppleUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
