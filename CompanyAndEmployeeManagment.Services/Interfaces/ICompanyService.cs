namespace CompanyAndEmployeeManagment.Services.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Common.BindingModels;
    using Common.ViewModels;

    public interface ICompanyService
    {
        Task<int> AddCompanyAsync(AddAndEditCompanyBindingModel model);

        Task<IEnumerable<IndexCompanyViewModel>> GetCompanyAsync();

        Task<AddAndEditCompanyBindingModel> GetEditCompanyDetailsAsync(int id);

        Task<int> EditCompanyAsync(AddAndEditCompanyBindingModel model);

        Task DeleteCompanyAsync(int id);

        Task<CompanyDetailsViewModel> CompanyDetailsAsync(int id);
    }
}