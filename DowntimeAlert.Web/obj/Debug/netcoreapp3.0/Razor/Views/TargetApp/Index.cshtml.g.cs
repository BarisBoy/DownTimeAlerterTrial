#pragma checksum "C:\Users\GXT90063124\Desktop\Baris\DahaBaris\Assesment\ASP.NET-CORE-MVC-Sample-Registration-Login-master\DowntimeAlert\DowntimeAlert.Web\Views\TargetApp\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17ba03558bb5b9bd73afd599134b59223855242f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TargetApp_Index), @"mvc.1.0.view", @"/Views/TargetApp/Index.cshtml")]
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
#line 1 "C:\Users\GXT90063124\Desktop\Baris\DahaBaris\Assesment\ASP.NET-CORE-MVC-Sample-Registration-Login-master\DowntimeAlert\DowntimeAlert.Web\Views\_ViewImports.cshtml"
using DowntimeAlert;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17ba03558bb5b9bd73afd599134b59223855242f", @"/Views/TargetApp/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f589cda74a4d874b9fa783cb82b06e9366b4b9a", @"/Views/_ViewImports.cshtml")]
    public class Views_TargetApp_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DowntimeAlert.Web.Models.TargetAppModels.TargetAppListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info text-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning text-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("GET"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\GXT90063124\Desktop\Baris\DahaBaris\Assesment\ASP.NET-CORE-MVC-Sample-Registration-Login-master\DowntimeAlert\DowntimeAlert.Web\Views\TargetApp\Index.cshtml"
  
    ViewData["Title"] = "List Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link type=""text/css"" rel=""stylesheet"" href=""styles/bootstrap.min.css"">
<script src=""script/bootstrap.min.js""></script>
<script src=""script/jquery-1.10.2.min.js""></script>
<style>
    body {
        background-image: url('/images/bg/bg.jpg');
        height: 100%;
        background-position: center;
        background-repeat: no-repeat;
        background-size: cover;
        background-color: #cccccc;
    }

    .centered-form {
        margin-top: 60px;
    }

        .centered-form .panel {
            background: rgba(255, 255, 255, 0.8);
            box-shadow: rgba(0, 0, 0, 0.3) 20px 20px 20px;
        }
</style>
<div class=""container"">
    <nav class=""navbar navbar-default"">
        <div class=""container-fluid"">
            <div class=""navbar-header"">
                <a class=""navbar-brand"" href=""/"">Downtime Alerter</a>
            </div>
            <ul class=""nav navbar-nav"">
                <li><a href=""/TargetApp"">Target Apps</a></li>
            </ul>
        </div>");
            WriteLiteral("\r\n    </nav>\r\n    <div class=\"row centered-form\" style=\"margin-top: 150px;\">\r\n");
#nullable restore
#line 39 "C:\Users\GXT90063124\Desktop\Baris\DahaBaris\Assesment\ASP.NET-CORE-MVC-Sample-Registration-Login-master\DowntimeAlert\DowntimeAlert.Web\Views\TargetApp\Index.cshtml"
         if (TempData["message"] != null)
        {
            string alertType = "alert alert-" + TempData["alertType"];

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 1361, "\"", 1379, 1);
#nullable restore
#line 42 "C:\Users\GXT90063124\Desktop\Baris\DahaBaris\Assesment\ASP.NET-CORE-MVC-Sample-Registration-Login-master\DowntimeAlert\DowntimeAlert.Web\Views\TargetApp\Index.cshtml"
WriteAttributeValue("", 1369, alertType, 1369, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <strong>Alert!</strong> ");
#nullable restore
#line 43 "C:\Users\GXT90063124\Desktop\Baris\DahaBaris\Assesment\ASP.NET-CORE-MVC-Sample-Registration-Login-master\DowntimeAlert\DowntimeAlert.Web\Views\TargetApp\Index.cshtml"
                                   Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 45 "C:\Users\GXT90063124\Desktop\Baris\DahaBaris\Assesment\ASP.NET-CORE-MVC-Sample-Registration-Login-master\DowntimeAlert\DowntimeAlert.Web\Views\TargetApp\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-12"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h3 class=""panel-title"">
                        Target App List
                    </h3>
                </div>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>App Name</th>
                                <th>Url</th>
                                <th>Created Time</th>
                                <th>Monitoring Interval</th>
                                <th>Operations</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 65 "C:\Users\GXT90063124\Desktop\Baris\DahaBaris\Assesment\ASP.NET-CORE-MVC-Sample-Registration-Login-master\DowntimeAlert\DowntimeAlert.Web\Views\TargetApp\Index.cshtml"
                             if (Model.TargetAppList != null && Model.TargetAppList.Count() > 0)
                            {
                                foreach (var item in Model.TargetAppList)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 70 "C:\Users\GXT90063124\Desktop\Baris\DahaBaris\Assesment\ASP.NET-CORE-MVC-Sample-Registration-Login-master\DowntimeAlert\DowntimeAlert.Web\Views\TargetApp\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 71 "C:\Users\GXT90063124\Desktop\Baris\DahaBaris\Assesment\ASP.NET-CORE-MVC-Sample-Registration-Login-master\DowntimeAlert\DowntimeAlert.Web\Views\TargetApp\Index.cshtml"
                               Write(item.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 72 "C:\Users\GXT90063124\Desktop\Baris\DahaBaris\Assesment\ASP.NET-CORE-MVC-Sample-Registration-Login-master\DowntimeAlert\DowntimeAlert.Web\Views\TargetApp\Index.cshtml"
                               Write(item.CreatedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>Every ");
#nullable restore
#line 73 "C:\Users\GXT90063124\Desktop\Baris\DahaBaris\Assesment\ASP.NET-CORE-MVC-Sample-Registration-Login-master\DowntimeAlert\DowntimeAlert.Web\Views\TargetApp\Index.cshtml"
                                     Write(item.MonitoringInterval);

#line default
#line hidden
#nullable disable
            WriteLiteral(" mins</td>\r\n                                <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17ba03558bb5b9bd73afd599134b59223855242f10898", async() => {
                WriteLiteral(" Monitor ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2828, "~/TargetApp/Monitor/?id=", 2828, 24, true);
#nullable restore
#line 74 "C:\Users\GXT90063124\Desktop\Baris\DahaBaris\Assesment\ASP.NET-CORE-MVC-Sample-Registration-Login-master\DowntimeAlert\DowntimeAlert.Web\Views\TargetApp\Index.cshtml"
AddHtmlAttributeValue("", 2852, item.Id, 2852, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" | ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17ba03558bb5b9bd73afd599134b59223855242f12607", async() => {
                WriteLiteral(" Edit ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2918, "~/TargetApp/CreateTargetApp/?id=", 2918, 32, true);
#nullable restore
#line 74 "C:\Users\GXT90063124\Desktop\Baris\DahaBaris\Assesment\ASP.NET-CORE-MVC-Sample-Registration-Login-master\DowntimeAlert\DowntimeAlert.Web\Views\TargetApp\Index.cshtml"
AddHtmlAttributeValue("", 2950, item.Id, 2950, 8, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2958, "&userId=", 2958, 8, true);
#nullable restore
#line 74 "C:\Users\GXT90063124\Desktop\Baris\DahaBaris\Assesment\ASP.NET-CORE-MVC-Sample-Registration-Login-master\DowntimeAlert\DowntimeAlert.Web\Views\TargetApp\Index.cshtml"
AddHtmlAttributeValue("", 2966, Model.UserId, 2966, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" | <button data-model-id=\"");
#nullable restore
#line 74 "C:\Users\GXT90063124\Desktop\Baris\DahaBaris\Assesment\ASP.NET-CORE-MVC-Sample-Registration-Login-master\DowntimeAlert\DowntimeAlert.Web\Views\TargetApp\Index.cshtml"
                                                                                                                                                                                                                                                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-danger text-danger delete-target-app\"> Delete </button> </td>\r\n                            </tr>\r\n");
#nullable restore
#line 76 "C:\Users\GXT90063124\Desktop\Baris\DahaBaris\Assesment\ASP.NET-CORE-MVC-Sample-Registration-Login-master\DowntimeAlert\DowntimeAlert.Web\Views\TargetApp\Index.cshtml"
                                }
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>There is no item found!</td>\r\n                                </tr>\r\n");
#nullable restore
#line 83 "C:\Users\GXT90063124\Desktop\Baris\DahaBaris\Assesment\ASP.NET-CORE-MVC-Sample-Registration-Login-master\DowntimeAlert\DowntimeAlert.Web\Views\TargetApp\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17ba03558bb5b9bd73afd599134b59223855242f16373", async() => {
                WriteLiteral(" Add New App ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3579, "~/TargetApp/CreateTargetApp/?userId=", 3579, 36, true);
#nullable restore
#line 86 "C:\Users\GXT90063124\Desktop\Baris\DahaBaris\Assesment\ASP.NET-CORE-MVC-Sample-Registration-Login-master\DowntimeAlert\DowntimeAlert.Web\Views\TargetApp\Index.cshtml"
AddHtmlAttributeValue("", 3615, Model.UserId, 3615, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    $("".delete-target-app"").click(function () {
        var StudentId = $(this).data(""model-id"");
        var url = ""/TargetApp/DeleteTargetApp/"" + StudentId;
        $.ajax({
            url: url,
            type: 'Delete',
        }).done(function () {
            alert(""Deleted successfully!"");
            window.location.reload();
        }).error(function () {
            alert(""Failed!"");
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DowntimeAlert.Web.Models.TargetAppModels.TargetAppListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
