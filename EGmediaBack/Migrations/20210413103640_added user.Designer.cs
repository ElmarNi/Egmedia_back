﻿// <auto-generated />
using System;
using EGmediaBack.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EGmediaBack.Migrations
{
    [DbContext(typeof(EGmediaDb))]
    [Migration("20210413103640_added user")]
    partial class addeduser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EGmediaBack.Models.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("about");
                });

            modelBuilder.Entity("EGmediaBack.Models.Advantage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<string>("IconUrl")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("advantages");
                });

            modelBuilder.Entity("EGmediaBack.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Firstname");

                    b.Property<string>("Lastname");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EGmediaBack.Models.ContactMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Fullname")
                        .IsRequired();

                    b.Property<string>("Message")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("contactMessages");
                });

            modelBuilder.Entity("EGmediaBack.Models.GetPriceOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Fullname")
                        .IsRequired();

                    b.Property<bool>("IsResponsed");

                    b.Property<string>("Message")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("offers");
                });

            modelBuilder.Entity("EGmediaBack.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Home_ImageUrl");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("PortfolioCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioCategoryId");

                    b.ToTable("projects");
                });

            modelBuilder.Entity("EGmediaBack.Models.ProjectCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("projectCategories");
                });

            modelBuilder.Entity("EGmediaBack.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<string>("Heading")
                        .IsRequired();

                    b.Property<int>("ServiceCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("ServiceCategoryId")
                        .IsUnique();

                    b.ToTable("services");
                });

            modelBuilder.Entity("EGmediaBack.Models.ServiceCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IconUrl");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("serviceCategories");
                });

            modelBuilder.Entity("EGmediaBack.Models.ServiceImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl");

                    b.Property<int>("ServiceId");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.ToTable("serviceImages");
                });

            modelBuilder.Entity("EGmediaBack.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aside_Header")
                        .IsRequired();

                    b.Property<string>("Aside_ImageUrl");

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Header_First_Word")
                        .IsRequired();

                    b.Property<string>("Header_Second_Word")
                        .IsRequired();

                    b.Property<string>("ImageUrl");

                    b.HasKey("Id");

                    b.ToTable("sliders");
                });

            modelBuilder.Entity("EGmediaBack.Models.Project", b =>
                {
                    b.HasOne("EGmediaBack.Models.ProjectCategory", "PortfolioCategory")
                        .WithMany("Porfolios")
                        .HasForeignKey("PortfolioCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EGmediaBack.Models.Service", b =>
                {
                    b.HasOne("EGmediaBack.Models.ServiceCategory", "ServiceCategory")
                        .WithOne("Service")
                        .HasForeignKey("EGmediaBack.Models.Service", "ServiceCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EGmediaBack.Models.ServiceImage", b =>
                {
                    b.HasOne("EGmediaBack.Models.Service", "Service")
                        .WithMany("Images")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
