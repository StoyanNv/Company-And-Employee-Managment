namespace CompanyAndEmployeeManagment.Services
{
    using AutoMapper;
    using Common.BindingModels;
    using Common.ViewModels;
    using Data;
    using Interfaces;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Linq;
    using System.Threading.Tasks;
    public class EmployeeService : BaseEFService, IEmployeeService
    {
        public EmployeeService(CompanyAndEmployeeManagmentContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<AddAndEditEmployeeBindingModel> GetInitialEmployeeInfo(int id)
        {
            var model = new AddAndEditEmployeeBindingModel()
            {
                CompanyId = id,
                ExperienceLevels = await this.DbContext.Levels
                    .Select(b => new SelectListItem()
                    {
                        Text = b.ExperienceLevel.ToString(),
                        Value = b.Id.ToString()
                    })
                    .ToListAsync()
            };

            return model;
        }

        public async Task<int> AddEmployeeAsync(AddAndEditEmployeeBindingModel model)
        {
            var employee = this.Mapper.Map<Employee>(model);
            employee.ExperienceLevel = await this.DbContext
                .Levels
                .FindAsync(int.Parse(model
                    .ExperienceLevelId));
            employee.Company = await this.DbContext
                .Companies
                .FindAsync(model
                    .CompanyId);
            await this.DbContext.Employees.AddAsync(employee);
            await this.DbContext.SaveChangesAsync();
            return employee.Id;
        }

        public async Task<EmployeeDetailsViewModel> EmployeeDetailsAsync(int id)
        {
            var dbEmployee = await this.DbContext.Employees.Include(e => e.ExperienceLevel).FirstOrDefaultAsync(e => e.Id == id);
            if (dbEmployee == null)
            {
                return null;
            }
            var employee = this.Mapper.Map<EmployeeDetailsViewModel>(dbEmployee);
            employee.ExperienceLevel = dbEmployee.ExperienceLevel.ExperienceLevel;
            return employee;
        }

        public async Task DeleteEmployeeAsync(int employeeId)
        {
            var employee = await this.DbContext.Employees.FindAsync(employeeId);
            if (employee == null)
            {
                return;
            }

            this.DbContext.Employees.Remove(employee);
            this.DbContext.SaveChanges();
        }

        public async Task<AddAndEditEmployeeBindingModel> GetEditEmployeeDetailsAsync(int employeeId)
        {
            var dbEmployee = await this.DbContext.Employees.Include(e => e.Company).FirstOrDefaultAsync(e => e.Id == employeeId);

            var model = this.Mapper.Map<AddAndEditEmployeeBindingModel>(dbEmployee);
            model.CompanyId = dbEmployee.Company.Id;
            model.ExperienceLevels = this.DbContext.Levels.Select(b => new SelectListItem()
            {
                Text = b.ExperienceLevel.ToString(),
                Value = b.Id.ToString()
            });

            return model;
        }

        public async Task<int> EditEmployeeAsync(AddAndEditEmployeeBindingModel model)
        {
            var employee = this.Mapper.Map<Employee>(model);
            employee.ExperienceLevel = await this.DbContext
                .Levels
                .FindAsync(int.Parse(model
                    .ExperienceLevelId));
            employee.Company = await this.DbContext
                .Companies
                .FindAsync(model
                    .CompanyId);
            this.DbContext.Employees.Update(employee);
            await this.DbContext.SaveChangesAsync();
            return employee.Id;
        }
    }
}