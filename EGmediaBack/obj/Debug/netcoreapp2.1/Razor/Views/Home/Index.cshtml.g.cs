#pragma checksum "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3f6f4c53902c9e12980dfadacedc37b225904e4"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3f6f4c53902c9e12980dfadacedc37b225904e4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36b4d0d1144ab4353627fe4dc794c8b22fe07b7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
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
            BeginContext(298, 58, true);
            WriteLiteral("                        <div class=\"slider-item\" data-id=\"");
            EndContext();
            BeginContext(358, 3, false);
#line 9 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                                                      Write(i+1);

#line default
#line hidden
            EndContext();
            BeginContext(362, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 363, "\"", 435, 4);
            WriteAttributeValue("", 371, "background-image:", 371, 17, true);
            WriteAttributeValue(" ", 388, "url(img/", 389, 9, true);
#line 9 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 397, Model.sliders.ElementAt(i).ImageUrl, 397, 36, false);

#line default
#line hidden
            WriteAttributeValue("", 433, ");", 433, 2, true);
            EndWriteAttribute();
            BeginContext(436, 94, true);
            WriteLiteral(">\n                            <div class=\"content\">\n                                <h1><span>");
            EndContext();
            BeginContext(531, 44, false);
#line 11 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                                     Write(Model.sliders.ElementAt(i).Header_First_Word);

#line default
#line hidden
            EndContext();
            BeginContext(575, 8, true);
            WriteLiteral("</span> ");
            EndContext();
            BeginContext(584, 45, false);
#line 11 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                                                                                          Write(Model.sliders.ElementAt(i).Header_Second_Word);

#line default
#line hidden
            EndContext();
            BeginContext(629, 41, true);
            WriteLiteral("</h1>\n                                <p>");
            EndContext();
            BeginContext(671, 34, false);
#line 12 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                              Write(Model.sliders.ElementAt(i).Content);

#line default
#line hidden
            EndContext();
            BeginContext(705, 71, true);
            WriteLiteral("</p>\n                            </div>\n                        </div>\n");
            EndContext();
#line 15 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(798, 103, true);
            WriteLiteral("                </div>\n            </div>\n        </div>\n        <div class=\"slider-right-side-aside\">\n");
            EndContext();
#line 20 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
             for (int i = 0; i < Model.sliders.Count(); i++)
            {

#line default
#line hidden
            BeginContext(976, 54, true);
            WriteLiteral("                <div class=\"right-side-item\" data-id=\"");
            EndContext();
            BeginContext(1032, 3, false);
#line 22 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                                                  Write(i+1);

#line default
#line hidden
            EndContext();
            BeginContext(1036, 27, true);
            WriteLiteral("\">\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1063, "\"", 1115, 2);
            WriteAttributeValue("", 1069, "img/", 1069, 4, true);
#line 23 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 1073, Model.sliders.ElementAt(i).Aside_ImageUrl, 1073, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1116, 32, true);
            WriteLiteral(" alt=\"\">\n                    <p>");
            EndContext();
            BeginContext(1149, 39, false);
#line 24 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                  Write(Model.sliders.ElementAt(i).Aside_Header);

#line default
#line hidden
            EndContext();
            BeginContext(1188, 28, true);
            WriteLiteral("</p>\n                </div>\n");
            EndContext();
#line 26 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1230, 118, true);
            WriteLiteral("        </div>\n    </div>\n</section>\n\n<section id=\"advantages\">\n    <div class=\"container\">\n        <div class=\"row\">\n");
            EndContext();
#line 34 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
             for (int i = 0; i < Model.advantages.Count(); i++)
            {

#line default
#line hidden
            BeginContext(1426, 20, true);
            WriteLiteral("                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1446, "\"", 1499, 3);
            WriteAttributeValue("", 1454, "col-6", 1454, 5, true);
#line 36 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1459, i > 1 ? "mt-3 mt-md-0" : "", 1460, 30, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1490, "col-md-3", 1491, 9, true);
            EndWriteAttribute();
            BeginContext(1500, 69, true);
            WriteLiteral(">\n                    <div class=\"item\">\n                        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1569, "\"", 1693, 5);
            WriteAttributeValue("", 1577, "icon-wrapper", 1577, 12, true);
#line 38 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1589, i == 0 ? "orange" : "", 1590, 25, false);

#line default
#line hidden
#line 38 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1615, i == 1 ? "purple" : "", 1616, 25, false);

#line default
#line hidden
#line 38 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1641, i == 2 ? "midnight" : "", 1642, 27, false);

#line default
#line hidden
#line 38 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1669, i == 3 ? "pink" : "", 1670, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1694, 30, true);
            WriteLiteral(">\n                            ");
            EndContext();
            BeginContext(1724, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7b4f63ad761f4b17887c3e0e51417cfd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1734, "~/img/", 1734, 6, true);
#line 39 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1740, Model.advantages.ElementAt(i).IconUrl, 1740, 38, false);

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
            BeginContext(1782, 60, true);
            WriteLiteral("\n                        </div>\n                        <h4>");
            EndContext();
            BeginContext(1843, 37, false);
#line 41 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                       Write(Model.advantages.ElementAt(i).Content);

#line default
#line hidden
            EndContext();
            BeginContext(1880, 56, true);
            WriteLiteral("</h4>\n                    </div>\n                </div>\n");
            EndContext();
#line 44 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1950, 3895, true);
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
        <div class=""row"">
            <div class=""col-12"">
                <div class=""prev"">
                    <span>PREV</span>
                </div>
                <div class=""next"">
                    <span>NEXT</span>
                </div>
                <div class=""slide-wrapper"">
                    <div class=""slide active"" data-id=""1"" style=""background-image: url(img/service-1.jpg);"">
                        <a href=""#"">
                            <div class=""content"">
                                <h1>Service 1</h1>
                            </div>
                        </a>
                    </div>
                    <div class=""slide"" data-id=""2"" style=""background-image: url(img/service-1.jpg);"">
                        <a href=""#"">
          ");
            WriteLiteral(@"                  <div class=""content"">
                                <h1>Service 2</h1>
                            </div>
                        </a>
                    </div>
                    <div class=""slide"" data-id=""3"" style=""background-image: url(img/service-1.jpg);"">
                        <a href=""#"">
                            <div class=""content"">
                                <h1>Service 3</h1>
                            </div>
                        </a>
                    </div>
                    <div class=""slide"" data-id=""4"" style=""background-image: url(img/service-1.jpg);"">
                        <a href=""#"">
                            <div class=""content"">
                                <h1>Service 4</h1>
                            </div>
                        </a>
                    </div>
                    <div class=""slide"" data-id=""5"" style=""background-image: url(img/service-1.jpg);"">
                        <a href=""#"">
                            <div class=""c");
            WriteLiteral(@"ontent"">
                                <h1>Service 5</h1>
                            </div>
                        </a>
                    </div>
                </div>
                <div class=""pagination""
                     style=""transform: translate(-50%, -50%) rotate(0deg); transition: transform 1000ms ease 0s;"">
                    <div class=""item active"" data-id=""1"">
                        <div class=""dot"">
                            <i class=""fas fa-laptop-code""></i>
                        </div>
                    </div>
                    <div class=""item"" data-id=""2"">
                        <div class=""dot"">
                            <i class=""fas fa-laptop-code""></i>
                        </div>
                    </div>
                    <div class=""item"" data-id=""3"">
                        <div class=""dot"">
                            <i class=""fas fa-laptop-code""></i>
                        </div>
                    </div>
                    <div class=""item"" data-id=");
            WriteLiteral(@"""4"">
                        <div class=""dot"">
                            <i class=""fas fa-laptop-code""></i>
                        </div>
                    </div>
                    <div class=""item"" data-id=""5"">
                        <div class=""dot"">
                            <i class=""fas fa-laptop-code""></i>
                        </div>
                    </div>
                </div>
            </div>
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
#line 146 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                     for (int i = 0; i < 3; i++)
                    {

#line default
#line hidden
            BeginContext(5916, 28, true);
            WriteLiteral("                        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5944, "\"", 5986, 2);
#line 148 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 5952, i == 0 ? "col-12" : "col-6", 5952, 30, false);

#line default
#line hidden
            WriteAttributeValue(" ", 5982, "p-0", 5983, 4, true);
            EndWriteAttribute();
            BeginContext(5987, 78, true);
            WriteLiteral(">\n                            <a href=\"\">\n                                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 6065, "\"", 6117, 2);
#line 150 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 6073, i == 0 ? "large-item" : "small-item", 6073, 39, false);

#line default
#line hidden
            WriteAttributeValue(" ", 6112, "item", 6113, 5, true);
            EndWriteAttribute();
            BeginContext(6118, 110, true);
            WriteLiteral(">\n                                    <div class=\"image-wrapper\">\n                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 6228, "\"", 6280, 2);
            WriteAttributeValue("", 6234, "img/", 6234, 4, true);
#line 152 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 6238, Model.projects.ElementAt(i).Home_ImageUrl, 6238, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6281, 398, true);
            WriteLiteral(@" alt="""">
                                    </div>
                                    <div class=""content"">
                                        <div class=""icon"">
                                            <i class=""fas fa-arrow-right""></i>
                                        </div>
                                        <div class=""name"">
                                            ");
            EndContext();
            BeginContext(6680, 32, false);
#line 159 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                                       Write(Model.projects.ElementAt(i).Name);

#line default
#line hidden
            EndContext();
            BeginContext(6712, 194, true);
            WriteLiteral("\n                                        </div>\n                                    </div>\n                                </div>\n                            </a>\n                        </div>\n");
            EndContext();
#line 165 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(6928, 119, true);
            WriteLiteral("                </div>\n            </div>\n            <div class=\"col-sm-6 p-0\">\n                <div class=\"row m-0\">\n");
            EndContext();
#line 170 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                     for (int i = 3; i < Model.projects.Count(); i++)
                    {

#line default
#line hidden
            BeginContext(7139, 28, true);
            WriteLiteral("                        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 7167, "\"", 7232, 2);
#line 172 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 7175, i == Model.projects.Count()-1 ? "col-12" : "col-6", 7175, 53, false);

#line default
#line hidden
            WriteAttributeValue(" ", 7228, "p-0", 7229, 4, true);
            EndWriteAttribute();
            BeginContext(7233, 78, true);
            WriteLiteral(">\n                            <a href=\"\">\n                                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 7311, "\"", 7386, 2);
#line 174 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 7319, i == Model.projects.Count()-1 ? "large-item" : "small-item", 7319, 62, false);

#line default
#line hidden
            WriteAttributeValue(" ", 7381, "item", 7382, 5, true);
            EndWriteAttribute();
            BeginContext(7387, 110, true);
            WriteLiteral(">\n                                    <div class=\"image-wrapper\">\n                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 7497, "\"", 7549, 2);
            WriteAttributeValue("", 7503, "img/", 7503, 4, true);
#line 176 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 7507, Model.projects.ElementAt(i).Home_ImageUrl, 7507, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7550, 398, true);
            WriteLiteral(@" alt="""">
                                    </div>
                                    <div class=""content"">
                                        <div class=""icon"">
                                            <i class=""fas fa-arrow-right""></i>
                                        </div>
                                        <div class=""name"">
                                            ");
            EndContext();
            BeginContext(7949, 32, false);
#line 183 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                                       Write(Model.projects.ElementAt(i).Name);

#line default
#line hidden
            EndContext();
            BeginContext(7981, 194, true);
            WriteLiteral("\n                                        </div>\n                                    </div>\n                                </div>\n                            </a>\n                        </div>\n");
            EndContext();
#line 189 "C:\Users\User\Desktop\EGmediaBack\EGmediaBack\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(8197, 371, true);
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
            BeginContext(8568, 841, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21ea4c7f8f92464598a607aae2c283a4", async() => {
                BeginContext(8588, 814, true);
                WriteLiteral(@"
                    <div class=""col-md-4 mt-3 mt-md-0"">
                        <input type=""text"" placeholder=""Adınız, Soyadınız"">
                    </div>
                    <div class=""col-md-4 mt-3 mt-md-0"">
                        <input type=""text"" placeholder=""Əlaqə nömrəniz"">
                    </div>
                    <div class=""col-md-4 mt-3 mt-md-0"">
                        <input type=""text"" placeholder=""E-mailiniz"">
                    </div>
                    <div class=""col-md-12 mt-3"">
                        <textarea name="""" id="""" cols=""30"" rows=""7"" placeholder=""Mesajınız""></textarea>
                    </div>
                    <div class=""col-12 text-right mt-3"">
                        <input type=""submit"" value=""Sorğu göndər"">
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9409, 56, true);
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
