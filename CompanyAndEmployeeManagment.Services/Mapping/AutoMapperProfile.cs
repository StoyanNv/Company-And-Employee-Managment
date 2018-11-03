namespace CompanyAndEmployeeManagment.Services.Mapping
{
    using AutoMapper;
    using Common.BindingModels;
    using Common.ViewModels;
    using Models;

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<AddAndEditCompanyBindingModel, Company>();

            this.CreateMap<Company, AddAndEditCompanyBindingModel>();

            this.CreateMap<Company, IndexCompanyViewModel>();

            this.CreateMap<Company, CompanyDetailsViewModel>();

            this.CreateMap<Employee, AddAndEditEmployeeBindingModel>();

            this.CreateMap<AddAndEditEmployeeBindingModel, Employee>();

            this.CreateMap<AddAndEditEmployeeBindingModel, Employee>();

        }
    }
}