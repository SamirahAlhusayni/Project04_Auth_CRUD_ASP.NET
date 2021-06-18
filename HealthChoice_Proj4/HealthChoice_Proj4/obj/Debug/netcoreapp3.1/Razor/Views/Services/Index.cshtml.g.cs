#pragma checksum "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6343d59aca8792e2e1417115f7756bca40f60b69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Index), @"mvc.1.0.view", @"/Views/Services/Index.cshtml")]
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
#line 1 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\_ViewImports.cshtml"
using HealthChoice_Proj4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\_ViewImports.cshtml"
using HealthChoice_Proj4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6343d59aca8792e2e1417115f7756bca40f60b69", @"/Views/Services/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"370a4b30f43f73c64c051c5a4e1f98ca3b631b65", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Services", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"
  
    var Stores = (List<ServicesModel>)ViewData["Stores"];
    var Resturents = (List<ServicesModel>)ViewData["Resturents"];
    var Gyms = (List<ServicesModel>)ViewData["Gyms"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div>

    <h5 class=""text-white"">Add Service</h5>
    <i class=""large material-icons""><a href=""/Services/Create"" class=""btn large btn-dark btn-lg"">add_circle</a></i>

</div>



<div style=""width: 100%; height: 30px; border-bottom: 1px dashed white; text-align: center "">
    <span style=""font-size: 40px; background-color: #F3F5F6; padding: 0 10px;"">
        Gyms<!--Padding is optional-->
    </span>
</div>

<div class=""container"">
    <div class=""row"">

");
#nullable restore
#line 26 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"
         foreach (var item in Gyms)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-4\" style=\"margin-top:10%; text-align:center\">\r\n                <div class=\"card mb-3 rounded pb-3\">\r\n                    \r\n                    <div class=\"card-body\">\r\n                        <img class=\"card-img-top rounded\"");
            BeginWriteAttribute("src", " src=\"", 971, "\"", 991, 1);
#nullable restore
#line 33 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"
WriteAttributeValue("", 977, item.servLogo, 977, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" height=\"200\" width=\"80\">\r\n\r\n                        <h3>");
#nullable restore
#line 35 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"
                       Write(item.servName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    </div>\r\n\r\n                    <div class=\"card-body\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1192, "\"", 1225, 2);
            WriteAttributeValue("", 1199, "/Services/Details/", 1199, 18, true);
#nullable restore
#line 39 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"
WriteAttributeValue("", 1217, item.Id, 1217, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Read More</a>\r\n                    </div>\r\n                    <div class=\"d-flex justify-content-center\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6343d59aca8792e2e1417115f7756bca40f60b697457", async() => {
                WriteLiteral("<i class=\"large material-icons\">create</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"
                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6343d59aca8792e2e1417115f7756bca40f60b699967", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("                  <button style=\"display: inline-block; background-color: rgba(0,0,0,0); border: 0;\"><i class=\"large material-icons\" style=\"color:red\">delete_forever</i></button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"
                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 52 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>

<div style=""width: 100%; height: 30px; border-bottom: 1px dashed white; text-align: center"">
    <span style=""font-size: 40px; background-color: #F3F5F6; padding: 0 10px;"">
        Restaurant<!--Padding is optional-->
    </span>
</div>



<div class=""container"">
    <div class=""row"">

");
#nullable restore
#line 70 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"
         foreach (var item in Resturents)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-4\" style=\"margin-top:10%; text-align:center\">\r\n                <div class=\"card mb-3 rounded pb-3\">\r\n                   \r\n                    <div class=\"card-body\">\r\n                        <img class=\"card-img-top rounded\"");
            BeginWriteAttribute("src", " src=\"", 2740, "\"", 2760, 1);
#nullable restore
#line 77 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"
WriteAttributeValue("", 2746, item.servLogo, 2746, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" height=\"200\" width=\"80\">\r\n                        <h3>");
#nullable restore
#line 78 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"
                       Write(item.servName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                    </div>\r\n\r\n                    <div class=\"card-body\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2961, "\"", 2994, 2);
            WriteAttributeValue("", 2968, "/Services/Details/", 2968, 18, true);
#nullable restore
#line 83 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"
WriteAttributeValue("", 2986, item.Id, 2986, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Read More</a>\r\n                    </div>\r\n                    <div class=\"d-flex justify-content-center\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6343d59aca8792e2e1417115f7756bca40f60b6915736", async() => {
                WriteLiteral("<i class=\"large material-icons\">create</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"
                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6343d59aca8792e2e1417115f7756bca40f60b6918247", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("                  <button style=\"display: inline-block; background-color: rgba(0,0,0,0); border: 0;\"><i class=\"large material-icons\" style=\"color:red\">delete_forever</i></button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"
                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 96 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>


<div style=""width: 100%; height: 30px; border-bottom: 1px dashed white; text-align: center"">
    <span style=""font-size: 40px; background-color: #F3F5F6; padding: 0 10px;"">
        Stores<!--Padding is optional-->
    </span>
</div>


<div class=""container mb-5"">
    <div class=""row"">

");
#nullable restore
#line 114 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"
         foreach (var item in Stores)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-4\" style=\"margin-top:10%; text-align:center\">\r\n                <div class=\"card mb-3 pb-3\">\r\n                    \r\n                    <div class=\"card-body\">\r\n                        <img class=\"card-img-top rounded\"");
            BeginWriteAttribute("src", " src=\"", 4499, "\"", 4519, 1);
#nullable restore
#line 121 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"
WriteAttributeValue("", 4505, item.servLogo, 4505, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" height=\"200\" width=\"80\">\r\n                        <h3>");
#nullable restore
#line 122 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"
                       Write(item.servName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                    </div>\r\n\r\n                    <div class=\"card-body\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4720, "\"", 4753, 2);
            WriteAttributeValue("", 4727, "/Services/Details/", 4727, 18, true);
#nullable restore
#line 127 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"
WriteAttributeValue("", 4745, item.Id, 4745, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Read More</a>\r\n                    </div>\r\n                    <div class=\"d-flex justify-content-center\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6343d59aca8792e2e1417115f7756bca40f60b6924011", async() => {
                WriteLiteral("<i class=\"large material-icons\">create</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 130 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"
                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6343d59aca8792e2e1417115f7756bca40f60b6926515", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("                  <button style=\"display: inline-block; background-color: rgba(0,0,0,0); border: 0;\"><i class=\"large material-icons\" style=\"color:red\">delete_forever</i></button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 131 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"
                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 138 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Index.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591