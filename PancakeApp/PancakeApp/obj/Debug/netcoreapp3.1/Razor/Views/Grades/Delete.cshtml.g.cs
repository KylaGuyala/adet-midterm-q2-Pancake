#pragma checksum "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdf9a92825c1835316e274b41de3941811bbe266"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grades_Delete), @"mvc.1.0.view", @"/Views/Grades/Delete.cshtml")]
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
#line 1 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\_ViewImports.cshtml"
using PancakeApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\_ViewImports.cshtml"
using PancakeApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdf9a92825c1835316e274b41de3941811bbe266", @"/Views/Grades/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42e699a90094180b67b26e5b162284e7b3f71fef", @"/Views/_ViewImports.cshtml")]
    public class Views_Grades_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PancakeApp.Models.Grade>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Grade</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Prelim_Quiz1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Prelim_Quiz1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Prelim_Quiz2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Prelim_Quiz2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Prelim_Quiz3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Prelim_Quiz3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Prelim_Assign1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Prelim_Assign1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Prelim_Assign2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Prelim_Assign2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Prelim_Assign3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Prelim_Assign3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Midterm_Quiz1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Midterm_Quiz1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Midterm_Quiz2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Midterm_Quiz2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Midterm_Quiz3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Midterm_Quiz3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Midterm_Assign1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Midterm_Assign1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Midterm_Assign2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Midterm_Assign2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Midterm_Assign3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Midterm_Assign3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Prefinal_Quiz1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Prefinal_Quiz1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Prefinal_Quiz2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Prefinal_Quiz2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Prefinal_Quiz3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Prefinal_Quiz3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Prefinal_Assign1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Prefinal_Assign1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Prefinal_Assign2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Prefinal_Assign2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Prefinal_Assign3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Prefinal_Assign3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Final_Quiz1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Final_Quiz1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Final_Quiz2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 132 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Final_Quiz2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 135 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Final_Quiz3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 138 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Final_Quiz3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 141 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Final_Assign1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 144 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Final_Assign1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 147 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Final_Assign2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 150 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Final_Assign2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 153 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Final_Assign3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 156 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Final_Assign3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdf9a92825c1835316e274b41de3941811bbe26621763", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fdf9a92825c1835316e274b41de3941811bbe26622030", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 161 "D:\ASP PROJECTS\Pancake\ADET-Midterm-Quiz-2-3-Pancake-\PancakeApp\PancakeApp\Views\Grades\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdf9a92825c1835316e274b41de3941811bbe26623842", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PancakeApp.Models.Grade> Html { get; private set; }
    }
}
#pragma warning restore 1591
