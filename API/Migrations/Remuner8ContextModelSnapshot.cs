﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Remuner8_Backend.Models;

namespace API.Migrations
{
    [DbContext(typeof(Remuner8Context))]
    partial class Remuner8ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.DataModels.PayrollAdditionItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount1")
                        .HasColumnType("decimal(19,4)")
                        .HasColumnName("amount2");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PayrollAdditionItems");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.Bank", b =>
                {
                    b.Property<string>("BankCode")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("bankCode");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("bankName");

                    b.HasKey("BankCode")
                        .HasName("PK__Banks__7C3F297BF1E3C219");

                    b.HasIndex(new[] { "BankName" }, "UQ__Banks__3EA6523332347041")
                        .IsUnique();

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.Bonus", b =>
                {
                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(19,4)")
                        .HasColumnName("amount");

                    b.Property<decimal>("BonusName")
                        .HasColumnType("decimal(19,4)")
                        .HasColumnName("bonusName");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int")
                        .HasColumnName("departmentId");

                    b.Property<int>("JobDescriptionId")
                        .HasColumnType("int")
                        .HasColumnName("jobDescriptionId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("JobDescriptionId");

                    b.ToTable("Bonuses");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("departmentId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("departmentName");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.EmployeeBiodata", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("employeeId");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("accountNumber");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("address");

                    b.Property<byte[]>("Avatar")
                        .HasColumnType("image")
                        .HasColumnName("avatar");

                    b.Property<string>("BankCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("bankCode");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("countryName");

                    b.Property<DateTime>("DateEmployed")
                        .HasColumnType("date")
                        .HasColumnName("dateEmployed");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("dateOfBirth");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int")
                        .HasColumnName("departmentId");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("emailAddress");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("firstName");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("char(6)")
                        .HasColumnName("gender")
                        .IsFixedLength(true);

                    b.Property<decimal>("GrossSalary")
                        .HasColumnType("decimal(19,4)")
                        .HasColumnName("grossSalary");

                    b.Property<int>("JobDescriptionId")
                        .HasColumnType("int")
                        .HasColumnName("jobDescriptionId");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("lastName");

                    b.Property<string>("MaritalStatus")
                        .IsRequired()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("char(12)")
                        .HasColumnName("maritalStatus")
                        .IsFixedLength(true);

                    b.Property<decimal?>("OtherAllowances")
                        .HasColumnType("decimal(10,4)")
                        .HasColumnName("otherAllowances");

                    b.Property<string>("OtherName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("otherName");

                    b.Property<int?>("PayrollAdditionItemId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("phoneNumber");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("stateName");

                    b.HasKey("EmployeeId")
                        .HasName("PK__Employee__C134C9C1771E4F30");

                    b.HasIndex("BankCode");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("JobDescriptionId");

                    b.HasIndex("PayrollAdditionItemId");

                    b.HasIndex(new[] { "EmailAddress" }, "UQ__Employee__347C3027AEE39C36")
                        .IsUnique();

                    b.HasIndex(new[] { "PhoneNumber" }, "UQ__Employee__4849DA01CAB71A88")
                        .IsUnique();

                    b.ToTable("EmployeeBiodata");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.EmploymentType", b =>
                {
                    b.Property<int>("EmploymentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("employmentTypeId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmploymentName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("employmentName");

                    b.HasKey("EmploymentTypeId");

                    b.HasIndex(new[] { "EmploymentName" }, "UQ__Employme__7E571DB88372C814")
                        .IsUnique();

                    b.ToTable("EmploymentType");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.JobDescription", b =>
                {
                    b.Property<int>("JobDescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("jobDescriptionId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BasicSalary")
                        .HasColumnType("decimal(19,4)")
                        .HasColumnName("basicSalary");

                    b.Property<decimal>("HousingAllowance")
                        .HasColumnType("decimal(19,4)")
                        .HasColumnName("housingAllowance");

                    b.Property<string>("JobDescriptionName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("jobDescriptionName");

                    b.Property<decimal>("TransportAllowance")
                        .HasColumnType("decimal(19,4)")
                        .HasColumnName("transportAllowance");

                    b.HasKey("JobDescriptionId");

                    b.ToTable("JobDescriptions");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.Password", b =>
                {
                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Password1")
                        .IsRequired()
                        .HasMaxLength(32)
                        .IsUnicode(false)
                        .HasColumnType("varchar(32)")
                        .HasColumnName("password");

                    b.HasKey("Email")
                        .HasName("PK__Password__AB6E6165CEDA53DD");

                    b.ToTable("Passwords");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.PayrollTransaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("transactionId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(15,2)")
                        .HasColumnName("balance");

                    b.Property<bool>("Deduction")
                        .HasColumnType("bit")
                        .HasColumnName("deduction");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("employeeId");

                    b.Property<decimal>("Principal")
                        .HasColumnType("decimal(15,2)")
                        .HasColumnName("principal");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(3,2)")
                        .HasColumnName("rate");

                    b.Property<bool>("Statutory")
                        .HasColumnType("bit")
                        .HasColumnName("statutory");

                    b.Property<DateTime>("TransactionDateTime")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)")
                        .HasColumnName("transactionDateTime");

                    b.HasKey("TransactionId")
                        .HasName("PK__PayrollT__9B57CF7249445F48");

                    b.HasIndex("EmployeeId");

                    b.ToTable("PayrollTransactions");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.PensionFundAdministration", b =>
                {
                    b.Property<string>("PfaCode")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("pfaCode");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("accountNumber");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("address");

                    b.Property<string>("PfaName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("pfaName");

                    b.HasKey("PfaCode")
                        .HasName("PK__PensionF__056D327AA7859729");

                    b.ToTable("PensionFundAdministration");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.StatutoryDeduction", b =>
                {
                    b.Property<int>("StatutoryTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("statutoryTypeId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount1")
                        .HasColumnType("decimal(19,4)")
                        .HasColumnName("amount1");

                    b.Property<decimal>("Amount2")
                        .HasColumnType("decimal(19,4)")
                        .HasColumnName("amount2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("employeeId");

                    b.Property<string>("PfaAccountNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("pfaAccountNumber");

                    b.Property<string>("PfaAccountNumber1")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("pfaAccountNumber1");

                    b.Property<string>("PfaCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("pfaCode");

                    b.HasKey("StatutoryTypeId")
                        .HasName("PK__Statutor__8001A5961FCE4767");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PfaCode");

                    b.ToTable("StatutoryDeductions");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.SystemDefault", b =>
                {
                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("address");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("companyName");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<int>("MaxSalaryDays")
                        .HasColumnType("int")
                        .HasColumnName("maxSalaryDays");

                    b.Property<string>("MobileNumber")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("mobileNumber");

                    b.Property<string>("OfficialPhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("officialPhoneNumber");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(7)
                        .IsUnicode(false)
                        .HasColumnType("varchar(7)")
                        .HasColumnName("postalCode");

                    b.Property<DateTime>("SalaryEndDate")
                        .HasColumnType("date")
                        .HasColumnName("salaryEndDate");

                    b.Property<DateTime>("SalaryStartDate")
                        .HasColumnType("date")
                        .HasColumnName("salaryStartDate");

                    b.Property<string>("WebsiteUrl")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("websiteURL");

                    b.ToTable("SystemDefaults");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.Tax", b =>
                {
                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("employeeId");

                    b.Property<decimal?>("Paye")
                        .HasColumnType("decimal(19,4)")
                        .HasColumnName("PAYE");

                    b.Property<decimal?>("Pension")
                        .HasColumnType("decimal(19,4)")
                        .HasColumnName("pension");

                    b.HasIndex(new[] { "EmployeeId" }, "UQ__Taxes__C134C9C0AE6154C9")
                        .IsUnique();

                    b.ToTable("Taxes");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.TimeSheet", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("date")
                        .HasColumnName("date");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("employeeId");

                    b.Property<TimeSpan?>("HoursWorked")
                        .HasColumnType("time(0)")
                        .HasColumnName("hoursWorked");

                    b.Property<TimeSpan?>("TimeIn")
                        .HasColumnType("time(0)")
                        .HasColumnName("timeIn");

                    b.Property<TimeSpan?>("TimeOut")
                        .HasColumnType("time(0)")
                        .HasColumnName("timeOut");

                    b.HasIndex("EmployeeId");

                    b.ToTable("TimeSheet");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("role");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Role" }, "UQ__UserRole__863D21484D4C2003")
                        .IsUnique();

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.Bonus", b =>
                {
                    b.HasOne("Remuner8_Backend.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .HasConstraintName("FK__Bonuses__departm__2B3F6F97")
                        .IsRequired();

                    b.HasOne("Remuner8_Backend.Models.JobDescription", "JobDescription")
                        .WithMany()
                        .HasForeignKey("JobDescriptionId")
                        .HasConstraintName("FK__Bonuses__jobDesc__2C3393D0")
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("JobDescription");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.EmployeeBiodata", b =>
                {
                    b.HasOne("Remuner8_Backend.Models.Bank", "BankCodeNavigation")
                        .WithMany("EmployeeBiodatas")
                        .HasForeignKey("BankCode")
                        .HasConstraintName("FK__EmployeeB__bankC__3C69FB99")
                        .IsRequired();

                    b.HasOne("Remuner8_Backend.Models.Department", "Department")
                        .WithMany("EmployeeBiodatas")
                        .HasForeignKey("DepartmentId")
                        .HasConstraintName("FK__EmployeeB__depar__3A81B327")
                        .IsRequired();

                    b.HasOne("Remuner8_Backend.Models.Password", "EmailAddressNavigation")
                        .WithOne("EmployeeBiodata")
                        .HasForeignKey("Remuner8_Backend.Models.EmployeeBiodata", "EmailAddress")
                        .HasConstraintName("FK__EmployeeB__email__3D5E1FD2")
                        .IsRequired();

                    b.HasOne("Remuner8_Backend.Models.JobDescription", "JobDescription")
                        .WithMany("EmployeeBiodatas")
                        .HasForeignKey("JobDescriptionId")
                        .HasConstraintName("FK__EmployeeB__jobDe__3B75D760")
                        .IsRequired();

                    b.HasOne("API.DataModels.PayrollAdditionItem", null)
                        .WithMany("Assignee")
                        .HasForeignKey("PayrollAdditionItemId");

                    b.Navigation("BankCodeNavigation");

                    b.Navigation("Department");

                    b.Navigation("EmailAddressNavigation");

                    b.Navigation("JobDescription");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.PayrollTransaction", b =>
                {
                    b.HasOne("Remuner8_Backend.Models.EmployeeBiodata", "Employee")
                        .WithMany("PayrollTransactions")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK__PayrollTr__emplo__440B1D61")
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.StatutoryDeduction", b =>
                {
                    b.HasOne("Remuner8_Backend.Models.EmployeeBiodata", "Employee")
                        .WithMany("StatutoryDeductions")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK__Statutory__emplo__403A8C7D")
                        .IsRequired();

                    b.HasOne("Remuner8_Backend.Models.PensionFundAdministration", "PfaCodeNavigation")
                        .WithMany("StatutoryDeductions")
                        .HasForeignKey("PfaCode")
                        .HasConstraintName("FK__Statutory__pfaCo__412EB0B6")
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("PfaCodeNavigation");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.Tax", b =>
                {
                    b.HasOne("Remuner8_Backend.Models.EmployeeBiodata", "Employee")
                        .WithOne()
                        .HasForeignKey("Remuner8_Backend.Models.Tax", "EmployeeId")
                        .HasConstraintName("FK__Taxes__employeeI__48CFD27E")
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.TimeSheet", b =>
                {
                    b.HasOne("Remuner8_Backend.Models.EmployeeBiodata", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK__TimeSheet__emplo__45F365D3")
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("API.DataModels.PayrollAdditionItem", b =>
                {
                    b.Navigation("Assignee");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.Bank", b =>
                {
                    b.Navigation("EmployeeBiodatas");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.Department", b =>
                {
                    b.Navigation("EmployeeBiodatas");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.EmployeeBiodata", b =>
                {
                    b.Navigation("PayrollTransactions");

                    b.Navigation("StatutoryDeductions");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.JobDescription", b =>
                {
                    b.Navigation("EmployeeBiodatas");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.Password", b =>
                {
                    b.Navigation("EmployeeBiodata");
                });

            modelBuilder.Entity("Remuner8_Backend.Models.PensionFundAdministration", b =>
                {
                    b.Navigation("StatutoryDeductions");
                });
#pragma warning restore 612, 618
        }
    }
}
