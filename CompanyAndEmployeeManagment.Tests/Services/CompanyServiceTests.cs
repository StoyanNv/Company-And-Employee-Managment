namespace CompanyAndEmployeeManagment.Tests.Services
{
    using Common.BindingModels;
    using CompanyAndEmployeeManagment.Services;
    using CompanyAndEmployeeManagment.Services.Mapping;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    [TestClass]
    public class CompanyServiceTests
    {
        private CompanyAndEmployeeManagmentContext dbContext;

        [TestInitialize]
        public void InitializeTests()
        {
            var options = new DbContextOptionsBuilder<CompanyAndEmployeeManagmentContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            this.dbContext = new CompanyAndEmployeeManagmentContext(options);
        }
        [TestMethod]
        public async Task CompanyService_AddCompany()
        {
            AddAndEditCompanyBindingModel model = new AddAndEditCompanyBindingModel() { Name = "STP", Description = "Some description" };

            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperProfile>());

            var service = new CompanyService(dbContext, AutoMapper.Mapper.Instance);

            await service.AddCompanyAsync(model);
            Assert.IsNotNull(dbContext.Companies.FirstOrDefault(c => c.Name == "STP"));
            Assert.IsNotNull(dbContext.Companies.FirstOrDefault(c => c.Description == "Some description"));
        }
        [TestMethod]
        public async Task CompanyService_EditCompany()
        {
            AddAndEditCompanyBindingModel model = new AddAndEditCompanyBindingModel() { Name = "STP", Description = "Some description" };
            dbContext.SaveChanges();

            var service = new CompanyService(dbContext, AutoMapper.Mapper.Instance);

            await service.AddCompanyAsync(model);
            Assert.IsNotNull(dbContext.Companies.FirstOrDefault(c => c.Name == "STP"));
            Assert.IsNotNull(dbContext.Companies.FirstOrDefault(c => c.Description == "Some description"));
            model.Name = "New name";
            model.Description = "Some other description";
            await service.EditCompanyAsync(model);
            Assert.IsNotNull(dbContext.Companies.FirstOrDefault(c => c.Name == "New name"));
            Assert.IsNotNull(dbContext.Companies.FirstOrDefault(c => c.Description == "Some other description"));
        }
        [TestMethod]
        public async Task CompanyService_DeleteCompany()
        {
            AddAndEditCompanyBindingModel model = new AddAndEditCompanyBindingModel() { Id = 1, Name = "STPDelete", Description = "Some description" };
            dbContext.SaveChanges();

            var service = new CompanyService(dbContext, AutoMapper.Mapper.Instance);

            await service.AddCompanyAsync(model);

            Assert.IsNotNull(dbContext.Companies.FirstOrDefault(c => c.Name == "STPDelete"));
            Assert.IsNotNull(dbContext.Companies.FirstOrDefault(c => c.Description == "Some description"));

            await service.DeleteCompanyAsync(1);
            Assert.IsNull(dbContext.Companies.FirstOrDefault(c => c.Name == "STPDelete"));
            Assert.IsNull(dbContext.Companies.FirstOrDefault(c => c.Description == "Some other description"));
        }
        [TestMethod]
        public async Task CompanyService_CompanyDetails()
        {
            AddAndEditCompanyBindingModel model = new AddAndEditCompanyBindingModel() { Id = 1, Name = "STPDelete", Description = "Some description" };
            dbContext.SaveChanges();

            var service = new CompanyService(dbContext, AutoMapper.Mapper.Instance);

            await service.AddCompanyAsync(model);

            Assert.IsNotNull(dbContext.Companies.FirstOrDefault(c => c.Name == "STPDelete"));
            Assert.IsNotNull(dbContext.Companies.FirstOrDefault(c => c.Description == "Some description"));

            var companyDetailsModel = await service.CompanyDetailsAsync(1);
            Assert.AreEqual(companyDetailsModel.Name, dbContext.Companies.Find(1).Name);
            Assert.AreEqual(companyDetailsModel.Description, dbContext.Companies.Find(1).Description);
        }
    }
}