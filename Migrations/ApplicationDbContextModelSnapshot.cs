﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleCompany.Data;

#nullable disable

namespace SimpleCompany.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SimpleCompany.DataAccessLayer.Model.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("SimpleCompany.DataAccessLayer.Model.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<int>("departmentID")
                        .HasColumnType("int");

                    b.Property<int?>("insuranceCompanyId")
                        .HasColumnType("int");

                    b.Property<int>("projectID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("departmentID");

                    b.HasIndex("insuranceCompanyId");

                    b.HasIndex("projectID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SimpleCompany.DataAccessLayer.Model.InsuranceCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InsuranceCompanies");
                });

            modelBuilder.Entity("SimpleCompany.DataAccessLayer.Model.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("SimpleCompany.DataAccessLayer.Model.Employee", b =>
                {
                    b.HasOne("SimpleCompany.DataAccessLayer.Model.Department", "department")
                        .WithMany("Employees")
                        .HasForeignKey("departmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleCompany.DataAccessLayer.Model.InsuranceCompany", "insuranceCompany")
                        .WithMany("Employees")
                        .HasForeignKey("insuranceCompanyId");

                    b.HasOne("SimpleCompany.DataAccessLayer.Model.Project", "project")
                        .WithMany("Employees")
                        .HasForeignKey("projectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("department");

                    b.Navigation("insuranceCompany");

                    b.Navigation("project");
                });

            modelBuilder.Entity("SimpleCompany.DataAccessLayer.Model.Project", b =>
                {
                    b.HasOne("SimpleCompany.DataAccessLayer.Model.Department", null)
                        .WithMany("Projects")
                        .HasForeignKey("DepartmentID");
                });

            modelBuilder.Entity("SimpleCompany.DataAccessLayer.Model.Department", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("SimpleCompany.DataAccessLayer.Model.InsuranceCompany", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("SimpleCompany.DataAccessLayer.Model.Project", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
