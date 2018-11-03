using System;
using System.ComponentModel.DataAnnotations;

namespace CompanyAndEmployeeManagment.Common.ViewModels
{
    public class EmployeeDetailsViewModel
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public decimal Salary { get; set; }

        public char ExperienceLevel { get; set; }

        public DateTime StartDate { get; set; }

        public int VacationDays { get; set; }
    }
}