#pragma checksum "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cedecbaac49afbb6b241b41e3b3eb49cf189572"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctors_Search), @"mvc.1.0.view", @"/Views/Doctors/Search.cshtml")]
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
#line 1 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\_ViewImports.cshtml"
using FirstProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\_ViewImports.cshtml"
using FirstProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cedecbaac49afbb6b241b41e3b3eb49cf189572", @"/Views/Doctors/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfa503ef3de3887ad277480ed4d6261c659b6922", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctors_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:25px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Search.cshtml"
  
    Layout = "_HomeLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"s01\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cedecbaac49afbb6b241b41e3b3eb49cf1895725393", async() => {
                WriteLiteral(@"

        <div class=""inner-form"">
            <div class=""row"" style=""margin-left:500px;"">
                <div class=""input-field first-wrap"">
                    <input name=""fname"" type=""text"" placeholder=""First name"" />
                </div>

                <div class=""input-field second-wrap"" style=""margin-left:10px"">
                    <input name=""lname"" type=""text"" placeholder=""Last Name"" />
                </div>


                <div class=""input-field third-wrap"" style=""margin-left:10px"">
                    <button class=""btn-search"" type=""submit"" style=""color:white;background-color:dodgerblue"">Search</button>
                </div>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n    <script src=\"//ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js\"></script>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3cedecbaac49afbb6b241b41e3b3eb49cf1895727850", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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



    <link href=""https://cdn.datatables.net/1.10.15/css/dataTables.bootstrap.min.css"" rel=""stylesheet"" />
    <link href=""https://cdn.datatables.net/responsive/2.1.1/css/responsive.bootstrap.min.css"" rel=""stylesheet"" />



    <script src=""https://cdn.datatables.net/1.10.15/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.15/js/dataTables.bootstrap4.min.js ""></script>



    <div class=""container"">
        <div class=""row"">
");
#nullable restore
#line 47 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Search.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-3 col-md-6 d-flex mb-sm-4 ftco-animate\">\r\n\r\n                    <div class=\"staff\">\r\n                        <div class=\"img mb-4\"");
            BeginWriteAttribute("style", " style=\"", 1752, "\"", 1825, 4);
            WriteAttributeValue("", 1760, "background-image:", 1760, 17, true);
            WriteAttributeValue(" ", 1777, "url(", 1778, 5, true);
#nullable restore
#line 53 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Search.cshtml"
WriteAttributeValue("", 1782, Url.Content("~/images/" + @item.Imgpath), 1782, 41, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1823, ");", 1823, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        <div class=\"info text-center\">\r\n                            <h3><a href=\"teacher-single.html\">");
#nullable restore
#line 55 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Search.cshtml"
                                                         Write(item.Fname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 55 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Search.cshtml"
                                                                     Write(item.Lname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            <span class=\"position\">");
#nullable restore
#line 56 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Search.cshtml"
                                              Write(item.Specialist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <div class=\"text\">\r\n                                <p>");
#nullable restore
#line 58 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Search.cshtml"
                              Write(item.Abouthim);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                <ul class=""ftco-social"">
                                    <li class=""ftco-animate""><a href=""#""><span class=""icon-twitter""></span></a></li>
                                    <li class=""ftco-animate""><a href=""#""><span class=""icon-facebook""></span></a></li>
                                    <li class=""ftco-animate""><a href=""#""><span class=""icon-instagram""></span></a></li>
                                    <li class=""ftco-animate""><a href=""#""><span class=""icon-google-plus""></span></a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 69 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Search.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
