#pragma checksum "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f40782848eb8b07eeb23240e7c1a13310450da0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/About/Index.cshtml", typeof(AspNetCore.Views_About_Index))]
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
#line 1 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\_ViewImports.cshtml"
using EGmediaBack;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\_ViewImports.cshtml"
using EGmediaBack.Models;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\_ViewImports.cshtml"
using EGmediaBack.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f40782848eb8b07eeb23240e7c1a13310450da0", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36b4d0d1144ab4353627fe4dc794c8b22fe07b7f", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<About>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 61, true);
            WriteLiteral("<section id=\"breadcrumb\">\r\n    <div class=\"page-name-wrapper\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 75, "\"", 126, 4);
            WriteAttributeValue("", 83, "background-image:", 83, 17, true);
            WriteAttributeValue(" ", 100, "url(img/", 101, 9, true);
#line 3 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\About\Index.cshtml"
WriteAttributeValue("", 109, ViewBag.Banner, 109, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 124, ");", 124, 2, true);
            EndWriteAttribute();
            BeginContext(127, 976, true);
            WriteLiteral(@">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12 text-center"">
                    <div class=""page-name"">
                        <h1>Haqqımızda</h1>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""aside"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <ul class=""d-flex justify-content-center"">
                        <li class=""slash"">
                            <a href=""/"">Ana səhifə</a>
                        </li>
                        <li>
                            Haqqımızda
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>

<section id=""about-page"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                ");
            EndContext();
            BeginContext(1104, 23, false);
#line 36 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\About\Index.cshtml"
           Write(Html.Raw(Model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<About> Html { get; private set; }
    }
}
#pragma warning restore 1591
