﻿// <auto-generated />
using System;
using EGmediaBack.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EGmediaBack.Migrations
{
    [DbContext(typeof(EGmediaDb))]
    partial class EGmediaDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
#pragma warning restore 612, 618
        }
    }
}
