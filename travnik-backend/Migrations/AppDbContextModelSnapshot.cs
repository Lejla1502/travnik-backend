﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using travnik_backend.Models;

#nullable disable

namespace travnik_backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AccomodationRoomNameRoomFeatures", b =>
                {
                    b.Property<int>("AccomodationRoomNamesId")
                        .HasColumnType("int");

                    b.Property<int>("RoomFeaturesId")
                        .HasColumnType("int");

                    b.HasKey("AccomodationRoomNamesId", "RoomFeaturesId");

                    b.HasIndex("RoomFeaturesId");

                    b.ToTable("AccomodationRoomNameRoomFeatures");
                });

            modelBuilder.Entity("AccomodationRoomNameTopLevelFeatures", b =>
                {
                    b.Property<int>("AccomodationRoomNamesId")
                        .HasColumnType("int");

                    b.Property<int>("TopLevelFeaturesId")
                        .HasColumnType("int");

                    b.HasKey("AccomodationRoomNamesId", "TopLevelFeaturesId");

                    b.HasIndex("TopLevelFeaturesId");

                    b.ToTable("AccomodationRoomNameTopLevelFeatures");
                });

            modelBuilder.Entity("AccomodationTypeListing", b =>
                {
                    b.Property<int>("AccomodationTypesId")
                        .HasColumnType("int");

                    b.Property<int>("ListingId")
                        .HasColumnType("int");

                    b.HasKey("AccomodationTypesId", "ListingId");

                    b.HasIndex("ListingId");

                    b.ToTable("AccomodationTypeListing");
                });

            modelBuilder.Entity("ActivitiesAttraction", b =>
                {
                    b.Property<int>("ActivitiesId")
                        .HasColumnType("int");

                    b.Property<int>("AttractionsId")
                        .HasColumnType("int");

                    b.HasKey("ActivitiesId", "AttractionsId");

                    b.HasIndex("AttractionsId");

                    b.ToTable("ActivitiesAttraction");
                });

            modelBuilder.Entity("ListingListingType", b =>
                {
                    b.Property<int>("ListingTypesId")
                        .HasColumnType("int");

                    b.Property<int>("ListingsId")
                        .HasColumnType("int");

                    b.HasKey("ListingTypesId", "ListingsId");

                    b.HasIndex("ListingsId");

                    b.ToTable("ListingListingType");
                });

            modelBuilder.Entity("travnik_backend.Models.Accomodation.Accomodation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccomodationTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PricePerNight")
                        .HasColumnType("float");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TopLevelFeaturesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccomodationTypeId");

                    b.HasIndex("TopLevelFeaturesId");

                    b.ToTable("Accomodations");
                });

            modelBuilder.Entity("travnik_backend.Models.AccomodationRoomName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccomodationId")
                        .HasColumnType("int");

                    b.Property<bool>("BreakfastIncluded")
                        .HasColumnType("bit");

                    b.Property<int>("NumOfRoomsOfThisType")
                        .HasColumnType("int");

                    b.Property<bool>("PrepaymentNeeded")
                        .HasColumnType("bit");

                    b.Property<double>("PricePerNight")
                        .HasColumnType("float");

                    b.Property<int>("RoomNameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccomodationId");

                    b.HasIndex("RoomNameId");

                    b.ToTable("AccomodationRoomNames");
                });

            modelBuilder.Entity("travnik_backend.Models.AccomodationRoomNameBed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccomodationRoomNameId")
                        .HasColumnType("int");

                    b.Property<int>("BedId")
                        .HasColumnType("int");

                    b.Property<int>("NumOfBedsOfThisType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccomodationRoomNameId");

                    b.HasIndex("BedId");

                    b.ToTable("AccomodationRoomNameBeds");
                });

            modelBuilder.Entity("travnik_backend.Models.AccomodationType.AccomodationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccomodationTypes");
                });

            modelBuilder.Entity("travnik_backend.Models.Activities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("travnik_backend.Models.Attraction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Season")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Attractions");
                });

            modelBuilder.Entity("travnik_backend.Models.Bed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Beds");
                });

            modelBuilder.Entity("travnik_backend.Models.Event.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ActivitiesId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfEvent")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Fee")
                        .HasColumnType("float");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizerId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ActivitiesId");

                    b.HasIndex("OrganizerId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("travnik_backend.Models.Listing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Listings");
                });

            modelBuilder.Entity("travnik_backend.Models.ListingType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ListingTypes");
                });

            modelBuilder.Entity("travnik_backend.Models.News.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("travnik_backend.Models.Organizer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Organizers");
                });

            modelBuilder.Entity("travnik_backend.Models.RoomFeatures", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoomFeatures");
                });

            modelBuilder.Entity("travnik_backend.Models.RoomName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("RoomNames");
                });

            modelBuilder.Entity("travnik_backend.Models.RoomNameDetails", b =>
                {
                    b.Property<int>("RoomNameDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomNameDetailsId"), 1L, 1);

                    b.Property<int>("NumOfBathrooms")
                        .HasColumnType("int");

                    b.Property<int>("NumOfBedrooms")
                        .HasColumnType("int");

                    b.Property<int>("NumOfGuests")
                        .HasColumnType("int");

                    b.Property<int>("NumOfLivingrooms")
                        .HasColumnType("int");

                    b.Property<int>("NumOfOtherSpaces")
                        .HasColumnType("int");

                    b.Property<int>("RoomNameId")
                        .HasColumnType("int");

                    b.HasKey("RoomNameDetailsId");

                    b.HasIndex("RoomNameId")
                        .IsUnique();

                    b.ToTable("RoomNameDetails");
                });

            modelBuilder.Entity("travnik_backend.Models.RoomsInRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GuestsInThisRoom")
                        .HasColumnType("int");

                    b.Property<string>("NameOfTheRoom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PrivateBathroom")
                        .HasColumnType("bit");

                    b.Property<int>("RoomNameDetailsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomNameDetailsId");

                    b.ToTable("RoomsInRoom");
                });

            modelBuilder.Entity("travnik_backend.Models.RoomsInRoomBeds", b =>
                {
                    b.Property<int>("RoomsInRoomId")
                        .HasColumnType("int");

                    b.Property<int>("BedId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfBeds")
                        .HasColumnType("int");

                    b.HasKey("RoomsInRoomId", "BedId");

                    b.HasIndex("BedId");

                    b.ToTable("RoomsInRoomBeds");
                });

            modelBuilder.Entity("travnik_backend.Models.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("travnik_backend.Models.RoomTypePackage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RoomTypePackages");
                });

            modelBuilder.Entity("travnik_backend.Models.TopLevelFeatures", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TopLevelFeatures");
                });

            modelBuilder.Entity("AccomodationRoomNameRoomFeatures", b =>
                {
                    b.HasOne("travnik_backend.Models.AccomodationRoomName", null)
                        .WithMany()
                        .HasForeignKey("AccomodationRoomNamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("travnik_backend.Models.RoomFeatures", null)
                        .WithMany()
                        .HasForeignKey("RoomFeaturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AccomodationRoomNameTopLevelFeatures", b =>
                {
                    b.HasOne("travnik_backend.Models.AccomodationRoomName", null)
                        .WithMany()
                        .HasForeignKey("AccomodationRoomNamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("travnik_backend.Models.TopLevelFeatures", null)
                        .WithMany()
                        .HasForeignKey("TopLevelFeaturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AccomodationTypeListing", b =>
                {
                    b.HasOne("travnik_backend.Models.AccomodationType.AccomodationType", null)
                        .WithMany()
                        .HasForeignKey("AccomodationTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("travnik_backend.Models.Listing", null)
                        .WithMany()
                        .HasForeignKey("ListingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ActivitiesAttraction", b =>
                {
                    b.HasOne("travnik_backend.Models.Activities", null)
                        .WithMany()
                        .HasForeignKey("ActivitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("travnik_backend.Models.Attraction", null)
                        .WithMany()
                        .HasForeignKey("AttractionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ListingListingType", b =>
                {
                    b.HasOne("travnik_backend.Models.ListingType", null)
                        .WithMany()
                        .HasForeignKey("ListingTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("travnik_backend.Models.Listing", null)
                        .WithMany()
                        .HasForeignKey("ListingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("travnik_backend.Models.Accomodation.Accomodation", b =>
                {
                    b.HasOne("travnik_backend.Models.AccomodationType.AccomodationType", "AccomodationType")
                        .WithMany("Accomodations")
                        .HasForeignKey("AccomodationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("travnik_backend.Models.TopLevelFeatures", null)
                        .WithMany("Accomodations")
                        .HasForeignKey("TopLevelFeaturesId");

                    b.Navigation("AccomodationType");
                });

            modelBuilder.Entity("travnik_backend.Models.AccomodationRoomName", b =>
                {
                    b.HasOne("travnik_backend.Models.Accomodation.Accomodation", "Accomodation")
                        .WithMany("AccomodationRoomNames")
                        .HasForeignKey("AccomodationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("travnik_backend.Models.RoomName", "RoomName")
                        .WithMany("AccomodationRoomNames")
                        .HasForeignKey("RoomNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accomodation");

                    b.Navigation("RoomName");
                });

            modelBuilder.Entity("travnik_backend.Models.AccomodationRoomNameBed", b =>
                {
                    b.HasOne("travnik_backend.Models.AccomodationRoomName", "AccomodationRoomName")
                        .WithMany("AccomodationRoomNameBeds")
                        .HasForeignKey("AccomodationRoomNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("travnik_backend.Models.Bed", "Bed")
                        .WithMany("AccomodationRoomNameBeds")
                        .HasForeignKey("BedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccomodationRoomName");

                    b.Navigation("Bed");
                });

            modelBuilder.Entity("travnik_backend.Models.Event.Event", b =>
                {
                    b.HasOne("travnik_backend.Models.Activities", "Activities")
                        .WithMany("Events")
                        .HasForeignKey("ActivitiesId");

                    b.HasOne("travnik_backend.Models.Organizer", "Organizer")
                        .WithMany("Events")
                        .HasForeignKey("OrganizerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activities");

                    b.Navigation("Organizer");
                });

            modelBuilder.Entity("travnik_backend.Models.RoomName", b =>
                {
                    b.HasOne("travnik_backend.Models.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("travnik_backend.Models.RoomNameDetails", b =>
                {
                    b.HasOne("travnik_backend.Models.RoomName", "RoomName")
                        .WithOne("RoomNameDetails")
                        .HasForeignKey("travnik_backend.Models.RoomNameDetails", "RoomNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomName");
                });

            modelBuilder.Entity("travnik_backend.Models.RoomsInRoom", b =>
                {
                    b.HasOne("travnik_backend.Models.RoomNameDetails", "RoomNameDetails")
                        .WithMany("RoomsInRooms")
                        .HasForeignKey("RoomNameDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomNameDetails");
                });

            modelBuilder.Entity("travnik_backend.Models.RoomsInRoomBeds", b =>
                {
                    b.HasOne("travnik_backend.Models.Bed", "Bed")
                        .WithMany("RoomsInRoomBeds")
                        .HasForeignKey("BedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("travnik_backend.Models.RoomsInRoom", "RoomsInRoom")
                        .WithMany("RoomsInRoomBeds")
                        .HasForeignKey("RoomsInRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bed");

                    b.Navigation("RoomsInRoom");
                });

            modelBuilder.Entity("travnik_backend.Models.Accomodation.Accomodation", b =>
                {
                    b.Navigation("AccomodationRoomNames");
                });

            modelBuilder.Entity("travnik_backend.Models.AccomodationRoomName", b =>
                {
                    b.Navigation("AccomodationRoomNameBeds");
                });

            modelBuilder.Entity("travnik_backend.Models.AccomodationType.AccomodationType", b =>
                {
                    b.Navigation("Accomodations");
                });

            modelBuilder.Entity("travnik_backend.Models.Activities", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("travnik_backend.Models.Bed", b =>
                {
                    b.Navigation("AccomodationRoomNameBeds");

                    b.Navigation("RoomsInRoomBeds");
                });

            modelBuilder.Entity("travnik_backend.Models.Organizer", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("travnik_backend.Models.RoomName", b =>
                {
                    b.Navigation("AccomodationRoomNames");

                    b.Navigation("RoomNameDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("travnik_backend.Models.RoomNameDetails", b =>
                {
                    b.Navigation("RoomsInRooms");
                });

            modelBuilder.Entity("travnik_backend.Models.RoomsInRoom", b =>
                {
                    b.Navigation("RoomsInRoomBeds");
                });

            modelBuilder.Entity("travnik_backend.Models.RoomType", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("travnik_backend.Models.TopLevelFeatures", b =>
                {
                    b.Navigation("Accomodations");
                });
#pragma warning restore 612, 618
        }
    }
}
