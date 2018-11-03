namespace CompanyAndEmployeeManagment.Models
{
    using Common;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Employee
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MinLength(Constants.AttributeConstraint.EmployeeNameMinLength)]
        public string Name { get; set; }

        [Required]
        public Level ExperienceLevel { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        [Range(Constants.AttributeConstraint.EmployeeMinSalary, int.MaxValue)]
        public decimal Salary { get; set; }

        [Required]
        [Range(Constants.AttributeConstraint.EmployeeMinVacationDays, int.MaxValue)]
        public int VacationDays { get; set; }

        [Required]
        public Company Company { get; set; }
    }
}