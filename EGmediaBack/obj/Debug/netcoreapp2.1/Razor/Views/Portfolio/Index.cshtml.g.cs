#pragma checksum "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Portfolio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a9686134a9bcaaea0661cc69bbe6f6f5874d489"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_Index), @"mvc.1.0.view", @"/Views/Portfolio/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Portfolio/Index.cshtml", typeof(AspNetCore.Views_Portfolio_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a9686134a9bcaaea0661cc69bbe6f6f5874d489", @"/Views/Portfolio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36b4d0d1144ab4353627fe4dc794c8b22fe07b7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Portfolio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PortfolioVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 1118, true);
            WriteLiteral(@"<section id=""breadcrumb"">
    <div class=""page-name-wrapper"" style=""background-image: url(img/contact-bg.jpg);"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12 text-center"">
                    <div class=""page-name"">
                        <h1>Portfolio</h1>
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
                            <a href="""">Ana səhifə</a>
                        </li>
                        <li>
                            Portfolio
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>

<section id=""portfolio-page"">
    <div class=""container"">
        <div class=""row category-names"">
   ");
            WriteLiteral("         <ul>\n                <li><a href=\"#\" class=\"is-checked\" data-filter=\"*\">All</a></li>\n");
            EndContext();
#line 37 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Portfolio\Index.cshtml"
                 foreach (var category in Model.projectCategories)
                {

#line default
#line hidden
            BeginContext(1222, 59, true);
            WriteLiteral("                    <li><a href=\"#\" data-filter=\".category-");
            EndContext();
            BeginContext(1282, 11, false);
#line 39 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Portfolio\Index.cshtml"
                                                      Write(category.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1293, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(1296, 13, false);
#line 39 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Portfolio\Index.cshtml"
                                                                    Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1309, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 40 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Portfolio\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1337, 74, true);
            WriteLiteral("            </ul>\n        </div>\n        <div class=\"row filtered-items\">\n");
            EndContext();
#line 44 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Portfolio\Index.cshtml"
             foreach (var project in Model.projects)
            {

#line default
#line hidden
            BeginContext(1478, 20, true);
            WriteLiteral("                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1498, "\"", 1571, 5);
            WriteAttributeValue("", 1506, "col-sm-6", 1506, 8, true);
            WriteAttributeValue(" ", 1514, "col-lg-4", 1515, 9, true);
            WriteAttributeValue(" ", 1523, "filter-item", 1524, 12, true);
            WriteAttributeValue(" ", 1535, "category-", 1536, 10, true);
#line 46 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 1545, project.ProjectCategoryId, 1545, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1572, 25, true);
            WriteLiteral(" data-category=\"category-");
            EndContext();
            BeginContext(1598, 25, false);
#line 46 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Portfolio\Index.cshtml"
                                                                                                                  Write(project.ProjectCategoryId);

#line default
#line hidden
            EndContext();
            BeginContext(1623, 171, true);
            WriteLiteral("\">\n                    <div class=\"item\">\n                        <a href=\"#\">\n                            <div class=\"image-wrapper\">\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1794, "\"", 1821, 2);
            WriteAttributeValue("", 1800, "img/", 1800, 4, true);
#line 50 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 1804, project.ImageUrl, 1804, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1822, 193, true);
            WriteLiteral(" alt=\"\">\n                            </div>\n                            <div class=\"content\">\n                                <div class=\"text-wrapper\">\n                                    <h1>");
            EndContext();
            BeginContext(2016, 12, false);
#line 54 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Portfolio\Index.cshtml"
                                   Write(project.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2028, 215, true);
            WriteLiteral("</h1>\n                                    <p>Daha ətraflı</p>\n                                </div>\n                            </div>\n                        </a>\n                    </div>\n                </div>\n");
            EndContext();
#line 61 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Portfolio\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2257, 37, true);
            WriteLiteral("\n        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PortfolioVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
