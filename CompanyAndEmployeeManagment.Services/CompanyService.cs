namespace CompanyAndEmployeeManagment.Services
{
    using AutoMapper;
    using Common.BindingModels;
    using Common.ViewModels;
    using Data;
    using Interfaces;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CompanyService : BaseEFService, ICompanyService
    {
        public CompanyService(CompanyAndEmployeeManagmentContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<int> AddCompanyAsync(AddAndEditCompanyBindingModel model)
        {
            var company = this.Mapper.Map<Company>(model);

            await this.DbContext.Companies.AddAsync(company);
            await this.DbContext.SaveChangesAsync();
            return company.Id;
        }

        public async Task<IEnumerable<IndexCompanyViewModel>> GetCompanyAsync()
        {
            var dbCompanies = await this.DbContext.Companies.ToListAsync();
            if (dbCompanies == null)
            {
                return null;
            }

            var companies = this.Mapper.Map<IEnumerable<IndexCompanyViewModel>>(dbCompanies);
            return companies;
        }

        public async Task<AddAndEditCompanyBindingModel> GetEditCompanyDetailsAsync(int companyId)
        {
            var company = await this.DbContext.Companies.FindAsync(companyId);

            var model = this.Mapper.Map<AddAndEditCompanyBindingModel>(company);
            return model;
        }

        public async Task<int> EditCompanyAsync(AddAndEditCompanyBindingModel model)
        {
            var company = this.Mapper.Map<Company>(model);
            this.DbContext.Companies.Update(company);
            await this.DbContext.SaveChangesAsync();
            return company.Id;
        }

        public async Task DeleteCompanyAsync(int id)
        {
            var company = await this.DbContext.Companies.FindAsync(id);
            if (company == null)
            {
                return;
            }

            this.DbContext.Companies.Remove(company);
            this.DbContext.SaveChanges();
        }

        public async Task<CompanyDetailsViewModel> CompanyDetailsAsync(int id)
        {
            var dbCompany = await this.DbContext.Companies.FindAsync(id);

            if (dbCompany == null)
            {
                return null;
            }
            var dbEmolyees = this.DbContext
                .Employees
                .Include(c => c.Company)
                .Where(c => c.Company == dbCompany);

            var company = this.Mapper.Map<CompanyDetailsViewModel>(dbCompany);

            company.Employees = this.Mapper.Map<IEnumerable<ListEmployeesViewModel>>(dbEmolyees);

            return company;
        }
    }
}