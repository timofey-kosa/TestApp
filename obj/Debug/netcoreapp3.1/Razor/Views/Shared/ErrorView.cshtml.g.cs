#pragma checksum "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Shared\ErrorView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0a6f5a02c4023714cefa3859f32bca380ca8ea9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ErrorView), @"mvc.1.0.view", @"/Views/Shared/ErrorView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0a6f5a02c4023714cefa3859f32bca380ca8ea9", @"/Views/Shared/ErrorView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e25db771d30abaf29d3599c25e6deb12289bab6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ErrorView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestApp.Models.ErrorModel.ResponseException>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"alert alert-danger alert-dismissible\">\r\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\">&times;</button>\r\n    <p> <strong>");
#nullable restore
#line 4 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Shared\ErrorView.cshtml"
           Write(Model.ExceptionMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n    <p> <strong>");
#nullable restore
#line 5 "D:\Prog\c#\Web\bambtestapp\TestApp\TestApp\Views\Shared\ErrorView.cshtml"
           Write(Model.ResponseMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestApp.Models.ErrorModel.ResponseException> Html { get; private set; }
    }
}
#pragma warning restore 1591