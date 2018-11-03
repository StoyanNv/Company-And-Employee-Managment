namespace CompanyAndEmployeeManagment.App.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Services.Interfaces;
    using System.Diagnostics;
    using System.Threading.Tasks;

    public class HomeController : Controller
    {
        private readonly ICompanyService companyService;

        public HomeController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await companyService.GetCompanyAsync();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}