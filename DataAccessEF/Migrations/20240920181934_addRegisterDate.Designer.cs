﻿// <auto-generated />
using System;
using DataAccessEF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccessEF.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240920181934_addRegisterDate")]
    partial class addRegisterDate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Models.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ProfileId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Domain.Models.DislikedUsers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserDislikedId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("DislikedUsers");
                });

            modelBuilder.Entity("Domain.Models.Interest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ProfileId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Interests");
                });

            modelBuilder.Entity("Domain.Models.LikedBy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("LikedByUserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("LikedBies");
                });

            modelBuilder.Entity("Domain.Models.Musican", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ProfileId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Musicans");
                });

            modelBuilder.Entity("Domain.Models.PersonalTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ProfileId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("PersonalTags");
                });

            modelBuilder.Entity("Domain.Models.Profile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AboutMe")
                        .HasColumnType("text");

                    b.Property<string>("DatingPurpose")
                        .HasColumnType("text");

                    b.Property<string>("Education")
                        .HasColumnType("text");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("boolean");

                    b.Property<string>("Work")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Domain.Models.ProfileMedia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("MediaType")
                        .HasColumnType("integer");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uuid");

                    b.Property<string>("StrorageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("ProfileMedias");
                });

            modelBuilder.Entity("Domain.Models.SearchSetting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<int>("MaxAge")
                        .HasColumnType("integer");

                    b.Property<int>("MinAge")
                        .HasColumnType("integer");

                    b.Property<int>("Radius")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("SearchSettings");
                });

            modelBuilder.Entity("Domain.Models.TVMedia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ProfileId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("TVMedias");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("ProfileId")
                        .HasColumnType("uuid");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("RegisterDate")
                        .HasColumnType("date");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<Guid?>("SearchSettingId")
                        .HasColumnType("uuid");

                    b.Property<int>("Sex")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("text");

                    b.Property<DateTime>("TokenCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("TokenExpires")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.HasIndex("SearchSettingId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Models.Book", b =>
                {
                    b.HasOne("Domain.Models.Profile", null)
                        .WithMany("Books")
                        .HasForeignKey("ProfileId");
                });

            modelBuilder.Entity("Domain.Models.DislikedUsers", b =>
                {
                    b.HasOne("Domain.Models.User", null)
                        .WithMany("DislikedUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Interest", b =>
                {
                    b.HasOne("Domain.Models.Profile", null)
                        .WithMany("Interests")
                        .HasForeignKey("ProfileId");
                });

            modelBuilder.Entity("Domain.Models.LikedBy", b =>
                {
                    b.HasOne("Domain.Models.User", null)
                        .WithMany("LikedUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Musican", b =>
                {
                    b.HasOne("Domain.Models.Profile", null)
                        .WithMany("Musicans")
                        .HasForeignKey("ProfileId");
                });

            modelBuilder.Entity("Domain.Models.PersonalTag", b =>
                {
                    b.HasOne("Domain.Models.Profile", null)
                        .WithMany("PersonalTags")
                        .HasForeignKey("ProfileId");
                });

            modelBuilder.Entity("Domain.Models.ProfileMedia", b =>
                {
                    b.HasOne("Domain.Models.Profile", "Profile")
                        .WithMany("ProfileMedias")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Domain.Models.TVMedia", b =>
                {
                    b.HasOne("Domain.Models.Profile", null)
                        .WithMany("TVMedias")
                        .HasForeignKey("ProfileId");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.HasOne("Domain.Models.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId");

                    b.HasOne("Domain.Models.SearchSetting", "SearchSetting")
                        .WithMany()
                        .HasForeignKey("SearchSettingId");

                    b.Navigation("Profile");

                    b.Navigation("SearchSetting");
                });

            modelBuilder.Entity("Domain.Models.Profile", b =>
                {
                    b.Navigation("Books");

                    b.Navigation("Interests");

                    b.Navigation("Musicans");

                    b.Navigation("PersonalTags");

                    b.Navigation("ProfileMedias");

                    b.Navigation("TVMedias");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Navigation("DislikedUsers");

                    b.Navigation("LikedUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
