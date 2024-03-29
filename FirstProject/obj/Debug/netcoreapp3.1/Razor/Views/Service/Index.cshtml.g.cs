#pragma checksum "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "937646591beb1709d39184ee020742009795fe43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"937646591beb1709d39184ee020742009795fe43", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfa503ef3de3887ad277480ed4d6261c659b6922", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
  
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
                <p class=""breadcrumbs""><span class=""mr-2""><a href=""/Home/Index"">Home</a></span> <span style=""color:ghostwhite"">Services</span></p>
                <h1 class=""mb-3"" style=""color:white;opacity:0.8"">Our Service Keeps you Smile</h1>
            </div>
        </div>
    </div>

</section>
<section class=""ftco-section ftco-services"">
    <div class=""container"">
        <div class=""row justify-content-center mb-5 pb-5"">
            <div class=""col-md-7 text-center heading-section ftco-animate"">
                <h2 class=""mb-2"">Our Service Keeps you Smile</h2>
                <p>We have the best multiple services to suit all your needs.</p>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 31 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
             foreach (var item in @ViewBag.Services)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-3 d-flex align-self-stretch ftco-animate"">
                    <div class=""media block-6 services d-block text-center"">
                        <div class=""icon d-flex justify-content-center align-items-center"">
                            <span class=""flaticon-tooth-1""></span>
                        </div>
                        <div class=""media-body p-2 mt-3"">
                            <h3 class=""heading"">");
#nullable restore
#line 39 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
                                           Write(item.Servicename);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p>");
#nullable restore
#line 40 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
                          Write(item.Aboutservice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 44 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
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
#line 52 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
             foreach (var item in @ViewBag.AboutUs)
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3 aside-stretch py-5\">\r\n                    <div class=\" heading-section heading-section-white ftco-animate pr-md-4\">\r\n                        <h2 class=\"mb-3\">Achievements</h2>\r\n                        <p>");
#nullable restore
#line 59 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
                      Write(item.Whatwedo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 62 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-9 py-5 pl-md-5\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 66 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
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
#line 71 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
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
#line 80 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
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
#line 88 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
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
#line 96 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
                                                                   Write(item.Patientperyear);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">0</strong>\r\n                                    <span>Patients Per Year</span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 101 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
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
#line 116 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
             foreach (var item in @ViewBag.Subscription)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3 ftco-animate\">\r\n                    <div class=\"pricing-entry pb-5 text-center\">\r\n                        <div>\r\n                            <h3 class=\"mb-4\">");
#nullable restore
#line 122 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
                                        Write(item.SubType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p><span class=\"price\">$");
#nullable restore
#line 123 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
                                               Write(item.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"per\">/ session</span></p>\r\n                        </div>\r\n                        <ul>\r\n                            <li>");
#nullable restore
#line 126 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
                           Write(item.Service1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li>");
#nullable restore
#line 127 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
                           Write(item.Service2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li>");
#nullable restore
#line 128 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
                           Write(item.Service3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li>");
#nullable restore
#line 129 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
                           Write(item.Service4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li>");
#nullable restore
#line 130 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
                           Write(item.Service5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        </ul>\r\n                        <p class=\"button text-center\"><a href=\"#\" class=\"btn btn-primary btn-outline-primary px-4 py-3\">Order now</a></p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 135 "C:\Users\Mahmoud Hamarsheh\source\repos\FirstProject\FirstProject\Views\Service\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n");
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
