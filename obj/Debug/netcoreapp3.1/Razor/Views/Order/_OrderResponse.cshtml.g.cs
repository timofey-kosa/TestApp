#pragma checksum "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Order\_OrderResponse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b56ff17e5b1230ad2a71fe13a4db56d8741aa88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order__OrderResponse), @"mvc.1.0.view", @"/Views/Order/_OrderResponse.cshtml")]
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
#line 1 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\_ViewImports.cshtml"
using TestApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\_ViewImports.cshtml"
using TestApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b56ff17e5b1230ad2a71fe13a4db56d8741aa88", @"/Views/Order/_OrderResponse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e25db771d30abaf29d3599c25e6deb12289bab6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Order__OrderResponse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderResponse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Order\_OrderResponse.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\" style=\"float:left;\">\r\n    <table class=\"table table-bordered  table-hover  table-sm table-dark\" style=\"word-wrap:break-word;\">\r\n\r\n        <tr>\r\n            <th>RequestId : ");
#nullable restore
#line 11 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Order\_OrderResponse.cshtml"
                       Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>OrderId : ");
#nullable restore
#line 12 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Order\_OrderResponse.cshtml"
                     Write(Model.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>Total : ");
#nullable restore
#line 13 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Order\_OrderResponse.cshtml"
                   Write(Model.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n        </tr>\r\n\r\n        <tr>\r\n            <th>Cards</th>\r\n        </tr>\r\n        <tr>\r\n            <th>CardCode</th>\r\n            <th>SerialNumber</th>\r\n            <th>Pin</th>\r\n            <th>Url</th>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 26 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Order\_OrderResponse.cshtml"
         foreach (var item in Model.Items)
        {
            foreach (var card in item.Cards)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"border\">\r\n                    <td class=\"even\" style=\"width:20px;\">");
#nullable restore
#line 31 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Order\_OrderResponse.cshtml"
                                                    Write(card.CardCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\" even\" style=\"width:20px;\">");
#nullable restore
#line 32 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Order\_OrderResponse.cshtml"
                                                     Write(card.SerialNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\" even\">");
#nullable restore
#line 33 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Order\_OrderResponse.cshtml"
                                 Write(card.Pin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"even \" style=\"width:20px;\">");
#nullable restore
#line 34 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Order\_OrderResponse.cshtml"
                                                     Write(card.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\r\n                </tr>\r\n");
#nullable restore
#line 36 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Order\_OrderResponse.cshtml"
            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <tr>\r\n            <th>FailureMessages</th>\r\n        </tr>\r\n");
#nullable restore
#line 43 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Order\_OrderResponse.cshtml"
         foreach (var item in Model.Items)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Order\_OrderResponse.cshtml"
             foreach (var fail in item.Failures)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"even\">");
#nullable restore
#line 48 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Order\_OrderResponse.cshtml"
                                Write(fail.FailureMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 51 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Order\_OrderResponse.cshtml"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Order\_OrderResponse.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n    </table>\r\n</div>\r\n");
#nullable restore
#line 60 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Order\_OrderResponse.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger alert-dismissible\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">&times;</button>\r\n        <strong>");
#nullable restore
#line 66 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Order\_OrderResponse.cshtml"
           Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n    </div>\r\n");
#nullable restore
#line 68 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Order\_OrderResponse.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
