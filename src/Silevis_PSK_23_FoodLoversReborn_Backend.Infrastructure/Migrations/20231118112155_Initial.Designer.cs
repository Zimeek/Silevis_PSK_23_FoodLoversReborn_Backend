﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.DataAccess;

#nullable disable

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231118112155_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities.Internship", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Passed")
                        .HasColumnType("bit");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Internships", (string)null);
                });

            modelBuilder.Entity("Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities.InternshipDelayRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Approved")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RequestedDateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RequestedDateStart")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("InternshipDelayRequests");
                });

            modelBuilder.Entity("Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities.StudentDocument", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AlbumNumber")
                        .HasColumnType("int");

                    b.Property<int>("DocumentId")
                        .HasColumnType("int");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StudentDocuments");
                });

            modelBuilder.Entity("Silevis_PSK_23_FoodLoversReborn_Backend.Domain.Entities.Internship", b =>
                {
                    b.OwnsOne("Silevis_PSK_23_FoodLoversReborn_Backend.Domain.ValueObjects.InternshipDetails", "InternshipDetails", b1 =>
                        {
                            b1.Property<Guid>("InternshipId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("CompanyAddress")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("CompanyAddress");

                            b1.Property<string>("CompanyName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("CompanyName");

                            b1.Property<string>("CompanyPhone")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("CompanyPhone");

                            b1.Property<DateTime>("DateEnd")
                                .HasColumnType("datetime2")
                                .HasColumnName("DateEnd");

                            b1.Property<DateTime>("DateStart")
                                .HasColumnType("datetime2")
                                .HasColumnName("DateStart");

                            b1.Property<int>("Month")
                                .HasColumnType("int")
                                .HasColumnName("Month");

                            b1.HasKey("InternshipId");

                            b1.ToTable("InternshipDetails", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("InternshipId");
                        });

                    b.Navigation("InternshipDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
