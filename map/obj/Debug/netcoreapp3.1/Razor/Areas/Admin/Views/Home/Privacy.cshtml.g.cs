#pragma checksum "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ccc1434ec138c2bf02dad1744c3bd46ce5d1394"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Privacy), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Privacy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ccc1434ec138c2bf02dad1744c3bd46ce5d1394", @"/Areas/Admin/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54cb28107716c40960f0e895c5fc2bb422c29a3d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"page-content-wrapper\">\r\n      <div class=\"container\">\r\n        <!-- Checkout Wrapper-->\r\n        <div class=\"checkout-wrapper-area py-3\">\r\n          <!-- Choose Payment Method-->\r\n          <div class=\"choose-payment-method\">\r\n");
            WriteLiteral(@"            <div class=""row justify-content-center g-3"">
              <!-- Single Payment Method-->
              <div class=""col-6 col-md-5"">
                <div class=""single-payment-method""><a class=""credit-card"" href=""/Admin/home/pay""><i class=""lni lni-credit-cards""></i>
                    <h6> شارژ حساب </h6></a></div>
              </div>
              <!-- Single Payment Method-->
              <div class=""col-6 col-md-5"">
                <div class=""single-payment-method""><a class=""bank"" href=""/Admin/mapclient/Travel""><i class=""lni lni-car-alt""></i>
                    <h6> سفرهای پیشین </h6></a></div>
              </div>
              <!-- Single Payment Method-->
              <div class=""col-6 col-md-5"">
                <div class=""single-payment-method""><a class=""paypal"" href=""/Admin/home/driverincome""><i class=""lni lni-revenue""></i>
                    <h6> درامدها </h6></a></div>
              </div>
              <!-- Single Payment Method-->
              <div class=""col-6");
            WriteLiteral(@" col-md-5"">
                <div class=""single-payment-method""><a class=""cash"" href=""/Admin/traveldriver/CurrentRequests""><i class=""lni lni-empty-file""></i>
                    <h6> درخواست های جاری</h6></a></div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <script>
    function exitaccept()
{
  window.location.href=""/Admin/home/privacy"";
}
</script>
<script>
  function b(phone)
  {
    
        window.location.href=""/Admin/mapclient/mapclient?phone=""+phone;
    
  }


  
</script>
");
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
