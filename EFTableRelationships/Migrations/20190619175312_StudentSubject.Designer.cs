﻿// <auto-generated />
using System;
using EFTableRelationships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFTableRelationships.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20190619175312_StudentSubject")]
    partial class StudentSubject
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFTableRelationships.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Phone");

                    b.Property<int>("TeacherId");

                    b.HasKey("ContactId");

                    b.HasIndex("TeacherId")
                        .IsUnique();

                    b.ToTable("ContactInfos");
                });

            modelBuilder.Entity("EFTableRelationships.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EFTableRelationships.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("EFTableRelationships.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("EFTableRelationships.Models.Contact", b =>
                {
                    b.HasOne("EFTableRelationships.Models.Teacher")
                        .WithOne("Contact")
                        .HasForeignKey("EFTableRelationships.Models.Contact", "TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFTableRelationships.Models.Subject", b =>
                {
                    b.HasOne("EFTableRelationships.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId");
                });
#pragma warning restore 612, 618
        }
    }
}
