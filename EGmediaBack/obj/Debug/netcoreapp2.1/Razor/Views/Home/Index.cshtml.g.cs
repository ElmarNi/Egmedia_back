#pragma checksum "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5824f32a63d1fcf03874066664ae923b30a5a059"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5824f32a63d1fcf03874066664ae923b30a5a059", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36b4d0d1144ab4353627fe4dc794c8b22fe07b7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Services", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("animate-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Adınız, Soyadınız"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Əlaqə nömrəniz"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("E-mailiniz"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Mesajınız"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 193, true);
            WriteLiteral("<section id=\"slider\">\n    <div class=\"two-side-wrapper\">\n        <div class=\"slider-left-side-wrapper\">\n            <div class=\"left-side\">\n                <div class=\"owl-carousel owl-theme\">\n");
            EndContext();
#line 7 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                     for (int i = 0; i < Model.sliders.Count(); i++)
                    {

#line default
#line hidden
            BeginContext(298, 42, true);
            WriteLiteral("        <div class=\"slider-item\" data-id=\"");
            EndContext();
            BeginContext(342, 3, false);
#line 9 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                                      Write(i+1);

#line default
#line hidden
            EndContext();
            BeginContext(346, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 347, "\"", 419, 4);
            WriteAttributeValue("", 355, "background-image:", 355, 17, true);
            WriteAttributeValue(" ", 372, "url(img/", 373, 9, true);
#line 9 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 381, Model.sliders.ElementAt(i).ImageUrl, 381, 36, false);

#line default
#line hidden
            WriteAttributeValue("", 417, ");", 417, 2, true);
            EndWriteAttribute();
            BeginContext(420, 62, true);
            WriteLiteral(">\n            <div class=\"content\">\n                <h1><span>");
            EndContext();
            BeginContext(483, 44, false);
#line 11 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                     Write(Model.sliders.ElementAt(i).Header_First_Word);

#line default
#line hidden
            EndContext();
            BeginContext(527, 8, true);
            WriteLiteral("</span> ");
            EndContext();
            BeginContext(536, 45, false);
#line 11 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                                                                          Write(Model.sliders.ElementAt(i).Header_Second_Word);

#line default
#line hidden
            EndContext();
            BeginContext(581, 25, true);
            WriteLiteral("</h1>\n                <p>");
            EndContext();
            BeginContext(607, 34, false);
#line 12 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
              Write(Model.sliders.ElementAt(i).Content);

#line default
#line hidden
            EndContext();
            BeginContext(641, 38, true);
            WriteLiteral("</p>\n            </div>\n        </div>");
            EndContext();
#line 14 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
              }

#line default
#line hidden
            BeginContext(681, 103, true);
            WriteLiteral("                </div>\n            </div>\n        </div>\n        <div class=\"slider-right-side-aside\">\n");
            EndContext();
#line 19 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
             for (int i = 0; i < Model.sliders.Count(); i++)
            {

#line default
#line hidden
            BeginContext(859, 38, true);
            WriteLiteral("<div class=\"right-side-item\" data-id=\"");
            EndContext();
            BeginContext(899, 3, false);
#line 21 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                                  Write(i+1);

#line default
#line hidden
            EndContext();
            BeginContext(903, 11, true);
            WriteLiteral("\">\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 914, "\"", 966, 2);
            WriteAttributeValue("", 920, "img/", 920, 4, true);
#line 22 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 924, Model.sliders.ElementAt(i).Aside_ImageUrl, 924, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(967, 16, true);
            WriteLiteral(" alt=\"\">\n    <p>");
            EndContext();
            BeginContext(984, 39, false);
#line 23 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
  Write(Model.sliders.ElementAt(i).Aside_Header);

#line default
#line hidden
            EndContext();
            BeginContext(1023, 23, true);
            WriteLiteral("</p>\n</div>            ");
            EndContext();
#line 24 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                  }

#line default
#line hidden
            BeginContext(1048, 118, true);
            WriteLiteral("        </div>\n    </div>\n</section>\n\n<section id=\"advantages\">\n    <div class=\"container\">\n        <div class=\"row\">\n");
            EndContext();
#line 32 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
             for (int i = 0; i < Model.advantages.Count(); i++)
            {

#line default
#line hidden
            BeginContext(1244, 20, true);
            WriteLiteral("                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1264, "\"", 1317, 3);
            WriteAttributeValue("", 1272, "col-6", 1272, 5, true);
#line 34 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1277, i > 1 ? "mt-3 mt-md-0" : "", 1278, 30, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1308, "col-md-3", 1309, 9, true);
            EndWriteAttribute();
            BeginContext(1318, 69, true);
            WriteLiteral(">\n                    <div class=\"item\">\n                        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1387, "\"", 1511, 5);
            WriteAttributeValue("", 1395, "icon-wrapper", 1395, 12, true);
#line 36 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1407, i == 0 ? "orange" : "", 1408, 25, false);

#line default
#line hidden
#line 36 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1433, i == 1 ? "purple" : "", 1434, 25, false);

#line default
#line hidden
#line 36 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1459, i == 2 ? "midnight" : "", 1460, 27, false);

#line default
#line hidden
#line 36 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1487, i == 3 ? "pink" : "", 1488, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1512, 30, true);
            WriteLiteral(">\n                            ");
            EndContext();
            BeginContext(1542, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "92b6333b377a4088bdecf6154eaeb864", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1552, "~/img/", 1552, 6, true);
#line 37 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1558, Model.advantages.ElementAt(i).IconUrl, 1558, 38, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1600, 60, true);
            WriteLiteral("\n                        </div>\n                        <h4>");
            EndContext();
            BeginContext(1661, 37, false);
#line 39 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                       Write(Model.advantages.ElementAt(i).Content);

#line default
#line hidden
            EndContext();
            BeginContext(1698, 68, true);
            WriteLiteral("</h4>\n                    </div>\n                </div>            \n");
            EndContext();
#line 42 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1780, 383, true);
            WriteLiteral(@"        </div>
    </div>
</section>

<section id=""services"">
    <div class=""container"">
        <div class=""row heading"">
            <div class=""col-12 text-center"">
                <h1>Xidmətlərimiz</h1>
            </div>
        </div>
    </div>
    <div class=""circle--slider"">
        <div class=""rotate--circle"">
            <ul class=""circle--rotate"" id=""circle--rotate"">
");
            EndContext();
#line 58 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                 foreach (var service in Model.services)
                {

#line default
#line hidden
            BeginContext(2238, 81, true);
            WriteLiteral("                    <li class=\"block\">\n                        <div class=\"icon\">");
            EndContext();
            BeginContext(2319, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1bd62d8e82684abb9b552aec42261931", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2329, "~/img/", 2329, 6, true);
#line 61 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2335, service.CategoryIconUrl, 2335, 24, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2363, 33, true);
            WriteLiteral("</div>\n                    </li>\n");
            EndContext();
#line 63 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2414, 60, true);
            WriteLiteral("            </ul>\n            <div class=\"animate-wrapper\">\n");
            EndContext();
#line 66 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                 foreach (var service in Model.services)
                {

#line default
#line hidden
            BeginContext(2549, 66, true);
            WriteLiteral("                    <div class=\"animate\">\n                        ");
            EndContext();
            BeginContext(2615, 509, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3da1d32146ac4f3d9927adebeb5a26fe", async() => {
                BeginContext(2683, 74, true);
                WriteLiteral("\n                            <div class=\"animate-img__in\" data-image=\"img/");
                EndContext();
                BeginContext(2758, 24, false);
#line 70 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                                                                    Write(service.CategoryImageUrl);

#line default
#line hidden
                EndContext();
                BeginContext(2782, 170, true);
                WriteLiteral("\">\n                                <div class=\"animate-more\">\n                                    <div class=\"animate-title\">\n                                        <h4>");
                EndContext();
                BeginContext(2953, 20, false);
#line 73 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                                       Write(service.CategoryName);

#line default
#line hidden
                EndContext();
                BeginContext(2973, 147, true);
                WriteLiteral("</h4>\n                                    </div>\n                                </div>\n                            </div>\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3124, 28, true);
            WriteLiteral("\n                    </div>\n");
            EndContext();
#line 79 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3170, 544, true);
            WriteLiteral(@"                
            </div>
            <div class=""prev""><span>PREV</span></div>
            <div class=""next""><span>NEXT</span></div>
        </div>
    </div>

</section>

<section id=""portfolio"">
    <div class=""container"">
        <div class=""row heading"">
            <div class=""col-12 text-center"">
                <h1>Son işlərimiz</h1>
            </div>
        </div>
    </div>
    <div class=""container-fluid p-0"">
        <div class=""row m-0"">
            <div class=""col-sm-6 p-0"">
                <div class=""row m-0"">
");
            EndContext();
#line 101 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                     for (int i = 0; i < 3; i++)
                    {

#line default
#line hidden
            BeginContext(3785, 28, true);
            WriteLiteral("                        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3813, "\"", 3855, 2);
#line 103 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 3821, i == 0 ? "col-12" : "col-6", 3821, 30, false);

#line default
#line hidden
            WriteAttributeValue(" ", 3851, "p-0", 3852, 4, true);
            EndWriteAttribute();
            BeginContext(3856, 78, true);
            WriteLiteral(">\n                            <a href=\"\">\n                                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3934, "\"", 3986, 2);
#line 105 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 3942, i == 0 ? "large-item" : "small-item", 3942, 39, false);

#line default
#line hidden
            WriteAttributeValue(" ", 3981, "item", 3982, 5, true);
            EndWriteAttribute();
            BeginContext(3987, 110, true);
            WriteLiteral(">\n                                    <div class=\"image-wrapper\">\n                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4097, "\"", 4158, 2);
            WriteAttributeValue("", 4103, "img/", 4103, 4, true);
#line 107 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 4107, Model.projects.ElementAtOrDefault(i).Home_ImageUrl, 4107, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4159, 398, true);
            WriteLiteral(@" alt="""">
                                    </div>
                                    <div class=""content"">
                                        <div class=""icon"">
                                            <i class=""fas fa-arrow-right""></i>
                                        </div>
                                        <div class=""name"">
                                            ");
            EndContext();
            BeginContext(4558, 41, false);
#line 114 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                                       Write(Model.projects.ElementAtOrDefault(i).Name);

#line default
#line hidden
            EndContext();
            BeginContext(4599, 194, true);
            WriteLiteral("\n                                        </div>\n                                    </div>\n                                </div>\n                            </a>\n                        </div>\n");
            EndContext();
#line 120 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4815, 119, true);
            WriteLiteral("                </div>\n            </div>\n            <div class=\"col-sm-6 p-0\">\n                <div class=\"row m-0\">\n");
            EndContext();
#line 125 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                     for (int i = 3; i < Model.projects.Count(); i++)
                    {

#line default
#line hidden
            BeginContext(5026, 28, true);
            WriteLiteral("                        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5054, "\"", 5119, 2);
#line 127 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 5062, i == Model.projects.Count()-1 ? "col-12" : "col-6", 5062, 53, false);

#line default
#line hidden
            WriteAttributeValue(" ", 5115, "p-0", 5116, 4, true);
            EndWriteAttribute();
            BeginContext(5120, 78, true);
            WriteLiteral(">\n                            <a href=\"\">\n                                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5198, "\"", 5273, 2);
#line 129 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 5206, i == Model.projects.Count()-1 ? "large-item" : "small-item", 5206, 62, false);

#line default
#line hidden
            WriteAttributeValue(" ", 5268, "item", 5269, 5, true);
            EndWriteAttribute();
            BeginContext(5274, 110, true);
            WriteLiteral(">\n                                    <div class=\"image-wrapper\">\n                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5384, "\"", 5445, 2);
            WriteAttributeValue("", 5390, "img/", 5390, 4, true);
#line 131 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 5394, Model.projects.ElementAtOrDefault(i).Home_ImageUrl, 5394, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5446, 398, true);
            WriteLiteral(@" alt="""">
                                    </div>
                                    <div class=""content"">
                                        <div class=""icon"">
                                            <i class=""fas fa-arrow-right""></i>
                                        </div>
                                        <div class=""name"">
                                            ");
            EndContext();
            BeginContext(5845, 41, false);
#line 138 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                                       Write(Model.projects.ElementAtOrDefault(i).Name);

#line default
#line hidden
            EndContext();
            BeginContext(5886, 194, true);
            WriteLiteral("\n                                        </div>\n                                    </div>\n                                </div>\n                            </a>\n                        </div>\n");
            EndContext();
#line 144 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(6102, 371, true);
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>

</section>

<section id=""get-price-offer"">
    <div class=""container"">
        <div class=""row heading"">
            <div class=""col-12 text-center"">
                <h1>Qiymət təklifi al</h1>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12"">
                ");
            EndContext();
            BeginContext(6473, 1039, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d98afb355c148a08ca0d9d1adaa8467", async() => {
                BeginContext(6493, 143, true);
                WriteLiteral("\n                    <div class=\"col-12 validation-div\"></div>\n                    <div class=\"col-md-4 mt-3 mt-md-0\">\n                        ");
                EndContext();
                BeginContext(6636, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "379d9a1c7a354ddab2f2f2c37496d193", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 164 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.offer.Fullname);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6700, 108, true);
                WriteLiteral("\n                    </div>\n                    <div class=\"col-md-4 mt-3 mt-md-0\">\n                        ");
                EndContext();
                BeginContext(6808, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3de330b37fe142c0a170ac9a04eb166f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 167 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.offer.PhoneNumber);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6872, 108, true);
                WriteLiteral("\n                    </div>\n                    <div class=\"col-md-4 mt-3 mt-md-0\">\n                        ");
                EndContext();
                BeginContext(6980, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e6903a293be24bdf96ae05e361ccaab9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 170 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.offer.Email);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7034, 101, true);
                WriteLiteral("\n                    </div>\n                    <div class=\"col-md-12 mt-3\">\n                        ");
                EndContext();
                BeginContext(7135, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26d285780ab44d21bc739d39217f1cc0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 173 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.offer.Message);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7204, 85, true);
                WriteLiteral("\n                    </div>\n                    <div class=\"col-12 text-right mt-3\">\n");
                EndContext();
                BeginContext(7367, 138, true);
                WriteLiteral("                        <input type=\"submit\" id=\"get-price-offer-submit\" value=\"Sorğu göndər\">\n                    </div>\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7512, 56, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
