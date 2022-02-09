﻿// <auto-generated />
using System;
using LibraryApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("LibraryApi.Models.Books", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Usersid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("autor_first_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("autor_last_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("book_name")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("Usersid");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LibraryApi.Models.Users", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("first_name")
                        .HasColumnType("TEXT");

                    b.Property<int>("lent_books")
                        .HasColumnType("INTEGER");

                    b.Property<string>("last_name")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LibraryApi.Models.Books", b =>
                {
                    b.HasOne("LibraryApi.Models.Users", null)
                        .WithMany("lent_books")
                        .HasForeignKey("Usersid");
                });
#pragma warning restore 612, 618
        }
    }
}