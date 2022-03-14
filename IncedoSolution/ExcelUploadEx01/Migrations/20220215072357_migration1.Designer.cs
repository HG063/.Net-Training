﻿// <auto-generated />
using ExcelUploadEx01.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExcelUploadEx01.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220215072357_migration1")]
    partial class migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExcelUploadEx01.Models.Star", b =>
                {
                    b.Property<string>("TestCaseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActualResult")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpectedResult")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestCaseDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestScenerio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestSteps")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestCaseId");

                    b.ToTable("Stars");
                });
#pragma warning restore 612, 618
        }
    }
}
