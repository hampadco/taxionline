#pragma checksum "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\driver\Views\TravelDriver\TravelDriver.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fba501eb7cd9af5b99a7ff11e79da77bf35dbd97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_driver_Views_TravelDriver_TravelDriver), @"mvc.1.0.view", @"/Areas/driver/Views/TravelDriver/TravelDriver.cshtml")]
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
#line 1 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\driver\Views\_ViewImports.cshtml"
using map;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\driver\Views\_ViewImports.cshtml"
using map.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fba501eb7cd9af5b99a7ff11e79da77bf35dbd97", @"/Areas/driver/Views/TravelDriver/TravelDriver.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54cb28107716c40960f0e895c5fc2bb422c29a3d", @"/Areas/driver/Views/_ViewImports.cshtml")]
    public class Areas_driver_Views_TravelDriver_TravelDriver : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""page-content-wrapper"">
    <div class=""container"">
        <!-- Notifications Area-->
        <div class=""notification-area pt-3 pb-2"">
            <h6 style=""text-align: center;"" class=""pl-1"">سفرهای پیشین</h6>
            <div class=""list-group"">

");
#nullable restore
#line 24 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\driver\Views\TravelDriver\TravelDriver.cshtml"
 foreach (var item in ViewBag.List)
{
    if (item.TypePay=="راننده در دسترس نبود")
    {
        


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""accordian-area-wrapper mt-3"">
                    <a href=""/driver/TravelClient/TravelDetails"">
                        <!-- Accordian Card-->
                        <div class=""card accordian-card clearfix"">
                            <div class=""card-body"">
                                <div class=""accordion"" id=""accordionExample"">
                                    <!-- Single Accordian-->
                                    <div class=""accordian-header"" id=""headingOne"">
                                        <button
                                            class=""d-flex align-items-center justify-content-between w-100 collapsed btn""
                                            type=""button"" data-toggle=""collapse"" data-target=""#collapseOne""
                                            aria-expanded=""false"" aria-controls=""collapseOne""><span><i
                                                    class=""lni lni-alarm""></i> راننده در دسترس نبود </span>
          ");
            WriteLiteral(@"                                  <p style=""font-family: iransans; margin-top: 18px;"">
                                                99/10/10
                                            </p>
                                            <i class=""lni lni-chevron-left""> </i>
                                        </button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </a>
                </div>
");
#nullable restore
#line 54 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\driver\Views\TravelDriver\TravelDriver.cshtml"

    }
    if (item.TypePay=="لغو شده")
    {
      

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""accordian-area-wrapper mt-3"">
                    <a href=""/driver/TravelClient/TravelDetails"">
                        <!-- Accordian Card-->
                        <div class=""card accordian-card seller-card clearfix"">
                            <div class=""card-body"">
                                <div class=""accordion"" id=""accordionExample2"">
                                    <!-- Single Accordian-->
                                    <div class=""accordian-header"" id=""headingThree"">
                                        <button
                                            class=""d-flex align-items-center justify-content-between w-100 collapsed btn""
                                            type=""button"" data-toggle=""collapse"" data-target=""#collapseThree""
                                            aria-expanded=""false"" aria-controls=""collapseThree""><span>
                                                <i class=""lni lni-alarm""></i>سفر لغو شده</span>
     ");
            WriteLiteral(@"                                       <p style=""font-family: iransans; margin-top: 18px;"">
                                                99/10/10
                                            </p>
                                            <i class=""lni lni-chevron-left""> </i>
                                        </button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </a>
                </div>
");
#nullable restore
#line 83 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\driver\Views\TravelDriver\TravelDriver.cshtml"

}
if (item.TypePay=="سفر انجام شده")
    {
      

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""accordian-area-wrapper mt-3"">
                    <a href=""/driver/TravelClient/TravelDetails"">

                        <!-- Accordian Card-->
                        <div class=""card accordian-card others-card clearfix"">
                            <div class=""card-body"">
                                <div class=""accordion"" id=""accordionExample3"">
                                    <!-- Single Accordian-->
                                    <div class=""accordian-header"" id=""headingFive"">
                                        <button
                                            class=""d-flex align-items-center justify-content-between w-100 collapsed btn""
                                            type=""button"" data-toggle=""collapse"" data-target=""#collapseFive""
                                            aria-expanded=""false"" aria-controls=""collapseFive""><span><i
                                                    class=""lni lni-alarm""></i> سفر انجام شده </span>
            WriteLiteral(@"
                                            <p style=""font-family: iransans; margin-top: 18px;"">
                                                99/10/10
                                            </p>
                                            <i class=""lni lni-chevron-left"">

                                            </i>
                                        </button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </a>
                </div>
");
#nullable restore
#line 115 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\driver\Views\TravelDriver\TravelDriver.cshtml"
}
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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