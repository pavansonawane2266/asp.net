﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Context;

#nullable disable

namespace EMP_State_Cas_Auth.Migrations
{
    [DbContext(typeof(MainDbContext))]
    partial class MainDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("City Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("Nvarchar(100)")
                        .HasColumnName("City Name");

                    b.Property<int>("StateId")
                        .HasColumnType("INT");

                    b.HasKey("CityId")
                        .HasName("pk_City_Id");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("WebApplication1.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("Country Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("Nvarchar(100)")
                        .HasColumnName("Country Name");

                    b.HasKey("CountryId")
                        .HasName("pk_CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("WebApplication1.Models.Department", b =>
                {
                    b.Property<int>("Dept_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("Dept Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Dept_Id"));

                    b.Property<string>("Department_Name")
                        .IsRequired()
                        .HasColumnType("Nvarchar(100)")
                        .HasColumnName("Department Name");

                    b.HasKey("Dept_Id")
                        .HasName("pk_Dep_Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("WebApplication1.Models.Employee", b =>
                {
                    b.Property<int>("Emp_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("Employee Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Emp_Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("INT");

                    b.Property<int>("CountryId")
                        .HasColumnType("INT");

                    b.Property<int>("Dept_Id")
                        .HasColumnType("INT");

                    b.Property<string>("Emp_Name")
                        .IsRequired()
                        .HasColumnType("Nvarchar(100)")
                        .HasColumnName("Employee Name");

                    b.Property<int>("StateId")
                        .HasColumnType("INT");

                    b.Property<string>("mobno")
                        .IsRequired()
                        .HasColumnType("NVarchar(500)")
                        .HasColumnName("Employee PhNo");

                    b.HasKey("Emp_Id")
                        .HasName("pk_Employee_Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("Dept_Id");

                    b.HasIndex("StateId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WebApplication1.Models.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("State Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StateId"));

                    b.Property<int>("CountryId")
                        .HasColumnType("INT");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("Nvarchar(100)")
                        .HasColumnName("State Name");

                    b.HasKey("StateId")
                        .HasName("pk_StateId");

                    b.HasIndex("CountryId");

                    b.ToTable("Statements");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.City", b =>
                {
                    b.HasOne("WebApplication1.Models.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("WebApplication1.Models.Employee", b =>
                {
                    b.HasOne("WebApplication1.Models.City", "City")
                        .WithMany("Employees")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Country", "Country")
                        .WithMany("employees")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Department", "department")
                        .WithMany("Employees")
                        .HasForeignKey("Dept_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.State", "State")
                        .WithMany("Employees")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("State");

                    b.Navigation("department");
                });

            modelBuilder.Entity("WebApplication1.Models.State", b =>
                {
                    b.HasOne("WebApplication1.Models.Country", "Country")
                        .WithMany("states")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("WebApplication1.Models.City", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("WebApplication1.Models.Country", b =>
                {
                    b.Navigation("employees");

                    b.Navigation("states");
                });

            modelBuilder.Entity("WebApplication1.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("WebApplication1.Models.State", b =>
                {
                    b.Navigation("Cities");

                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
