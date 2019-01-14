﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using travoul.Data;

namespace travoul.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190108021712_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("travoul.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new { Id = "c95a6a90-19a1-4ccd-b028-9776d91eb991", AccessFailedCount = 0, City = "Nashville", ConcurrencyStamp = "95a55c12-e1ec-4529-9215-8286d6a64458", Email = "kayla@kayla.com", EmailConfirmed = true, FirstName = "Kayla", LastName = "Reid", LockoutEnabled = false, NormalizedEmail = "KAYLA@KAYLA.COM", NormalizedUserName = "KAYLA@KAYLA.COM", PasswordHash = "AQAAAAEAACcQAAAAEKHNVJaXO1l3fvMIn7qERtK8LUTuGHd0l4bTzXQQ9MefhNM/+b55r+zfY7yjMKUzRw==", PhoneNumberConfirmed = false, SecurityStamp = "684a060d-cb5b-4836-9695-716e77ac8a2b", State = "TN", TwoFactorEnabled = false, UserName = "kayla@kayla.com" },
                        new { Id = "2afae0c5-52dc-4524-acee-7e9dc85d4995", AccessFailedCount = 0, City = "Nashville", ConcurrencyStamp = "0c13c6b9-b09d-4da2-b326-83e9c464a8c0", Email = "ricky@ricky.com", EmailConfirmed = true, FirstName = "Ricky", LastName = "Bruner", LockoutEnabled = false, NormalizedEmail = "RICKY@RICKY.COM", NormalizedUserName = "RICKY@RICKY.COM", PasswordHash = "AQAAAAEAACcQAAAAELS0WBJo5AG8Jz3dxTdbZHkNmaW0gD+5PF/hzo5zWhrmGaA0K25zR02fVrzRMz3o7Q==", PhoneNumberConfirmed = false, SecurityStamp = "9894671a-a56a-49da-b3ee-38a7be301d36", State = "TN", TwoFactorEnabled = false, UserName = "ricky@ricky.com" }
                    );
                });

            modelBuilder.Entity("travoul.Models.Continent", b =>
                {
                    b.Property<int>("ContinentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ContinentId");

                    b.ToTable("Continent");

                    b.HasData(
                        new { ContinentId = 1, Code = "AF", Name = "Africa" },
                        new { ContinentId = 2, Code = "AN", Name = "Antarctica" },
                        new { ContinentId = 3, Code = "AS", Name = "Asia" },
                        new { ContinentId = 4, Code = "EU", Name = "Europe" },
                        new { ContinentId = 5, Code = "NA", Name = "North America" },
                        new { ContinentId = 6, Code = "OC", Name = "Oceania" },
                        new { ContinentId = 7, Code = "SA", Name = "South America" }
                    );
                });

            modelBuilder.Entity("travoul.Models.LocationType", b =>
                {
                    b.Property<int>("LocationTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("LocationTypeId");

                    b.ToTable("LocationType");

                    b.HasData(
                        new { LocationTypeId = 1, Type = "Food" },
                        new { LocationTypeId = 2, Type = "Place" }
                    );
                });

            modelBuilder.Entity("travoul.Models.RetroType", b =>
                {
                    b.Property<int>("RetroTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("RetroTypeId");

                    b.ToTable("RetroType");

                    b.HasData(
                        new { RetroTypeId = 1, Type = "Do Again" },
                        new { RetroTypeId = 2, Type = "Do Different" }
                    );
                });

            modelBuilder.Entity("travoul.Models.TravelType", b =>
                {
                    b.Property<int>("TravelTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("TravelTypeId");

                    b.ToTable("TravelType");

                    b.HasData(
                        new { TravelTypeId = 1, Type = "Bus" },
                        new { TravelTypeId = 2, Type = "Plane" },
                        new { TravelTypeId = 3, Type = "Car" },
                        new { TravelTypeId = 4, Type = "Ride Share" },
                        new { TravelTypeId = 5, Type = "Train" },
                        new { TravelTypeId = 6, Type = "Shuttle" },
                        new { TravelTypeId = 7, Type = "Boat" },
                        new { TravelTypeId = 8, Type = "Public Transport" }
                    );
                });

            modelBuilder.Entity("travoul.Models.Trip", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Accommodation")
                        .IsRequired();

                    b.Property<double?>("Budget");

                    b.Property<int>("ContinentId");

                    b.Property<DateTime>("DateFinished");

                    b.Property<string>("ImagePath");

                    b.Property<bool>("IsPreTrip");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("TripDates")
                        .IsRequired();

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("TripId");

                    b.HasIndex("ContinentId");

                    b.HasIndex("UserId");

                    b.ToTable("Trip");

                    b.HasData(
                        new { TripId = 1, Accommodation = "Cabana Bay", ContinentId = 5, DateFinished = new DateTime(2019, 1, 7, 20, 17, 11, 125, DateTimeKind.Local), ImagePath = "https://scontent.fbna1-1.fna.fbcdn.net/v/t31.0-8/19221504_10156323805382729_8735263925981311453_o.jpg?_nc_cat=111&_nc_ht=scontent.fbna1-1.fna&oh=27f178631784a8d9e88e2b7a117e8948&oe=5CC3F599", IsPreTrip = false, Location = "Orlando Florida", Title = "1st Harry Potter World Trip", TripDates = "5/20/17-5/26/17", UserId = "c95a6a90-19a1-4ccd-b028-9776d91eb991" },
                        new { TripId = 2, Accommodation = "Campus", Budget = 2000.0, ContinentId = 1, DateFinished = new DateTime(2019, 1, 7, 20, 17, 11, 128, DateTimeKind.Local), ImagePath = "https://images.unsplash.com/photo-1516026672322-bc52d61a55d5?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=500&q=60", IsPreTrip = false, Location = "Uganda", Title = "Mission Trip", TripDates = "2010", UserId = "c95a6a90-19a1-4ccd-b028-9776d91eb991" },
                        new { TripId = 3, Accommodation = "Cabana Bay", ContinentId = 5, DateFinished = new DateTime(2019, 1, 7, 20, 17, 11, 128, DateTimeKind.Local), ImagePath = "https://scontent.fbna1-1.fna.fbcdn.net/v/t31.0-8/19221723_10156323925257729_6632941831644369725_o.jpg?_nc_cat=108&_nc_ht=scontent.fbna1-1.fna&oh=25026fc7793a7dea17da4116d35de668&oe=5CC052A1", IsPreTrip = false, Location = "Orlando Flordia", Title = "1st Harry Potter World Trip/Engagement Trip", TripDates = "5/20/17-5/26/17", UserId = "2afae0c5-52dc-4524-acee-7e9dc85d4995" },
                        new { TripId = 4, Accommodation = "Airbnb", ContinentId = 5, DateFinished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), IsPreTrip = true, Location = "Portland OR", Title = "Visit H & T Trip", TripDates = "2019", UserId = "2afae0c5-52dc-4524-acee-7e9dc85d4995" }
                    );
                });

            modelBuilder.Entity("travoul.Models.TripRetro", b =>
                {
                    b.Property<int>("TripRetroId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("RetroTypeId");

                    b.Property<int>("TripId");

                    b.HasKey("TripRetroId");

                    b.HasIndex("RetroTypeId");

                    b.HasIndex("TripId");

                    b.ToTable("TripRetro");

                    b.HasData(
                        new { TripRetroId = 1, Description = "It was sooooo amazing!!!!", RetroTypeId = 1, TripId = 1 },
                        new { TripRetroId = 2, Description = "It was Hot!!!!", RetroTypeId = 2, TripId = 1 },
                        new { TripRetroId = 3, Description = "It was sooooo amazing!!!!", RetroTypeId = 1, TripId = 2 },
                        new { TripRetroId = 4, Description = "It was Hot!!!!", RetroTypeId = 2, TripId = 2 },
                        new { TripRetroId = 5, Description = "It was sooooo amazing!!!!", RetroTypeId = 1, TripId = 3 },
                        new { TripRetroId = 6, Description = "It was Hot!!!!", RetroTypeId = 2, TripId = 3 }
                    );
                });

            modelBuilder.Entity("travoul.Models.TripTravelType", b =>
                {
                    b.Property<int>("TripTravelTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TravelTypeId");

                    b.Property<int>("TripId");

                    b.HasKey("TripTravelTypeId");

                    b.HasIndex("TravelTypeId");

                    b.HasIndex("TripId");

                    b.ToTable("TripTravelType");

                    b.HasData(
                        new { TripTravelTypeId = 1, TravelTypeId = 2, TripId = 1 },
                        new { TripTravelTypeId = 2, TravelTypeId = 4, TripId = 1 },
                        new { TripTravelTypeId = 3, TravelTypeId = 2, TripId = 2 },
                        new { TripTravelTypeId = 4, TravelTypeId = 8, TripId = 2 },
                        new { TripTravelTypeId = 5, TravelTypeId = 2, TripId = 3 },
                        new { TripTravelTypeId = 6, TravelTypeId = 4, TripId = 3 },
                        new { TripTravelTypeId = 7, TravelTypeId = 2, TripId = 4 },
                        new { TripTravelTypeId = 8, TravelTypeId = 3, TripId = 4 }
                    );
                });

            modelBuilder.Entity("travoul.Models.TripVisitLocation", b =>
                {
                    b.Property<int>("TripVisitLocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<bool>("IsCompleted");

                    b.Property<int>("LocationTypeId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("TripId");

                    b.HasKey("TripVisitLocationId");

                    b.HasIndex("LocationTypeId");

                    b.HasIndex("TripId");

                    b.ToTable("TripVisitLocation");

                    b.HasData(
                        new { TripVisitLocationId = 1, Description = "Yummy food joint that sells butter beer", IsCompleted = true, LocationTypeId = 1, Name = "The three broomsticks", TripId = 1 },
                        new { TripVisitLocationId = 2, Description = "its sooo pretty", IsCompleted = true, LocationTypeId = 2, Name = "castle", TripId = 1 },
                        new { TripVisitLocationId = 3, Description = "See an elephant", IsCompleted = false, LocationTypeId = 2, Name = "Safari", TripId = 2 },
                        new { TripVisitLocationId = 4, Description = "They have the pink donut thing from the show", IsCompleted = false, LocationTypeId = 1, Name = "Donut Place", TripId = 1 },
                        new { TripVisitLocationId = 5, Description = "Yummy food joint that sells butter beer", IsCompleted = true, LocationTypeId = 1, Name = "The three broomsticks", TripId = 3 },
                        new { TripVisitLocationId = 6, Description = "Its soooo pretty", IsCompleted = true, LocationTypeId = 2, Name = "HP world", TripId = 3 },
                        new { TripVisitLocationId = 7, Description = "they have awesome stuff", IsCompleted = false, LocationTypeId = 2, Name = "flee market", TripId = 4 },
                        new { TripVisitLocationId = 8, Description = "can't wait to see their cute place", IsCompleted = false, LocationTypeId = 2, Name = "H and T's house", TripId = 4 }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("travoul.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("travoul.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("travoul.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("travoul.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("travoul.Models.Trip", b =>
                {
                    b.HasOne("travoul.Models.Continent", "Continent")
                        .WithMany("Trips")
                        .HasForeignKey("ContinentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("travoul.Models.ApplicationUser", "User")
                        .WithMany("UserTrips")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("travoul.Models.TripRetro", b =>
                {
                    b.HasOne("travoul.Models.RetroType", "RetroType")
                        .WithMany("TripRetros")
                        .HasForeignKey("RetroTypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("travoul.Models.Trip", "Trip")
                        .WithMany("TripRetros")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("travoul.Models.TripTravelType", b =>
                {
                    b.HasOne("travoul.Models.TravelType", "TravelType")
                        .WithMany("TripTravelTypes")
                        .HasForeignKey("TravelTypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("travoul.Models.Trip", "Trip")
                        .WithMany("TripTravelTypes")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("travoul.Models.TripVisitLocation", b =>
                {
                    b.HasOne("travoul.Models.LocationType", "LocationType")
                        .WithMany("TripVisitLocations")
                        .HasForeignKey("LocationTypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("travoul.Models.Trip", "Trip")
                        .WithMany("TripVisitLocations")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
