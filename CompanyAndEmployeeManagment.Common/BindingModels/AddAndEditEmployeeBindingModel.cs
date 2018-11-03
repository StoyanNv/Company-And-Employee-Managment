namespace CompanyAndEmployeeManagment.Common.BindingModels
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class AddAndEditEmployeeBindingModel
    {
        public AddAndEditEmployeeBindingModel()
        {
            ExperienceLevels = new List<SelectListItem>();
        }
        [Required]
        public int Id { get; set; }
        [Required]
        [MinLength(Constants.AttributeConstraint.EmployeeNameMinLength)]
        public string Name { get; set; }

        [Display(Name = Constants.AttributeConstraint.ExperienceLevelDisplay)]
        public string ExperienceLevelId { get; set; }

        public IEnumerable<SelectListItem> ExperienceLevels { get; set; }

        [Required]
        public int CompanyId { get; set; }

        [Required]
        [Display(Name = Constants.AttributeConstraint.StartDateDisplay)]
        public DateTime StartDate { get; set; }

        [Required]
        [Range(Constants.AttributeConstraint.EmployeeMinSalary, int.MaxValue)]
        public decimal Salary { get; set; }

        [Required]
        [Range(Constants.AttributeConstraint.EmployeeMinVacationDays, int.MaxValue)]
        [Display(Name = Constants.AttributeConstraint.VacationDaysDisplay)]
        public int VacationDays { get; set; }
    }
}