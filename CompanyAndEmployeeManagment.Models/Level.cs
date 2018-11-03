namespace CompanyAndEmployeeManagment.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Level
    {
        public Level()
        {
            this.Employees = new List<Employee>();
        }
        [Required]
        public int Id { get; set; }

        [Required]
        public char ExperienceLevel { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}