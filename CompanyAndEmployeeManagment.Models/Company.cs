using CompanyAndEmployeeManagment.Common;

namespace CompanyAndEmployeeManagment.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Company
    {
        public Company()
        {
            this.Employees = new List<Employee>();
        }
        [Required]
        public int Id { get; set; }

        [Required]
        [MinLength(Constants.AttributeConstraint.CompanyNameMinLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(Constants.AttributeConstraint.CompanyDescriptionMinLength)]
        public string Description { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}