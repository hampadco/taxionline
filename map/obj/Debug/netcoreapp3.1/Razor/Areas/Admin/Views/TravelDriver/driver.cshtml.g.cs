#pragma checksum "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\TravelDriver\driver.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e64adb846cc6b451a6560e6ae376ff90ccba0e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_TravelDriver_driver), @"mvc.1.0.view", @"/Areas/Admin/Views/TravelDriver/driver.cshtml")]
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
#line 1 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\_ViewImports.cshtml"
using map;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\_ViewImports.cshtml"
using map.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e64adb846cc6b451a6560e6ae376ff90ccba0e9", @"/Areas/Admin/Views/TravelDriver/driver.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54cb28107716c40960f0e895c5fc2bb422c29a3d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_TravelDriver_driver : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""page-content-wrapper"">
    <div class=""container"">
        <!-- Notifications Area-->
        <div class=""notification-area pt-3 pb-2"">
            <h6 style=""text-align: center;"" class=""pl-1"">رانندگان</h6>
            <div class=""list-group"">

");
#nullable restore
#line 24 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\TravelDriver\driver.cshtml"
 foreach (var item in ViewBag.List)
{
    
    

      

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""accordian-area-wrapper mt-3"">
                    <a >

                        <!-- Accordian Card-->
                        <div class=""card accordian-card others-card clearfix"">
                            <div class=""card-body"">
                                <div class=""accordion"" id=""accordionExample3"">
                                    <!-- Single Accordian-->
                                    <div class=""accordian-header"" id=""headingFive"">
                                        <button
                                            class=""d-flex align-items-center justify-content-between w-100 collapsed btn""
                                             ><span><i
                                                    class=""lni lni-alarm""></i> رانندگان </span></button>
                                            <p style=""font-family: iransans; margin-top: 18px;"">نام راننده:
                                                ");
#nullable restore
#line 44 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\TravelDriver\driver.cshtml"
                                           Write(item.NameFamily);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </p>\r\n                                            <p style=\"font-family: iransans; margin-top: 18px;\">شماره تماس:\r\n                                                ");
#nullable restore
#line 47 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\TravelDriver\driver.cshtml"
                                           Write(item.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </p>\r\n                                            <p style=\"font-family: iransans; margin-top: 18px;\">نام کاربری:\r\n                                                ");
#nullable restore
#line 50 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\TravelDriver\driver.cshtml"
                                           Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </p>\r\n                                            <p style=\"font-family: iransans; margin-top: 18px;\">رمز عبور:\r\n                                                ");
#nullable restore
#line 53 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\TravelDriver\driver.cshtml"
                                           Write(item.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </p>\r\n                                            <p style=\"font-family: iransans; margin-top: 18px;\">نوع ماشین:\r\n                                                ");
#nullable restore
#line 56 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\TravelDriver\driver.cshtml"
                                           Write(item.type_car);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </p>\r\n                                            <p style=\"font-family: iransans; margin-top: 18px;\">پلاک:\r\n                                                ");
#nullable restore
#line 59 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\TravelDriver\driver.cshtml"
                                           Write(item.pelak);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </p>\r\n                                            <div class=\"text-center mt-3\">\r\n");
#nullable restore
#line 62 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\TravelDriver\driver.cshtml"
                                                 if (@item.state==false)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a");
            BeginWriteAttribute("href", " href=\"", 3966, "\"", 4008, 2);
            WriteAttributeValue("", 3973, "/admin/travelDriver/active/", 3973, 27, true);
#nullable restore
#line 64 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\TravelDriver\driver.cshtml"
WriteAttributeValue("", 4000, item.Id, 4000, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  class=\"btn btn-success\">فعال کردن</a>\r\n");
#nullable restore
#line 65 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\TravelDriver\driver.cshtml"
                                            }else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a");
            BeginWriteAttribute("href", " href=\"", 4198, "\"", 4241, 2);
            WriteAttributeValue("", 4205, "/admin/travelDriver/dactive/", 4205, 28, true);
#nullable restore
#line 67 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\TravelDriver\driver.cshtml"
WriteAttributeValue("", 4233, item.Id, 4233, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  class=\"btn btn-danger\"> غیر فعال کردن </a>\r\n");
#nullable restore
#line 68 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\TravelDriver\driver.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                            
                                            
                                        
                                    </div>
                                </div>
                            </div>
                        </div>
                    </a>
                </div>
");
#nullable restore
#line 80 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\TravelDriver\driver.cshtml"

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