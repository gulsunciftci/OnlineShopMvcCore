#pragma checksum "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91bc398f3d56e298a60b6a963a480fa38d918bfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Products/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Products_Index))]
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
#line 1 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShopping;

#line default
#line hidden
#line 1 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml"
using OnlineShopping.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91bc398f3d56e298a60b6a963a480fa38d918bfd", @"/Areas/Admin/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1692c2495c9d4687dd5fa20601122c0273159d1f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonPartialProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91bc398f3d56e298a60b6a963a480fa38d918bfd5306", async() => {
                BeginContext(108, 93, true);
                WriteLiteral("\r\n<script src=\"https://kit.fontawesome.com/a076d05399.js\" crossorigin=\"anonymous\"></script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(208, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(227, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 10 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml"
 if(TempData["save"]!=null){

#line default
#line hidden
                BeginContext(259, 103, true);
                WriteLiteral("       <div class=\"alert alert-success alert-dismissible fade show \" role=\"alert\" >\r\n          <strong>");
                EndContext();
                BeginContext(363, 16, false);
#line 12 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml"
             Write(TempData["save"]);

#line default
#line hidden
                EndContext();
                BeginContext(379, 190, true);
                WriteLiteral("</strong>\r\n          <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n              <span aria-hidden=\"true\">&times;</span>\r\n          </button>\r\n       </div>\r\n");
                EndContext();
#line 17 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml"
 }

#line default
#line hidden
                BeginContext(573, 130, true);
                WriteLiteral("<script type=\"text/javascript\">\r\n$(document).ready(function() {\r\n    $(\'#myTable\').DataTable({\r\n       \r\n    });\r\n});\r\n</script>\r\n");
                EndContext();
            }
            );
            BeginContext(706, 157, true);
            WriteLiteral("<br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Product List</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            EndContext();
            BeginContext(863, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91bc398f3d56e298a60b6a963a480fa38d918bfd8430", async() => {
                BeginContext(907, 45, true);
                WriteLiteral("<i class=\"fa fa-plus\"></i> &nbsp; New Product");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(956, 24, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
            EndContext();
            BeginContext(980, 459, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91bc398f3d56e298a60b6a963a480fa38d918bfd9954", async() => {
                BeginContext(1000, 432, true);
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-3"">
            <input type=""number"" class=""form-control"" name=""lowAmount""/>
        </div>
        <div class=""col-3"">
            <input type=""number"" class=""form-control"" name=""largeAmount""/>
        </div>
        <div class=""col-3"">
            <input type=""submit"" value=""Search"" class=""btn btn-success""/>
        </div>
        <div class=""col-3""></div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1439, 165, true);
            WriteLiteral("\r\n<br />\r\n<div>\r\n    <table class=\"table table-striped border\" id=\"myTable\">\r\n        <thead>\r\n           <tr class=\"table-info\">\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1605, 30, false);
#line 56 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(c=>c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1635, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1691, 31, false);
#line 59 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(c=>c.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1722, 54, true);
            WriteLiteral("\r\n            </th>\r\n           <th>\r\n                ");
            EndContext();
            BeginContext(1777, 38, false);
#line 62 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(c=>c.ProductColor));

#line default
#line hidden
            EndContext();
            BeginContext(1815, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1871, 37, false);
#line 65 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(c=>c.IsAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(1908, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1964, 39, false);
#line 68 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(c=>c.ProductTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(2003, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2059, 38, false);
#line 71 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(c=>c.SpecialTagId));

#line default
#line hidden
            EndContext();
            BeginContext(2097, 122, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n            <th></th>\r\n          </tr>\r\n        </thead>\r\n         <tbody>\r\n\r\n");
            EndContext();
#line 79 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml"
          foreach (var item in Model)
         {

#line default
#line hidden
            BeginContext(2270, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(2309, 9, false);
#line 82 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2318, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2346, 10, false);
#line 83 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml"
               Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2356, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2384, 17, false);
#line 84 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml"
               Write(item.ProductColor);

#line default
#line hidden
            EndContext();
            BeginContext(2401, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2429, 16, false);
#line 85 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml"
               Write(item.IsAvailable);

#line default
#line hidden
            EndContext();
            BeginContext(2445, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2473, 29, false);
#line 86 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml"
               Write(item.ProductTypes.ProductType);

#line default
#line hidden
            EndContext();
            BeginContext(2502, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2530, 27, false);
#line 87 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml"
               Write(item.SpecialTags.SpecialTag);

#line default
#line hidden
            EndContext();
            BeginContext(2557, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2606, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "91bc398f3d56e298a60b6a963a480fa38d918bfd17531", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 89 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Product;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2667, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 92 "C:\Users\Hp\source\repos\OnlineShopping\OnlineShopping\Areas\Admin\Views\Products\Index.cshtml"
          }

#line default
#line hidden
            BeginContext(2724, 54, true);
            WriteLiteral("\r\n         </tbody>\r\n       \r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591