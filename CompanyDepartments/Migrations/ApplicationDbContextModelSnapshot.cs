﻿// <auto-generated />
using CompanyDepartments.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CompanyDepartments.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.3.23174.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CompanyDepartments.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeCount")
                        .HasColumnType("int");

                    b.Property<int>("IdParent")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeCount = 11,
                            IdParent = 0,
                            Name = "Отдел по обслуживанию клиентов"
                        },
                        new
                        {
                            Id = 2,
                            EmployeeCount = 4,
                            IdParent = 1,
                            Name = "Отдел продаж"
                        },
                        new
                        {
                            Id = 3,
                            EmployeeCount = 2,
                            IdParent = 2,
                            Name = "Отдел оптовых продаж"
                        },
                        new
                        {
                            Id = 4,
                            EmployeeCount = 2,
                            IdParent = 2,
                            Name = "Отдел розничных продаж"
                        },
                        new
                        {
                            Id = 5,
                            EmployeeCount = 7,
                            IdParent = 1,
                            Name = "Отдел логистики"
                        },
                        new
                        {
                            Id = 6,
                            EmployeeCount = 2,
                            IdParent = 5,
                            Name = "Склад"
                        },
                        new
                        {
                            Id = 7,
                            EmployeeCount = 5,
                            IdParent = 5,
                            Name = "Отдел доставки"
                        },
                        new
                        {
                            Id = 8,
                            EmployeeCount = 7,
                            IdParent = 0,
                            Name = "Производственный отдел"
                        },
                        new
                        {
                            Id = 9,
                            EmployeeCount = 4,
                            IdParent = 8,
                            Name = "Инженерный отдел"
                        },
                        new
                        {
                            Id = 10,
                            EmployeeCount = 2,
                            IdParent = 8,
                            Name = "Отдел проверки качества"
                        },
                        new
                        {
                            Id = 11,
                            EmployeeCount = 1,
                            IdParent = 8,
                            Name = "Отдел закупок"
                        },
                        new
                        {
                            Id = 12,
                            EmployeeCount = 2,
                            IdParent = 0,
                            Name = "Бухгалтерия"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}