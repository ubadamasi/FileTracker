﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrackingApp.API.Data;

namespace TrackingApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191122192350_AddDepartmentEntity")]
    partial class AddDepartmentEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity("TrackingApp.API.models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("TrackingApp.API.models.Mail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CurrentLocation");

                    b.Property<string>("Description");

                    b.Property<int>("FileFlow");

                    b.Property<string>("FileName");

                    b.Property<int>("FileType");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("LogDate");

                    b.Property<int>("Organization");

                    b.Property<string>("RefNo");

                    b.HasKey("Id");

                    b.ToTable("Mails");
                });

            modelBuilder.Entity("TrackingApp.API.models.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("TrackingApp.API.models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Department");

                    b.Property<string>("FullName");

                    b.Property<bool>("IsAdmin");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TrackingApp.API.models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });
#pragma warning restore 612, 618
        }
    }
}
