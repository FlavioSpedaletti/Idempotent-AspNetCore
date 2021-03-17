﻿// <auto-generated />
using ContactForm.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContactForm.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20210317170648_requests")]
    partial class requests
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0-preview.2.21154.2");

            modelBuilder.Entity("ContactForm.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IdempotentToken")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IdempotentToken")
                        .IsUnique();

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("ContactForm.Models.Requests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IdempotentToken")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IdempotentToken")
                        .IsUnique();

                    b.ToTable("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}