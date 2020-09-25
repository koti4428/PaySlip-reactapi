﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200924113008_addedstringDate")]
    partial class addedstringDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.models.employee.Employee", b =>
                {
                    b.Property<int>("employeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedAtstr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeContractId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeePersonalId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("employeeId");

                    b.HasIndex("EmployeeContractId");

                    b.HasIndex("EmployeePersonalId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Domain.models.employee.EmployeeContract", b =>
                {
                    b.Property<int>("EmployeeContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ContractHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ContractType")
                        .HasColumnType("int");

                    b.Property<decimal>("KiwiSaver")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OvertimeRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PerHourPay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Union")
                        .HasColumnType("bit");

                    b.HasKey("EmployeeContractId");

                    b.ToTable("EmployeeContract");
                });

            modelBuilder.Entity("Domain.models.employee.EmployeePersonal", b =>
                {
                    b.Property<int>("EmployeePersonalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("IRD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeePersonalId");

                    b.ToTable("EmployeePersonal");
                });

            modelBuilder.Entity("Domain.models.payslip.Payslip", b =>
                {
                    b.Property<int>("PayslipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ContractedEarning")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ContractedHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedAtstr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<decimal>("InHandPay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("KiwiSaver")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OtherCharges")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OvertimeEarning")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OvertimeHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PAYE")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalDeduction")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalEarning")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalMonthly")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UnionFee")
                        .HasColumnType("int");

                    b.Property<int?>("employeeId")
                        .HasColumnType("int");

                    b.HasKey("PayslipId");

                    b.HasIndex("employeeId");

                    b.ToTable("Payslips");
                });

            modelBuilder.Entity("Domain.models.employee.Employee", b =>
                {
                    b.HasOne("Domain.models.employee.EmployeeContract", "EmployeeContract")
                        .WithMany()
                        .HasForeignKey("EmployeeContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.models.employee.EmployeePersonal", "EmployeePersonal")
                        .WithMany()
                        .HasForeignKey("EmployeePersonalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.models.payslip.Payslip", b =>
                {
                    b.HasOne("Domain.models.employee.Employee", "Employee")
                        .WithMany("PayRecord")
                        .HasForeignKey("employeeId");
                });
#pragma warning restore 612, 618
        }
    }
}
