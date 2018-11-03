namespace CompanyAndEmployeeManagment.App.Controllers
{
    using Common;
    using Common.BindingModels;
    using Helpers.Messages;
    using Microsoft.AspNetCore.Mvc;
    using Services.Interfaces;
    using System.Threading.Tasks;

    public class CompanyController : Controller
    {
        private readonly ICompanyService companyService;
        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddAndEditCompanyBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                this.TempData["__MessageType"] = MessageType.Warning;
                this.TempData["__MessageText"] = Constants.ErrorMessages.InvalidFormData;
                return View(model);
            }

            var id = await this.companyService.AddCompanyAsync(model);

            this.TempData["__MessageType"] = MessageType.Success;
            this.TempData["__MessageText"] = Constants.SuccessMessages.CompanyAdded;
            return this.RedirectToAction("Details", new { companyId = id });
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int companyId)
        {
            var model = await this.companyService.GetEditCompanyDetailsAsync(companyId);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(AddAndEditCompanyBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                this.TempData["__MessageType"] = MessageType.Warning;
                this.TempData["__MessageText"] = Constants.ErrorMessages.InvalidFormData;
                return View(model);
            }

            var id = await this.companyService.EditCompanyAsync(model);

            this.TempData["__MessageType"] = MessageType.Success;
            this.TempData["__MessageText"] = Constants.SuccessMessages.CompanyEdited;

            return this.RedirectToAction("Details", new { companyId = id });
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int companyId)
        {
            await this.companyService.DeleteCompanyAsync(companyId);

            return this.RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public async Task<IActionResult> Details(int companyId)
        {
            var model = await this.companyService.CompanyDetailsAsync(companyId);
            return View(model);
        }
    }
}