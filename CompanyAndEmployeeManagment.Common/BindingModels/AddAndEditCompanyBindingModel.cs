namespace CompanyAndEmployeeManagment.Common.BindingModels
{
    using System.ComponentModel.DataAnnotations;

    public class AddAndEditCompanyBindingModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(Constants.AttributeConstraint.CompanyNameMinLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(Constants.AttributeConstraint.CompanyDescriptionMinLength)]
        public string Description { get; set; }
    }
}