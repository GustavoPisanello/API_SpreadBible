﻿// <auto-generated />
using System;
using API_SpreadBible.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_SpreadBible.Migrations
{
    [DbContext(typeof(ChurchDBContext))]
    [Migration("20230914134222_ApiSpreadBible")]
    partial class ApiSpreadBible
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API_SpreadBible.Models.Church", b =>
                {
                    b.Property<Guid>("ChurchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChurchAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChurchCEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChurchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChurchTel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChurchUF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChurchId");

                    b.ToTable("Churches");
                });

            modelBuilder.Entity("API_SpreadBible.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FavChurch")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
