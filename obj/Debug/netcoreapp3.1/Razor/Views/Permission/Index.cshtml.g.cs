#pragma checksum "C:\goals\PermissionBasedSystem\PermissionBasedSystem\Views\Permission\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6acd32f311d31a0d035d8988706bba7a8222b459"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Permission_Index), @"mvc.1.0.view", @"/Views/Permission/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6acd32f311d31a0d035d8988706bba7a8222b459", @"/Views/Permission/Index.cshtml")]
    public class Views_Permission_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PermissionBasedSystem.Models.PermissionViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Permissions</h1>\r\n<br />\r\n<div class=\"card\">\r\n    <div id=\"viewAll\" class=\"card-body table-responsive\">\r\n        <form asp-controller=\"permission\" method=\"post\" asp-action=\"Update\" class=\"d-inline\">\r\n            <input");
            BeginWriteAttribute("asp-for", " asp-for=\"", 279, "\"", 302, 1);
#nullable restore
#line 7 "C:\goals\PermissionBasedSystem\PermissionBasedSystem\Views\Permission\Index.cshtml"
WriteAttributeValue("", 289, Model.RoleId, 289, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""hidden"" />
            <table class=""table table-striped"" id=""permissionTable"">
                <thead>
                    <tr>
                        <th>
                            Type
                        </th>
                        <th>
                            Permission
                        </th>
                        <th>
                            Status
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 23 "C:\goals\PermissionBasedSystem\PermissionBasedSystem\Views\Permission\Index.cshtml"
                     for (int i = 0; i < Model.RoleClaims.Count(); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <input");
            BeginWriteAttribute("asp-for", " asp-for=\"", 1012, "\"", 1047, 1);
#nullable restore
#line 27 "C:\goals\PermissionBasedSystem\PermissionBasedSystem\Views\Permission\Index.cshtml"
WriteAttributeValue("", 1022, Model.RoleClaims[i].Type, 1022, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"hidden\" />\r\n                                ");
#nullable restore
#line 28 "C:\goals\PermissionBasedSystem\PermissionBasedSystem\Views\Permission\Index.cshtml"
                           Write(Model.RoleClaims[i].Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <input");
            BeginWriteAttribute("asp-for", " asp-for=\"", 1233, "\"", 1269, 1);
#nullable restore
#line 31 "C:\goals\PermissionBasedSystem\PermissionBasedSystem\Views\Permission\Index.cshtml"
WriteAttributeValue("", 1243, Model.RoleClaims[i].Value, 1243, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"hidden\" />\r\n                                ");
#nullable restore
#line 32 "C:\goals\PermissionBasedSystem\PermissionBasedSystem\Views\Permission\Index.cshtml"
                           Write(Model.RoleClaims[i].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"form-check m-1\">\r\n                                    <input");
            BeginWriteAttribute("asp-for", " asp-for=\"", 1522, "\"", 1561, 1);
#nullable restore
#line 36 "C:\goals\PermissionBasedSystem\PermissionBasedSystem\Views\Permission\Index.cshtml"
WriteAttributeValue("", 1532, Model.RoleClaims[i].Selected, 1532, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-check-input\" />\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 40 "C:\goals\PermissionBasedSystem\PermissionBasedSystem\Views\Permission\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
            <div class=""col-sm-12"" style=""padding: 20px 20px 0px 0px"">
                <button type=""submit"" id=""save"" class=""btn btn-success"">
                    <i class=""fa fa-check""></i>
                    Save
                </button>
            </div>
        </form>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PermissionBasedSystem.Models.PermissionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591