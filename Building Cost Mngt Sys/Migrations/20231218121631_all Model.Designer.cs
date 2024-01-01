﻿// <auto-generated />
using System;
using Building_Cost_Mngt_Sys.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Building_Cost_Mngt_Sys.Migrations
{
    [DbContext(typeof(BuildingDbContext))]
    [Migration("20231218121631_all Model")]
    partial class allModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Building_Cost_Mngt_Sys.Models.Project.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StateId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Building_Cost_Mngt_Sys.Models.Project.Projects", b =>
                {
                    b.Property<Guid>("Projects_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<int>("no_of_floors")
                        .HasColumnType("int");

                    b.Property<int>("no_of_house_per_floor")
                        .HasColumnType("int");

                    b.HasKey("Projects_Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Building_Cost_Mngt_Sys.Models.Project.State", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("State_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("Building_Cost_Mngt_Sys.Models.Users.User_Project_Type", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Projects_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("User_Type_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UsersUser_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Projects_Id");

                    b.HasIndex("User_Type_Id");

                    b.HasIndex("UsersUser_Id");

                    b.ToTable("User_Project_Type");
                });

            modelBuilder.Entity("Building_Cost_Mngt_Sys.Models.Users.User_Type", b =>
                {
                    b.Property<Guid>("User_Type_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("User_Type_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_Type_Id");

                    b.ToTable("user_Types");
                });

            modelBuilder.Entity("Building_Cost_Mngt_Sys.Models.Users.Users", b =>
                {
                    b.Property<Guid>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmailID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Building_Cost_Mngt_Sys.Models.Project.City", b =>
                {
                    b.HasOne("Building_Cost_Mngt_Sys.Models.Project.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("Building_Cost_Mngt_Sys.Models.Users.User_Project_Type", b =>
                {
                    b.HasOne("Building_Cost_Mngt_Sys.Models.Project.Projects", null)
                        .WithMany("User_Project_Types")
                        .HasForeignKey("Projects_Id");

                    b.HasOne("Building_Cost_Mngt_Sys.Models.Users.User_Type", null)
                        .WithMany("User_Project_Types")
                        .HasForeignKey("User_Type_Id");

                    b.HasOne("Building_Cost_Mngt_Sys.Models.Users.Users", null)
                        .WithMany("User_Project_Types")
                        .HasForeignKey("UsersUser_Id");
                });

            modelBuilder.Entity("Building_Cost_Mngt_Sys.Models.Project.Projects", b =>
                {
                    b.Navigation("User_Project_Types");
                });

            modelBuilder.Entity("Building_Cost_Mngt_Sys.Models.Users.User_Type", b =>
                {
                    b.Navigation("User_Project_Types");
                });

            modelBuilder.Entity("Building_Cost_Mngt_Sys.Models.Users.Users", b =>
                {
                    b.Navigation("User_Project_Types");
                });
#pragma warning restore 612, 618
        }
    }
}