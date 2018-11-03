namespace CompanyAndEmployeeManagment.App.Controllers
{
    using Common;
    using Common.BindingModels;
    using Helpers.Messages;
    using Microsoft.AspNetCore.Mvc;
    using Services.Interfaces;
    using System.Threading.Tasks;

    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> Add(int companyId)
        {
            var model = await employeeService.GetInitialEmployeeInfo(companyId);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddAndEditEmployeeBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                this.TempData["__MessageType"] = MessageType.Warning;
                this.TempData["__MessageText"] = Constants.ErrorMessages.InvalidFormData;
                return View(model);
            }

            var id = await this.employeeService.AddEmployeeAsync(model);

            this.TempData["__MessageType"] = MessageType.Success;
            this.TempData["__MessageText"] = Constants.SuccessMessages.EmployeeAdded;
            return this.RedirectToAction("Details", new { id });
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int employeeId)
        {
            var model = await this.employeeService.GetEditEmployeeDetailsAsync(employeeId);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(AddAndEditEmployeeBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                this.TempData["__MessageType"] = MessageType.Warning;
                this.TempData["__MessageText"] = Constants.ErrorMessages.InvalidFormData;
                return View(model);
            }

            var id = await this.employeeService.EditEmployeeAsync(model);

            this.TempData["__MessageType"] = MessageType.Success;
            this.TempData["__MessageText"] = Constants.SuccessMessages.EmployeeEdited;

            return this.RedirectToAction("Details", new { id });
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int employeeId)
        {
            await this.employeeService.DeleteEmployeeAsync(employeeId);

            return this.RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await this.employeeService.EmployeeDetailsAsync(id);
            return View(model);
        }
    }
}