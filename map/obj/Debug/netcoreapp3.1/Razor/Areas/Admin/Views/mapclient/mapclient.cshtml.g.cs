#pragma checksum "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\mapclient\mapclient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f87b8cfe006286699e55585a460b972bf42c95b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_mapclient_mapclient), @"mvc.1.0.view", @"/Areas/Admin/Views/mapclient/mapclient.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f87b8cfe006286699e55585a460b972bf42c95b", @"/Areas/Admin/Views/mapclient/mapclient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54cb28107716c40960f0e895c5fc2bb422c29a3d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_mapclient_mapclient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataLayer.Entites.Tbl_Travel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("my_audio"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app/img/icons/ring.mp3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("loop", new global::Microsoft.AspNetCore.Html.HtmlString("loop"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app/img/icons/refresh.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/mapclient/AddTravel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://unpkg.com/leaflet@1.3.4/dist/leaflet.css"" />
<script src=""https://unpkg.com/leaflet@1.3.4/dist/leaflet.js""></script>
<link rel=""stylesheet"" href=""https://unpkg.com/leaflet-geosearch@3.1.0/dist/geosearch.css"" />
<script src=""https://unpkg.com/leaflet@1.7.1/dist/leaflet.js""></script>
<script
    src=""https://cdnjs.cloudflare.com/ajax/libs/leaflet-routing-machine/3.2.12/leaflet-routing-machine.min.js""></script>

<style>
    #map {
        height: 700px;
        width: 100%;
    }

    .leaflet-top {
        display: none;
    }


    .mapbox {

        background-color: #0d3bd16b;
        width: 100%;
        height: 58px;
        position: fixed;
        bottom: 30px;
        right: 0;
        left: 0;
        z-index: 1000;
    }

    .mapboxrefresh {



        position: fixed;
        top: 90px;
        right: 0;
        left: 0;
        z-index: 1000;
        right: 20px;
    }
</style>


<div class=""col-sm-12 col-12"">
    <di");
            WriteLiteral("v id=\"map\">\r\n\r\n\r\n        \r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f87b8cfe006286699e55585a460b972bf42c95b8136", async() => {
                WriteLiteral("\r\n        <div id=\"msg\" class=\"mapbox alert aler-info text-center  \" style=\"height:Auto;\">\r\n\r\n");
                WriteLiteral("            <p id=\"distancedemo\" class=\"btn btn-primary\" style=\"font-family: iransans;display: revert !important;\">مسافت :");
#nullable restore
#line 56 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\mapclient\mapclient.cshtml"
                                                                                                                     Write(Model.Distance);

#line default
#line hidden
#nullable disable
                WriteLiteral(" کیلومتر</p>\r\n");
                WriteLiteral("            <p id=\"Origindemo\" class=\"d-none\" style=\"font-family: iransans;display: revert !important;\"></p>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f87b8cfe006286699e55585a460b972bf42c95b9182", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 59 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\mapclient\mapclient.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Origin);

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
                WriteLiteral("\r\n");
                WriteLiteral("            <p id=\"destinationdemo\" class=\"d-none\" style=\"font-family: iransans;display: revert !important;\"></p>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f87b8cfe006286699e55585a460b972bf42c95b11146", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 62 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\mapclient\mapclient.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Destination);

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
                WriteLiteral("\r\n");
                WriteLiteral("            <p id=\"timedemo\" class=\"btn btn-primary\" style=\"font-family: iransans;display: revert !important;\"> زمان رسیدن: ");
#nullable restore
#line 64 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\mapclient\mapclient.cshtml"
                                                                                                                       Write(Model.Time);

#line default
#line hidden
#nullable disable
                WriteLiteral(" دقیقه</p>\r\n           \r\n            \r\n");
                WriteLiteral("            <p id=\"pricedemo\" class=\"btn btn-primary\" style=\"font-family: iransans;display: revert !important;\">هزینه سفر :</p>\r\n             ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f87b8cfe006286699e55585a460b972bf42c95b13681", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 69 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\mapclient\mapclient.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Price);

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
                WriteLiteral("\r\n            <input type=\"text\" id=\"phoneclient\"");
                BeginWriteAttribute("value", " value=\"", 2291, "\"", 2315, 1);
#nullable restore
#line 70 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\mapclient\mapclient.cshtml"
WriteAttributeValue("", 2299, Model.UserPhone, 2299, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display: none;\">\r\n\r\n           <div class=\"row justify-content-center\">\r\n               ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("audio", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f87b8cfe006286699e55585a460b972bf42c95b16018", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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

                 <a onclick=""acceptdriver();""  class=""btn btn-warning mt-0  col-5 "" style=""font-family: iransans;display: revert !important;"">پذیرش مسافر</a>
               
                <a href=""/Admin/home/privacy""  class=""btn btn-danger mt-0  col-5 ml-2"" style=""font-family: iransans;display: revert !important;color:white"">رد کردن مسافر</a>
           

           </div>
              
        </div>

        <div id=""refresh"" class=""mapboxrefresh text-center ""
            style=""background-color: #a9bdff6b;width:100px;display:none"">
            <a");
                BeginWriteAttribute("href", " href=\"", 3059, "\"", 3066, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"font-family: iransans;\"");
                BeginWriteAttribute("class", " class=\"", 3098, "\"", 3106, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f87b8cfe006286699e55585a460b972bf42c95b18236", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" جستجوی مجدد\r\n            </a>\r\n\r\n\r\n        </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <div id=\"mylocation\" class=\"mapboxrefresh text-center \" style=\"background-color: #a9bdff6b;width:100px;\">\r\n            <a onclick=\"findlocation();\" style=\"font-family: iransans;\"");
            BeginWriteAttribute("class", " class=\"", 3421, "\"", 3429, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f87b8cfe006286699e55585a460b972bf42c95b21090", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" یافتن موقعیت

            </a>


        </div>










    </div>

</div>


<script>
   
</script>
<script>
    var t=1;
  document.getElementById('pricedemo').innerHTML = ""قیمت  :"" + ""&nbsp;"" + autocomma( document.getElementById('Price').value) + ""&nbsp;"" + ""تومان"";
    // Creating map options
    var mapOptions = {
        center: [38.2025589, 44.7686697],
        zoom: 15
    }

    var mabda = L.icon({
        iconUrl: '/app/img/icons/mabda.png',


        iconSize: [75, 75], // size of the icon

    });

    var magsad = L.icon({

        iconUrl: '/app/img/icons/magsad.png',


        iconSize: [80, 80], // size of the icon

    });
    // Creating a map object
    var map = new L.map('map', mapOptions);

    // Creating a Layer object
    var layer = new L.TileLayer('http://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png');


    // Adding layer to the map
    map.addLayer(layer);

    // Creating a Marker
    var markerOptionsmabda = {
      ");
            WriteLiteral(@"  title: ""مبدا"",
        clickable: true,
        draggable: false
    }

    var markerOptionsmagsad = {
        title: ""مقصد"",
        clickable: true,
        draggable: false
    }


    var a, b;
    // Creating a marker
 
  var a=document.getElementById(""Origin"").value.replace(""LatLng"","""").replace(""("" ,"""").replace("")"","""");
  var b=document.getElementById(""Destination"").value.replace(""LatLng"","""").replace(""("" ,"""").replace("")"","""");


   var latlong =  a.split(',');
  var latitude = parseFloat(latlong[0]);
  var longitude = parseFloat(latlong[1]);

   var latlong1 =  b.split(',');
  var latitude1 = parseFloat(latlong1[0]);
  var longitude1 = parseFloat(latlong1[1]);


   L.Routing.control({
    waypoints: [
        L.latLng(latitude,longitude),
        L.latLng(latitude1,longitude1)
    ],
    routeWhileDragging: true,
    lineOptions: {
                styles: [{ color: 'blue', opacity: 1, weight: 3 }]
            }

}).addTo(map);





    var marker4 = L.marker");
            WriteLiteral("(map.getCenter(), { icon: magsad }, markerOptionsmabda);;\r\n    var marker3 = L.marker(map.getCenter(), { icon: mabda }, markerOptionsmabda);\r\n\r\n");
            WriteLiteral(@"
    marker3.on('click', function (e) {

        var marker1;
        marker1 = L.marker(map.getCenter(), { icon: mabda }, markerOptionsmabda);
        a = marker1;
        marker1.addTo(map);

        map.removeLayer(marker3);
        marker4.addTo(map);
        document.getElementById('mabda').style.display = ""none"";
        document.getElementById('magsad').style.display = ""block"";
        document.getElementById('refresh').style.display = ""block"";
        document.getElementById('mylocation').style.display = ""none"";
        document.getElementById('Origin').value=a.getLatLng();

    });
    marker4.on('click', function (e) {

        var marker2;
        marker2 = L.marker(map.getCenter(), { icon: magsad }, markerOptionsmabda);
        b = marker2;
        marker2.addTo(map);
        map.removeLayer(marker4);
         document.getElementById('Destination').value=b.getLatLng();

        Route();

    });






    function Route() {



        var routeControl = L.Rou");
            WriteLiteral(@"ting.control({
            waypoints: [
                L.latLng(a.getLatLng()),
                L.latLng(b.getLatLng())
            ],
            createMarker: function () { return null; },

            draggableWaypoints: false,

            lineOptions: {
                styles: [{ color: 'blue', opacity: 1, weight: 3 }]
            }


        }).addTo(map);

        routeControl.on('routesfound', function (e) {
            var routes = e.routes;
            var summary = routes[0].summary;
            document.getElementById('distancedemo').innerHTML = ""مسافت :"" + ""&nbsp;"" + (summary.totalDistance / 1000).toFixed(2) + ""&nbsp;"" + ""کیلومتر"";
             document.getElementById('Distance').value= (summary.totalDistance / 1000).toFixed(2);
            document.getElementById('timedemo').innerHTML = ""زمان  :"" + ""&nbsp;"" + (summary.totalTime / 60).toFixed(2) + ""&nbsp;"" + ""دقیقه"";
            document.getElementById('Time').value=(summary.totalTime / 60).toFixed(2);
            var km =");
            WriteLiteral(@" (summary.totalDistance / 1000).toFixed(2);
            if (km > 5) {
                var b = (km - 5) * 1000;
                var sum = 4000 + b;

                document.getElementById('pricedemo').innerHTML = ""قیمت  :"" + ""&nbsp;"" + autocomma(sum) + ""&nbsp;"" + ""تومان"";
                 document.getElementById('Price').value=sum;

            } else {
                document.getElementById('pricedemo').innerHTML = ""قیمت  :"" + ""&nbsp;"" + autocomma(4000) + ""&nbsp;"" + ""تومان"";
                 document.getElementById('Price').value= 4000;


            }

            document.getElementById('magsad').style.display = ""none"";
            document.getElementById('msg').style.display = ""block"";



        });


    }





    map.on('move', function () {


        marker3.setLatLng(map.getCenter());
        marker4.setLatLng(map.getCenter());




    });


    marker.addEventListener(""click"", function (e) {
        map.panTo(this.getLatLng());
    });


    function l");
            WriteLiteral(@"oc(marker) {
        var data = {
            lat: marker.latlng.lat,
            lng: marker.latlng.lng
        }
        alert(""hjgghjgh"");
    }


    function autocomma(number_input) {
        number_input += '';
        number_input = number_input.replace(',', ''); number_input = number_input.replace(',', ''); number_input = number_input.replace(',', '');
        number_input = number_input.replace(',', ''); number_input = number_input.replace(',', ''); number_input = number_input.replace(',', '');
        x = number_input.split('.');
        x1 = x[0];
        x2 = x.length > 1 ? '.' + x[1] : '';
        var rgx = /(\d+)(\d{3})/;
        while (rgx.test(x1))
            x1 = x1.replace(rgx, '$1' + ',' + '$2');
        return x1 + x2;
    }

</script>

<script>

    navigator.geolocation.getCurrentPosition(function (location) {
        var latlng = new L.LatLng(location.coords.latitude, location.coords.longitude);

        var mymap = L.map('mapid').setView(latlng, 13)
     ");
            WriteLiteral(@"   L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token={accessToken}', {
            attribution: 'Map data &copy; <a href=""http://openstreetmap.org"">OpenStreetMap</a> contributors, <a href=""http://creativecommons.org/licenses/by-sa/2.0/"">CC-BY-SA</a>, Imagery © <a href=""https://mapbox.com"">Mapbox</a>',
            maxZoom: 18,
            id: 'mapbox.streets',
            accessToken: 'pk.eyJ1IjoiYmJyb29rMTU0IiwiYSI6ImNpcXN3dnJrdDAwMGNmd250bjhvZXpnbWsifQ.Nf9Zkfchos577IanoKMoYQ'
        }).addTo(mymap);

        marker3 = L.marker(latlng).addTo(mymap);
    });


    function findlocation() {

        navigator.geolocation.getCurrentPosition(function (location) {
            var latlng = new L.LatLng(location.coords.latitude, location.coords.longitude);

            var mymap = L.map('mapid').setView(latlng, 13)
            L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token={accessToken}', {
                attribution: 'Map data &copy; <");
            WriteLiteral(@"a href=""http://openstreetmap.org"">OpenStreetMap</a> contributors, <a href=""http://creativecommons.org/licenses/by-sa/2.0/"">CC-BY-SA</a>, Imagery © <a href=""https://mapbox.com"">Mapbox</a>',
                maxZoom: 18,
                id: 'mapbox.streets',
                accessToken: 'pk.eyJ1IjoiYmJyb29rMTU0IiwiYSI6ImNpcXN3dnJrdDAwMGNmd250bjhvZXpnbWsifQ.Nf9Zkfchos577IanoKMoYQ'
            }).addTo(mymap);

            marker3 = L.marker(latlng).addTo(mymap);
        });
    }




 window.onload = function() {
     
    document.getElementById(""my_audio"").play();
    
       
  
 }

 

function ca(phone)
  {
      if(phone==document.getElementById('phoneclient').value)
      {
          window.location.href=""/Admin/home/privacy"";

      }
   
          
    
         
    
  }


</script>


<div class=""col-4 d-none""><input type=""text"" id=""userInput""");
            BeginWriteAttribute("value", " value=\"", 11739, "\"", 11763, 1);
#nullable restore
#line 402 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\mapclient\mapclient.cshtml"
WriteAttributeValue("", 11747, Model.UserPhone, 11747, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></div>\r\n  <div class=\"col-4 d-none\"><input type=\"text\" id=\"messageInput\"");
            BeginWriteAttribute("value", " value=\"", 11839, "\"", 11869, 1);
#nullable restore
#line 403 "C:\Users\my pc\Desktop\taxiclon\map\map\Areas\Admin\Views\mapclient\mapclient.cshtml"
WriteAttributeValue("", 11847, User.Identity.GetId(), 11847, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></div>\r\n  <input type=\"button\" id=\"sendButton\" onclick=\"a();\" value=\"Send Message\" class=\"d-none\" />\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f87b8cfe006286699e55585a460b972bf42c95b31754", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  <script> src=\"~/js/chat.js\"></script>\r\n  <script>\r\n       function sa(phone,driverid)\r\n  {\r\n      if(phone==document.getElementById(\'phoneclient\').value && driverid==document.getElementById(\'messageInput\').value )\r\n      {\r\n");
            WriteLiteral("           \r\n           \r\n              window.location.href=\"/Admin/mapaccept/mapaccept?phone=\"+phone;\r\n           \r\n            \r\n      }else{\r\n           window.location.href=\"/Admin/home/privacy\";\r\n\r\n      }\r\n   \r\n       \r\n    \r\n  }\r\n\r\n  </script>\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataLayer.Entites.Tbl_Travel> Html { get; private set; }
    }
}
#pragma warning restore 1591
