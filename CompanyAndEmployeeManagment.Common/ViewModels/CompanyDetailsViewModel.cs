using System.Collections.Generic;

namespace CompanyAndEmployeeManagment.Common.ViewModels
{
    public class CompanyDetailsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IEnumerable<ListEmployeesViewModel> Employees { get; set; }
    }
}