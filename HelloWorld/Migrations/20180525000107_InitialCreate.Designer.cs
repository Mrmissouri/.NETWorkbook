﻿// <auto-generated />
using HelloWorld.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HelloWorld.Migrations
{
    [DbContext(typeof(HelloWorldContext))]
    [Migration("20180525000107_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HelloWorld.Models.Grades", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssignmentNumber");

                    b.Property<string>("Notes")
                        .HasMaxLength(50);

                    b.Property<int>("StudentID");

                    b.Property<string>("Subject");

                    b.Property<string>("TeacherName");

                    b.HasKey("ID");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("HelloWorld.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<int>("Age");

                    b.Property<int>("GradeLevel");

                    b.Property<bool>("Pass");

                    b.Property<int>("StudentEnrolled");

                    b.Property<int>("StudentGender");

                    b.Property<string>("StudentName")
                        .IsRequired();

                    b.HasKey("StudentID");

                    b.ToTable("students");
                });
#pragma warning restore 612, 618
        }
    }
}
