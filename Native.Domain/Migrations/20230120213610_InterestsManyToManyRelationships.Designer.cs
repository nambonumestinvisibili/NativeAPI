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
    [Migration("20230120213610_InterestsManyToManyRelationships")]
    partial class InterestsManyToManyRelationships
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
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
                            Guid = new Guid("39bb242e-4bfa-4c90-979b-f332826112f9"),
                            Name = "Coffe & chat"
                        },
                        new
                        {
                            Id = 2,
                            Guid = new Guid("d9ed22da-13a9-40aa-9ab2-b72aa9933237"),
                            Name = "Walk & talk"
                        },
                        new
                        {
                            Id = 3,
                            Guid = new Guid("c4890aa6-de61-4b04-b488-c9c589653b86"),
                            Name = "Networking"
                        },
                        new
                        {
                            Id = 4,
                            Guid = new Guid("0e3a2ccd-7d11-4c17-8b76-1f2aa1c20b67"),
                            Name = "Cinema"
                        },
                        new
                        {
                            Id = 5,
                            Guid = new Guid("250fcfdc-28ab-4507-a4e3-355bb5900379"),
                            Name = "Theatre"
                        },
                        new
                        {
                            Id = 6,
                            Guid = new Guid("6efa59d7-8247-4afd-9ab9-c53e18f8bd40"),
                            Name = "Gigs & concerts"
                        },
                        new
                        {
                            Id = 7,
                            Guid = new Guid("f45bda88-42d9-4387-a129-4842cd256796"),
                            Name = "Shopping"
                        },
                        new
                        {
                            Id = 8,
                            Guid = new Guid("b062067f-4b85-4cf4-8e26-8db74af9b623"),
                            Name = "Bowling"
                        },
                        new
                        {
                            Id = 9,
                            Guid = new Guid("669e7f37-99bd-4492-8667-3dca251c0e93"),
                            Name = "Poker"
                        },
                        new
                        {
                            Id = 10,
                            Guid = new Guid("f711ef89-7817-408a-8846-8f3e42e83c2b"),
                            Name = "Karting"
                        },
                        new
                        {
                            Id = 11,
                            Guid = new Guid("8b30f25d-8edb-46f7-99c3-205f767435b2"),
                            Name = "Pub quiz"
                        },
                        new
                        {
                            Id = 12,
                            Guid = new Guid("df21ec23-b4eb-480e-9832-2d5d27bd38ed"),
                            Name = "Dancing"
                        },
                        new
                        {
                            Id = 13,
                            Guid = new Guid("3fd201ef-58fa-41cc-b3a5-09f4163d19e0"),
                            Name = "Languages"
                        },
                        new
                        {
                            Id = 14,
                            Guid = new Guid("d51ab234-2c7f-4383-b8ad-8fcb58c7a934"),
                            Name = "Photography"
                        },
                        new
                        {
                            Id = 15,
                            Guid = new Guid("201aca2c-a441-42af-a0db-c60111b1a075"),
                            Name = "Baking"
                        },
                        new
                        {
                            Id = 16,
                            Guid = new Guid("2a755c6e-92fa-4274-8d41-44cc0ede8a4d"),
                            Name = "Satrtups & enterpreneurship"
                        },
                        new
                        {
                            Id = 17,
                            Guid = new Guid("6258eb7d-2659-4a0c-8f4b-d8b9a6950a8e"),
                            Name = "Hollistic wellness"
                        },
                        new
                        {
                            Id = 18,
                            Guid = new Guid("b55de903-cad0-41b8-8e47-f6ef6800d8dc"),
                            Name = "Nutrition"
                        },
                        new
                        {
                            Id = 19,
                            Guid = new Guid("d8a260f9-e175-40af-bfbd-627d54e467b6"),
                            Name = "Reading"
                        },
                        new
                        {
                            Id = 20,
                            Guid = new Guid("e4f109b9-cb0d-4249-83c7-dd8105537c79"),
                            Name = "Writing"
                        },
                        new
                        {
                            Id = 21,
                            Guid = new Guid("bd47b816-0f80-4ad3-8802-4cb19b731618"),
                            Name = "Gardening"
                        },
                        new
                        {
                            Id = 22,
                            Guid = new Guid("a33dbc9b-411b-4374-97f5-6bf06df69c0f"),
                            Name = "Neighbourhood "
                        },
                        new
                        {
                            Id = 23,
                            Guid = new Guid("ca52695b-8eeb-4550-a9be-284b2a3ece85"),
                            Name = "Hiking"
                        },
                        new
                        {
                            Id = 24,
                            Guid = new Guid("0fc50f00-5713-475f-a22b-731d194819e6"),
                            Name = "Picnic"
                        },
                        new
                        {
                            Id = 25,
                            Guid = new Guid("57c98ea7-36b2-4bfc-abf2-025c4eef538e"),
                            Name = "Dog walking"
                        },
                        new
                        {
                            Id = 26,
                            Guid = new Guid("8924b8a5-7e19-4375-8c18-d5bc47e71e55"),
                            Name = "Outdoor activities"
                        },
                        new
                        {
                            Id = 27,
                            Guid = new Guid("779d8b8d-91b1-4369-b8bc-bd0adf30cea6"),
                            Name = "Traveling abroad"
                        },
                        new
                        {
                            Id = 28,
                            Guid = new Guid("b7751e79-c313-47f7-8dab-c1b6276b60ae"),
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

                    b.Property<int?>("ProfileId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

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

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Introduction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profiles");
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
                    b.HasOne("Native.Domain.Models.Profile", null)
                        .WithMany("Residences")
                        .HasForeignKey("ProfileId");
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

            modelBuilder.Entity("Native.Domain.Models.Event", b =>
                {
                    b.Navigation("InvitedGuests");
                });

            modelBuilder.Entity("Native.Domain.Models.Profile", b =>
                {
                    b.Navigation("ProfileEvents");

                    b.Navigation("Residences");

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