#pragma checksum "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dbcc799c7c1d8dde764040abfb2afda0b6aaf19"
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
#line 1 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\_ViewImports.cshtml"
using EGmediaBack;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\_ViewImports.cshtml"
using EGmediaBack.Models;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\_ViewImports.cshtml"
using EGmediaBack.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dbcc799c7c1d8dde764040abfb2afda0b6aaf19", @"/Views/Home/Index.cshtml")]
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
#line 7 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                     for (int i = 0; i < Model.sliders.Count(); i++)
                    {

#line default
#line hidden
            BeginContext(298, 42, true);
            WriteLiteral("        <div class=\"slider-item\" data-id=\"");
            EndContext();
            BeginContext(342, 3, false);
#line 9 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
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
#line 9 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 381, Model.sliders.ElementAt(i).ImageUrl, 381, 36, false);

#line default
#line hidden
            WriteAttributeValue("", 417, ");", 417, 2, true);
            EndWriteAttribute();
            BeginContext(420, 62, true);
            WriteLiteral(">\n            <div class=\"content\">\n                <h1><span>");
            EndContext();
            BeginContext(483, 44, false);
#line 11 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                     Write(Model.sliders.ElementAt(i).Header_First_Word);

#line default
#line hidden
            EndContext();
            BeginContext(527, 8, true);
            WriteLiteral("</span> ");
            EndContext();
            BeginContext(536, 45, false);
#line 11 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                                                                          Write(Model.sliders.ElementAt(i).Header_Second_Word);

#line default
#line hidden
            EndContext();
            BeginContext(581, 25, true);
            WriteLiteral("</h1>\n                <p>");
            EndContext();
            BeginContext(607, 34, false);
#line 12 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
              Write(Model.sliders.ElementAt(i).Content);

#line default
#line hidden
            EndContext();
            BeginContext(641, 38, true);
            WriteLiteral("</p>\n            </div>\n        </div>");
            EndContext();
#line 14 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
              }

#line default
#line hidden
            BeginContext(681, 103, true);
            WriteLiteral("                </div>\n            </div>\n        </div>\n        <div class=\"slider-right-side-aside\">\n");
            EndContext();
#line 19 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
             for (int i = 0; i < Model.sliders.Count(); i++)
            {

#line default
#line hidden
            BeginContext(859, 38, true);
            WriteLiteral("<div class=\"right-side-item\" data-id=\"");
            EndContext();
            BeginContext(899, 3, false);
#line 21 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                                  Write(i+1);

#line default
#line hidden
            EndContext();
            BeginContext(903, 11, true);
            WriteLiteral("\">\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 914, "\"", 966, 2);
            WriteAttributeValue("", 920, "img/", 920, 4, true);
#line 22 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 924, Model.sliders.ElementAt(i).Aside_ImageUrl, 924, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(967, 16, true);
            WriteLiteral(" alt=\"\">\n    <p>");
            EndContext();
            BeginContext(984, 39, false);
#line 23 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
  Write(Model.sliders.ElementAt(i).Aside_Header);

#line default
#line hidden
            EndContext();
            BeginContext(1023, 23, true);
            WriteLiteral("</p>\n</div>            ");
            EndContext();
#line 24 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                  }

#line default
#line hidden
            BeginContext(1048, 118, true);
            WriteLiteral("        </div>\n    </div>\n</section>\n\n<section id=\"advantages\">\n    <div class=\"container\">\n        <div class=\"row\">\n");
            EndContext();
#line 32 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
             for (int i = 0; i < Model.advantages.Count(); i++)
            {

#line default
#line hidden
            BeginContext(1244, 4, true);
            WriteLiteral("<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1248, "\"", 1301, 3);
            WriteAttributeValue("", 1256, "col-6", 1256, 5, true);
#line 34 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1261, i > 1 ? "mt-3 mt-md-0" : "", 1262, 30, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1292, "col-md-3", 1293, 9, true);
            EndWriteAttribute();
            BeginContext(1302, 37, true);
            WriteLiteral(">\n    <div class=\"item\">\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1339, "\"", 1463, 5);
            WriteAttributeValue("", 1347, "icon-wrapper", 1347, 12, true);
#line 36 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1359, i == 0 ? "orange" : "", 1360, 25, false);

#line default
#line hidden
#line 36 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1385, i == 1 ? "purple" : "", 1386, 25, false);

#line default
#line hidden
#line 36 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1411, i == 2 ? "midnight" : "", 1412, 27, false);

#line default
#line hidden
#line 36 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1439, i == 3 ? "pink" : "", 1440, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1464, 14, true);
            WriteLiteral(">\n            ");
            EndContext();
            BeginContext(1478, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "399705a038814f70b93472d6e8631fec", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1488, "~/img/", 1488, 6, true);
#line 37 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1494, Model.advantages.ElementAt(i).IconUrl, 1494, 38, false);

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
            BeginContext(1536, 28, true);
            WriteLiteral("\n        </div>\n        <h4>");
            EndContext();
            BeginContext(1565, 37, false);
#line 39 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
       Write(Model.advantages.ElementAt(i).Content);

#line default
#line hidden
            EndContext();
            BeginContext(1602, 35, true);
            WriteLiteral("</h4>\n    </div>\n</div>            ");
            EndContext();
#line 41 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                  }

#line default
#line hidden
            BeginContext(1639, 383, true);
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
#line 57 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                 foreach (var service in Model.serviceCategories)
                {

#line default
#line hidden
            BeginContext(2106, 81, true);
            WriteLiteral("                    <li class=\"block\">\n                        <div class=\"icon\">");
            EndContext();
            BeginContext(2187, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9c45943430f24ba7bfe23f17fdb68e7f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2197, "~/img/", 2197, 6, true);
#line 60 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2203, service.IconUrl, 2203, 16, false);

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
            BeginContext(2223, 33, true);
            WriteLiteral("</div>\n                    </li>\n");
            EndContext();
#line 62 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2274, 60, true);
            WriteLiteral("            </ul>\n            <div class=\"animate-wrapper\">\n");
            EndContext();
#line 65 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                 foreach (var service in Model.serviceCategories)
                {

#line default
#line hidden
            BeginContext(2418, 66, true);
            WriteLiteral("                    <div class=\"animate\">\n                        ");
            EndContext();
            BeginContext(2484, 493, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "208ce5f0f0c54bd1847b90e1a8813415", async() => {
                BeginContext(2552, 74, true);
                WriteLiteral("\n                            <div class=\"animate-img__in\" data-image=\"img/");
                EndContext();
                BeginContext(2627, 16, false);
#line 69 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                                                                    Write(service.ImageUrl);

#line default
#line hidden
                EndContext();
                BeginContext(2643, 170, true);
                WriteLiteral("\">\n                                <div class=\"animate-more\">\n                                    <div class=\"animate-title\">\n                                        <h4>");
                EndContext();
                BeginContext(2814, 12, false);
#line 72 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                                       Write(service.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2826, 147, true);
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
            BeginContext(2977, 28, true);
            WriteLiteral("\n                    </div>\n");
            EndContext();
#line 78 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3023, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(7593, 528, true);
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
#line 187 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                     for (int i = 0; i < 3; i++)
                    {

#line default
#line hidden
            BeginContext(8192, 12, true);
            WriteLiteral("        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 8204, "\"", 8246, 2);
#line 189 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 8212, i == 0 ? "col-12" : "col-6", 8212, 30, false);

#line default
#line hidden
            WriteAttributeValue(" ", 8242, "p-0", 8243, 4, true);
            EndWriteAttribute();
            BeginContext(8247, 46, true);
            WriteLiteral(">\n            <a href=\"\">\n                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 8293, "\"", 8345, 2);
#line 191 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 8301, i == 0 ? "large-item" : "small-item", 8301, 39, false);

#line default
#line hidden
            WriteAttributeValue(" ", 8340, "item", 8341, 5, true);
            EndWriteAttribute();
            BeginContext(8346, 78, true);
            WriteLiteral(">\n                    <div class=\"image-wrapper\">\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 8424, "\"", 8476, 2);
            WriteAttributeValue("", 8430, "img/", 8430, 4, true);
#line 193 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 8434, Model.projects.ElementAt(i).Home_ImageUrl, 8434, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8477, 286, true);
            WriteLiteral(@" alt="""">
                    </div>
                    <div class=""content"">
                        <div class=""icon"">
                            <i class=""fas fa-arrow-right""></i>
                        </div>
                        <div class=""name"">
                            ");
            EndContext();
            BeginContext(8764, 32, false);
#line 200 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                       Write(Model.projects.ElementAt(i).Name);

#line default
#line hidden
            EndContext();
            BeginContext(8796, 113, true);
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n            </a>\n        </div>");
            EndContext();
#line 205 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
              }

#line default
#line hidden
            BeginContext(8911, 119, true);
            WriteLiteral("                </div>\n            </div>\n            <div class=\"col-sm-6 p-0\">\n                <div class=\"row m-0\">\n");
            EndContext();
#line 210 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                     for (int i = 3; i < Model.projects.Count(); i++)
                    {

#line default
#line hidden
            BeginContext(9122, 12, true);
            WriteLiteral("        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 9134, "\"", 9199, 2);
#line 212 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 9142, i == Model.projects.Count()-1 ? "col-12" : "col-6", 9142, 53, false);

#line default
#line hidden
            WriteAttributeValue(" ", 9195, "p-0", 9196, 4, true);
            EndWriteAttribute();
            BeginContext(9200, 46, true);
            WriteLiteral(">\n            <a href=\"\">\n                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 9246, "\"", 9321, 2);
#line 214 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 9254, i == Model.projects.Count()-1 ? "large-item" : "small-item", 9254, 62, false);

#line default
#line hidden
            WriteAttributeValue(" ", 9316, "item", 9317, 5, true);
            EndWriteAttribute();
            BeginContext(9322, 78, true);
            WriteLiteral(">\n                    <div class=\"image-wrapper\">\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 9400, "\"", 9452, 2);
            WriteAttributeValue("", 9406, "img/", 9406, 4, true);
#line 216 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 9410, Model.projects.ElementAt(i).Home_ImageUrl, 9410, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9453, 286, true);
            WriteLiteral(@" alt="""">
                    </div>
                    <div class=""content"">
                        <div class=""icon"">
                            <i class=""fas fa-arrow-right""></i>
                        </div>
                        <div class=""name"">
                            ");
            EndContext();
            BeginContext(9740, 32, false);
#line 223 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                       Write(Model.projects.ElementAt(i).Name);

#line default
#line hidden
            EndContext();
            BeginContext(9772, 113, true);
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n            </a>\n        </div>");
            EndContext();
#line 228 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
              }

#line default
#line hidden
            BeginContext(9887, 371, true);
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
            BeginContext(10258, 1039, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c22fe0c153da4be3873c99fc4f229165", async() => {
                BeginContext(10278, 143, true);
                WriteLiteral("\n                    <div class=\"col-12 validation-div\"></div>\n                    <div class=\"col-md-4 mt-3 mt-md-0\">\n                        ");
                EndContext();
                BeginContext(10421, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b72e471c76844a31b90df98ecfe37e5e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 248 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
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
                BeginContext(10485, 108, true);
                WriteLiteral("\n                    </div>\n                    <div class=\"col-md-4 mt-3 mt-md-0\">\n                        ");
                EndContext();
                BeginContext(10593, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0f056e5225a64f07b50484fdc6d5f331", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 251 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
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
                BeginContext(10657, 108, true);
                WriteLiteral("\n                    </div>\n                    <div class=\"col-md-4 mt-3 mt-md-0\">\n                        ");
                EndContext();
                BeginContext(10765, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f5fe8b129c014602b727010445f042d1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 254 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
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
                BeginContext(10819, 101, true);
                WriteLiteral("\n                    </div>\n                    <div class=\"col-md-12 mt-3\">\n                        ");
                EndContext();
                BeginContext(10920, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b335dbaa8fd141088bc887b09c40c0a0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 257 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
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
                BeginContext(10989, 85, true);
                WriteLiteral("\n                    </div>\n                    <div class=\"col-12 text-right mt-3\">\n");
                EndContext();
                BeginContext(11152, 138, true);
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
            BeginContext(11297, 56, true);
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
