namespace CompanyAndEmployeeManagment.Services.Interfaces
{
    using Common.BindingModels;
    using Common.ViewModels;
    using System.Threading.Tasks;

    public interface IEmployeeService
    {
        Task<AddAndEditEmployeeBindingModel> GetInitialEmployeeInfo(int id);

        Task<int> AddEmployeeAsync(AddAndEditEmployeeBindingModel model);

        Task<EmployeeDetailsViewModel> EmployeeDetailsAsync(int id);

        Task DeleteEmployeeAsync(int employeeId);

        Task<AddAndEditEmployeeBindingModel> GetEditEmployeeDetailsAsync(int employeeId);

        Task<int> EditEmployeeAsync(AddAndEditEmployeeBindingModel model);
    }
}