#pragma checksum "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aeadca5d107e5a73aa3f3f652094ceb1ca6d050d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Details), @"mvc.1.0.view", @"/Views/Services/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aeadca5d107e5a73aa3f3f652094ceb1ca6d050d", @"/Views/Services/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"370a4b30f43f73c64c051c5a4e1f98ca3b631b65", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommentsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("border border-black rounded-md p-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cols", new global::Microsoft.AspNetCore.Html.HtmlString("35"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Details.cshtml"
  
    var Services = (ServicesModel)ViewData["Services"];
    var comments = (List<CommentsModel>)ViewData["comments"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\" mb-5\" style=\" text-align:center\">\r\n    <div class=\"card rounded\">\r\n        \r\n        <div class=\"card-body row \">\r\n            <div class=\"col-6\">\r\n                <h1>");
#nullable restore
#line 15 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Details.cshtml"
               Write(Services.servName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n                <p> ");
#nullable restore
#line 16 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Details.cshtml"
               Write(Services.servOverview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-6 rounded\"");
            BeginWriteAttribute("style", " style=\"", 470, "\"", 549, 6);
            WriteAttributeValue("", 478, "background:url(", 478, 15, true);
#nullable restore
#line 18 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Details.cshtml"
WriteAttributeValue("", 493, Services.servLogo, 493, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 511, ")", 511, 1, true);
            WriteAttributeValue(" ", 512, "center", 513, 7, true);
            WriteAttributeValue(" ", 519, "center;", 520, 8, true);
            WriteAttributeValue(" ", 527, "background-size:cover", 528, 22, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"card-body\">\r\n            <div class=\"d-flex justify-content-center mt-3\">\r\n                <a");
            BeginWriteAttribute("href", " href=", 706, "", 733, 1);
#nullable restore
#line 25 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Details.cshtml"
WriteAttributeValue("", 712, Services.servWebsite, 712, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"large material-icons\" style=\"color:blue;\">language</a>\r\n\r\n\r\n                <a");
            BeginWriteAttribute("href", " href=", 819, "", 847, 1);
#nullable restore
#line 28 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Details.cshtml"
WriteAttributeValue("", 825, Services.servLocation, 825, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""large material-icons"" style=""color:blue;"">location_on</a>



                <a href=""/Services"" class=""large material-icons"" style=""color:blue;"">keyboard_arrow_right</a>
            </div>
            <div>
                <h1 class=""text-2xl mt-4"">Comments</h1>
                <hr />
                <div>
");
#nullable restore
#line 38 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Details.cshtml"
                     foreach (var c in comments)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"p-2 bg-gray-200 rounded-lg mt-4\">\r\n                            <div class=\"flex justify-between\">\r\n                                <span class=\"text-gray-800 text-sm italic\">");
#nullable restore
#line 42 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Details.cshtml"
                                                                      Write(c.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeadca5d107e5a73aa3f3f652094ceb1ca6d050d10036", async() => {
                WriteLiteral("\r\n                                    <input  class=\"btn btn-outline-danger\" type=\"submit\" value=\"X\" />\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Details.cshtml"
                                                                                      WriteLiteral(c.Id);

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
            WriteLiteral("\r\n                            </div>\r\n                            <p class=\"text-2xl\">\r\n                                ");
#nullable restore
#line 48 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Details.cshtml"
                           Write(c.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n\r\n                        </div>\r\n");
#nullable restore
#line 52 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\" p-4 bg-gray-100 mt-4 rounded\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeadca5d107e5a73aa3f3f652094ceb1ca6d050d13770", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeadca5d107e5a73aa3f3f652094ceb1ca6d050d14053", async() => {
                    WriteLiteral("Add comment");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 56 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Content);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <br />\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeadca5d107e5a73aa3f3f652094ceb1ca6d050d15707", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 58 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Content);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <br/>\r\n                        <input class=\"btn btn-outline-success\" type=\"submit\" value=\"Add comment\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\Samirah Alhusayni\Documents\Project04_Auth_CRUD_ASP.NET\HealthChoice_Proj4\HealthChoice_Proj4\Views\Services\Details.cshtml"
                                                                          WriteLiteral(Services.Id);

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
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n    </div>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CommentsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591