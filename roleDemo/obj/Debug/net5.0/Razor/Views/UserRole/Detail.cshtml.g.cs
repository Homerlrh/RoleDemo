#pragma checksum "C:\Users\Homer\Source\Repos\emo8355\RoleDemo\roleDemo\Views\UserRole\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c204eb865f69921cf24f0df8401e7dbec6ca2d74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserRole_Detail), @"mvc.1.0.view", @"/Views/UserRole/Detail.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Homer\Source\Repos\emo8355\RoleDemo\roleDemo\Views\_ViewImports.cshtml"
using roleDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Homer\Source\Repos\emo8355\RoleDemo\roleDemo\Views\_ViewImports.cshtml"
using roleDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c204eb865f69921cf24f0df8401e7dbec6ca2d74", @"/Views/UserRole/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1bd2a77a35b827d9fa831007454ca594e5bd510", @"/Views/_ViewImports.cshtml")]
    public class Views_UserRole_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<roleDemo.ViewModels.RoleVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 3 "C:\Users\Homer\Source\Repos\emo8355\RoleDemo\roleDemo\Views\UserRole\Detail.cshtml"
Write(ViewBag.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 6 "C:\Users\Homer\Source\Repos\emo8355\RoleDemo\roleDemo\Views\UserRole\Detail.cshtml"
Write(Html.ActionLink("Assign Roles", "Create",
                     new { userName = @ViewBag.UserName }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\Homer\Source\Repos\emo8355\RoleDemo\roleDemo\Views\UserRole\Detail.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Homer\Source\Repos\emo8355\RoleDemo\roleDemo\Views\UserRole\Detail.cshtml"
           Write(Html.DisplayNameFor(model => model.RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n           \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\Homer\Source\Repos\emo8355\RoleDemo\roleDemo\Views\UserRole\Detail.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 27 "C:\Users\Homer\Source\Repos\emo8355\RoleDemo\roleDemo\Views\UserRole\Detail.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "C:\Users\Homer\Source\Repos\emo8355\RoleDemo\roleDemo\Views\UserRole\Detail.cshtml"
               Write(Html.DisplayFor(modelItem => item.RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n        \r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Homer\Source\Repos\emo8355\RoleDemo\roleDemo\Views\UserRole\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<roleDemo.ViewModels.RoleVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
