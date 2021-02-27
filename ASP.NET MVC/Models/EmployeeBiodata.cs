﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Remuner8_Backend.Models
{
    [Table("EmployeeBiodata")]
    [Index(nameof(EmailAddress), Name = "UQ__Employee__347C3027AEE39C36", IsUnique = true)]
    [Index(nameof(PhoneNumber), Name = "UQ__Employee__4849DA01CAB71A88", IsUnique = true)]
    public partial class EmployeeBiodata
    {
        public EmployeeBiodata()
        {
            PayrollTransactions = new HashSet<PayrollTransaction>();
            StatutoryDeductions = new HashSet<StatutoryDeduction>();
        }

        [Key]
        [Column("employeeId")]
        [StringLength(10)]
        public string EmployeeId { get; set; }
        [Column("avatar", TypeName = "image")]
        public byte[] Avatar { get; set; }
        [Required]
        [Column("firstName")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [Column("lastName")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [Column("otherName")]
        [StringLength(50)]
        public string OtherName { get; set; }
        [Column("dateOfBirth", TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Column("address")]
        [StringLength(200)]
        public string Address { get; set; }
        [Required]
        [Column("phoneNumber")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [Required]
        [Column("emailAddress")]
        [StringLength(50)]
        public string EmailAddress { get; set; }
        [Required]
        [Column("gender")]
        [StringLength(6)]
        public string Gender { get; set; }
        [Required]
        [Column("countryName")]
        [StringLength(30)]
        public string CountryName { get; set; }
        [Required]
        [Column("stateName")]
        [StringLength(30)]
        public string StateName { get; set; }
        [Required]
        [Column("maritalStatus")]
        [StringLength(12)]
        public string MaritalStatus { get; set; }
        [Column("departmentId")]
        public int DepartmentId { get; set; }
        [Column("jobDescriptionId")]
        public int JobDescriptionId { get; set; }
        [Column("dateEmployed", TypeName = "date")]
        public DateTime DateEmployed { get; set; }
        [Column("otherAllowances", TypeName = "decimal(10, 4)")]
        public decimal? OtherAllowances { get; set; }
        [Column("grossSalary", TypeName = "decimal(19, 4)")]
        public decimal GrossSalary { get; set; }
        [Required]
        [Column("bankCode")]
        [StringLength(10)]
        public string BankCode { get; set; }
        [Required]
        [Column("accountNumber")]
        [StringLength(10)]
        public string AccountNumber { get; set; }

        [ForeignKey(nameof(BankCode))]
        [InverseProperty(nameof(Bank.EmployeeBiodatas))]
        public virtual Bank BankCodeNavigation { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty("EmployeeBiodatas")]
        public virtual Department Department { get; set; }
        [ForeignKey(nameof(EmailAddress))]
        [InverseProperty(nameof(Password.EmployeeBiodata))]
        public virtual Password EmailAddressNavigation { get; set; }
        [ForeignKey(nameof(JobDescriptionId))]
        [InverseProperty("EmployeeBiodatas")]
        public virtual JobDescription JobDescription { get; set; }
        [InverseProperty(nameof(PayrollTransaction.Employee))]
        public virtual ICollection<PayrollTransaction> PayrollTransactions { get; set; }
        [InverseProperty(nameof(StatutoryDeduction.Employee))]
        public virtual ICollection<StatutoryDeduction> StatutoryDeductions { get; set; }
    }
}