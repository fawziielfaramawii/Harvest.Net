﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Net.Core.Model;

#nullable disable

namespace Net.Core.Migrations
{
    [DbContext(typeof(companycontext))]
    [Migration("20240829172019_procproc_getemp_by_id")]
    partial class procproc_getemp_by_id
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DepartmentProject", b =>
                {
                    b.Property<int>("departmentsid")
                        .HasColumnType("int");

                    b.Property<int>("projectsid")
                        .HasColumnType("int");

                    b.HasKey("departmentsid", "projectsid");

                    b.HasIndex("projectsid");

                    b.ToTable("DepartmentProject");
                });

            modelBuilder.Entity("Net.Core.Model.Address", b =>
                {
                    b.Property<int>("street")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("street"));

                    b.Property<int>("Gov")
                        .HasColumnType("int");

                    b.Property<int>("employeeid")
                        .HasColumnType("int");

                    b.HasKey("street");

                    b.HasIndex("employeeid")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Net.Core.Model.Department", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("departments");

                    b.HasData(
                        new
                        {
                            id = 4,
                            location = "mansoura",
                            name = "IT"
                        },
                        new
                        {
                            id = 5,
                            location = "Cairo",
                            name = "Hr"
                        },
                        new
                        {
                            id = 6,
                            location = "Alex",
                            name = "Cs"
                        },
                        new
                        {
                            id = 7,
                            location = "Aswan",
                            name = "Is"
                        });
                });

            modelBuilder.Entity("Net.Core.Model.Employee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Age")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("int")
                        .HasComputedColumnSql("DATEDIFF(YEAR ,[DateOfBirth],GETDATE())");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("FullNmae");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("Net.Core.Model.Project", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("projects");
                });

            modelBuilder.Entity("Net.Core.Model.deptproject", b =>
                {
                    b.Property<int>("proid")
                        .HasColumnType("int");

                    b.Property<int>("departmentid")
                        .HasColumnType("int");

                    b.Property<int>("Projectid")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("proid", "departmentid");

                    b.HasIndex("Projectid");

                    b.HasIndex("departmentid");

                    b.ToTable("deptproject");
                });

            modelBuilder.Entity("DepartmentProject", b =>
                {
                    b.HasOne("Net.Core.Model.Department", null)
                        .WithMany()
                        .HasForeignKey("departmentsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Net.Core.Model.Project", null)
                        .WithMany()
                        .HasForeignKey("projectsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Net.Core.Model.Address", b =>
                {
                    b.HasOne("Net.Core.Model.Employee", "employee")
                        .WithOne("address")
                        .HasForeignKey("Net.Core.Model.Address", "employeeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");
                });

            modelBuilder.Entity("Net.Core.Model.Employee", b =>
                {
                    b.HasOne("Net.Core.Model.Department", "department")
                        .WithMany("employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("department");
                });

            modelBuilder.Entity("Net.Core.Model.deptproject", b =>
                {
                    b.HasOne("Net.Core.Model.Project", "Project")
                        .WithMany()
                        .HasForeignKey("Projectid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Net.Core.Model.Department", "department")
                        .WithMany()
                        .HasForeignKey("departmentid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("department");
                });

            modelBuilder.Entity("Net.Core.Model.Department", b =>
                {
                    b.Navigation("employees");
                });

            modelBuilder.Entity("Net.Core.Model.Employee", b =>
                {
                    b.Navigation("address")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
