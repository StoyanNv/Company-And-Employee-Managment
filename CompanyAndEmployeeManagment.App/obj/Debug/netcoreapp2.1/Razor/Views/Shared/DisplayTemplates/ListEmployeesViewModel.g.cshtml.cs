#pragma checksum "C:\Users\User\source\repos\CompanyAndEmployeeManagment\CompanyAndEmployeeManagment.App\Views\Shared\DisplayTemplates\ListEmployeesViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "288e776549a354f0c5ac35683f3d383a3426f156"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_ListEmployeesViewModel), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/ListEmployeesViewModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/DisplayTemplates/ListEmployeesViewModel.cshtml", typeof(AspNetCore.Views_Shared_DisplayTemplates_ListEmployeesViewModel))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\User\source\repos\CompanyAndEmployeeManagment\CompanyAndEmployeeManagment.App\Views\_ViewImports.cshtml"
using CompanyAndEmployeeManagment.App;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\CompanyAndEmployeeManagment\CompanyAndEmployeeManagment.App\Views\_ViewImports.cshtml"
using CompanyAndEmployeeManagment.App.Models;

#line default
#line hidden
#line 3 "C:\Users\User\source\repos\CompanyAndEmployeeManagment\CompanyAndEmployeeManagment.App\Views\_ViewImports.cshtml"
using CompanyAndEmployeeManagment.Common.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\User\source\repos\CompanyAndEmployeeManagment\CompanyAndEmployeeManagment.App\Views\_ViewImports.cshtml"
using CompanyAndEmployeeManagment.Common.BindingModels;

#line default
#line hidden
#line 5 "C:\Users\User\source\repos\CompanyAndEmployeeManagment\CompanyAndEmployeeManagment.App\Views\_ViewImports.cshtml"
using CompanyAndEmployeeManagment.App.Helpers;

#line default
#line hidden
#line 6 "C:\Users\User\source\repos\CompanyAndEmployeeManagment\CompanyAndEmployeeManagment.App\Views\_ViewImports.cshtml"
using CompanyAndEmployeeManagment.App.Helpers.Messages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"288e776549a354f0c5ac35683f3d383a3426f156", @"/Views/Shared/DisplayTemplates/ListEmployeesViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d13c7a2e7f8eb54d67878506eab6016144f0179", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_ListEmployeesViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListEmployeesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 38, true);
            WriteLiteral("\r\n<li>\r\n    <a class=\"list-group-item\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 69, "\"", 110, 1);
#line 4 "C:\Users\User\source\repos\CompanyAndEmployeeManagment\CompanyAndEmployeeManagment.App\Views\Shared\DisplayTemplates\ListEmployeesViewModel.cshtml"
WriteAttributeValue("", 76, $"/Employee/Details/{Model.Id}", 76, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(111, 11, true);
            WriteLiteral(">\r\n        ");
            EndContext();
            BeginContext(123, 20, false);
#line 5 "C:\Users\User\source\repos\CompanyAndEmployeeManagment\CompanyAndEmployeeManagment.App\Views\Shared\DisplayTemplates\ListEmployeesViewModel.cshtml"
   Write(Html.Raw(Model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(143, 19, true);
            WriteLiteral("\r\n    </a>\r\n</li>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListEmployeesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591