#pragma checksum "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94a643b88e702e0f994a44766cbfafe07a577601"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctors_Index), @"mvc.1.0.view", @"/Views/Doctors/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94a643b88e702e0f994a44766cbfafe07a577601", @"/Views/Doctors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfa503ef3de3887ad277480ed4d6261c659b6922", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
  
    var name = ViewBag.Name;
    if (@name != "mh")
        Layout = "/Views/Shared/_HomeLayout.cshtml";
    else
        Layout = "/Views/Shared/_PatientLayout.cshtml";
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    
<section style=""margin-top:-160px"">
    <div class=""container"">
        <div class=""row slider-text align-items-end"">
            <div class=""col-md-7 col-sm-12 ftco-animate mb-5"">
                <p class=""breadcrumbs""><span class=""mr-2""><a href=""/Home/Index"">Home</a></span> <span style=""color:ghostwhite"">Doctors</span></p>
                <h1 class=""mb-3"" style=""color:white;opacity:0.8"">Well Experienced Doctors</h1>
            </div>
        </div>
    </div>

</section>
<section class=""ftco-section"">
    <div class=""row justify-content-center mb-5 pb-5"">
        <div class=""col-md-7 text-center heading-section ftco-animate"">
            <h2 class=""mb-3"">Meet Our Experience Doctors</h2>
            <p>We have the most skilled doctors in the world</p>
        </div>
    </div>
    <div class=""s01"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94a643b88e702e0f994a44766cbfafe07a5776015201", async() => {
                WriteLiteral(@"
           
            <div class=""inner-form"">
                <div class=""row"" style=""margin-left:500px;"">
                    <div class=""input-field first-wrap"">
                        <input name=""fname"" type=""text"" placeholder=""First name"" />
                    </div>

                    <div class=""input-field second-wrap"" style=""margi   n-left:10px"">
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 52 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
             foreach (var item in @ViewBag.Employees)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-3 col-md-6 d-flex mb-sm-4 ftco-animate\">\r\n\r\n                    <div class=\"staff\">\r\n                        <div class=\"img mb-4\"");
            BeginWriteAttribute("style", " style=\"", 2189, "\"", 2262, 4);
            WriteAttributeValue("", 2197, "background-image:", 2197, 17, true);
            WriteAttributeValue(" ", 2214, "url(", 2215, 5, true);
#nullable restore
#line 58 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
WriteAttributeValue("", 2219, Url.Content("~/images/" + @item.Imgpath), 2219, 41, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2260, ");", 2260, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        <div class=\"info text-center\">\r\n                            <h3><a");
            BeginWriteAttribute("href", " href=\"", 2362, "\"", 2399, 2);
            WriteAttributeValue("", 2369, "/Employees/Details/", 2369, 19, true);
#nullable restore
#line 60 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
WriteAttributeValue("", 2388, item.Empid, 2388, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 60 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
                                                                    Write(item.Fname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 60 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
                                                                                Write(item.Lname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            <span class=\"position\">");
#nullable restore
#line 61 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
                                              Write(item.Specialist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <div class=\"text\">\r\n                                <p>");
#nullable restore
#line 63 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
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
#line 74 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>
<section class=""ftco-section ftco-counter img"" id=""section-counter"" style=""background-image: url(/Assests/images/bg_1.jpg);"" data-stellar-background-ratio=""0.5"">
    <div class=""container"">
        <div class=""row d-flex align-items-center"">
");
#nullable restore
#line 82 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
             foreach (var item in @ViewBag.AboutUs)
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3 aside-stretch py-5\">\r\n                    <div class=\" heading-section heading-section-white ftco-animate pr-md-4\">\r\n                        <h2 class=\"mb-3\">Achievements</h2>\r\n                        <p>");
#nullable restore
#line 89 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
                      Write(item.Whatwedo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 92 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-9 py-5 pl-md-5\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 96 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
                     foreach (var item in @ViewBag.AboutUs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-md-3 d-flex justify-content-center counter-wrap ftco-animate"">
                            <div class=""block-18"">
                                <div class=""text"">
                                    <strong class=""number"" data-number=""");
#nullable restore
#line 101 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
                                                                   Write(item.Yearofexperience);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">0</strong>\r\n                                    <span>Years of Experience</span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral(@"                        <div class=""col-md-3 d-flex justify-content-center counter-wrap ftco-animate"">
                            <div class=""block-18"">
                                <div class=""text"">
                                    <strong class=""number"" data-number=""");
#nullable restore
#line 110 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
                                                                   Write(item.Qualifieddoctor);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">0</strong>
                                    <span>Qualified Doctors</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-3 d-flex justify-content-center counter-wrap ftco-animate"">
                            <div class=""block-18"">
                                <div class=""text"">
                                    <strong class=""number"" data-number=""");
#nullable restore
#line 118 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
                                                                   Write(item.Numberofsurgery);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">0</strong>
                                    <span>Number of surgery</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-3 d-flex justify-content-center counter-wrap ftco-animate"">
                            <div class=""block-18"">
                                <div class=""text"">
                                    <strong class=""number"" data-number=""");
#nullable restore
#line 126 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
                                                                   Write(item.Patientperyear);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">0</strong>\r\n                                    <span>Patients Per Year</span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 131 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</section>
<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row justify-content-center mb-5 pb-5"">
            <div class=""col-md-7 text-center heading-section ftco-animate"">
                <h2 class=""mb-3"">Our Best Pricing</h2>
                <p>We have different tiers of subscriptions to suit your needs.</p>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 146 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
             foreach (var item in @ViewBag.Subscription)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3 ftco-animate\">\r\n                    <div class=\"pricing-entry pb-5 text-center\">\r\n                        <div>\r\n                            <h3 class=\"mb-4\">");
#nullable restore
#line 152 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
                                        Write(item.SubType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p><span class=\"price\">$");
#nullable restore
#line 153 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
                                               Write(item.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"per\">/ session</span></p>\r\n                        </div>\r\n                        <ul>\r\n                            <li>");
#nullable restore
#line 156 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
                           Write(item.Service1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li>");
#nullable restore
#line 157 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
                           Write(item.Service2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li>");
#nullable restore
#line 158 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
                           Write(item.Service3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li>");
#nullable restore
#line 159 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
                           Write(item.Service4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li>");
#nullable restore
#line 160 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
                           Write(item.Service5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        </ul>\r\n                        <p class=\"button text-center\"><a href=\"#\" class=\"btn btn-primary btn-outline-primary px-4 py-3\">Order now</a></p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 165 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Doctors\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n");
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