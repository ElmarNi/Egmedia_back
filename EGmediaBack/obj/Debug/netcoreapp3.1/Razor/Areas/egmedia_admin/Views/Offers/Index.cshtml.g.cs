#pragma checksum "/Users/ibrahimlien/Desktop/BackEnd/EGmedia/EGmediaBack/Areas/egmedia_admin/Views/Offers/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00b83c7ff6960103bede14b18bdfd574a250352e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_egmedia_admin_Views_Offers_Index), @"mvc.1.0.view", @"/Areas/egmedia_admin/Views/Offers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/egmedia_admin/Views/Offers/Index.cshtml", typeof(AspNetCore.Areas_egmedia_admin_Views_Offers_Index))]
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
#line 1 "/Users/ibrahimlien/Desktop/BackEnd/EGmedia/EGmediaBack/Areas/egmedia_admin/Views/_ViewImports.cshtml"
using EGmediaBack;

#line default
#line hidden
#line 2 "/Users/ibrahimlien/Desktop/BackEnd/EGmedia/EGmediaBack/Areas/egmedia_admin/Views/_ViewImports.cshtml"
using EGmediaBack.Models;

#line default
#line hidden
#line 3 "/Users/ibrahimlien/Desktop/BackEnd/EGmedia/EGmediaBack/Areas/egmedia_admin/Views/_ViewImports.cshtml"
using EGmediaBack.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00b83c7ff6960103bede14b18bdfd574a250352e", @"/Areas/egmedia_admin/Views/Offers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9224be7253d217eadcfa06d231c12e3993cbe9fa", @"/Areas/egmedia_admin/Views/_ViewImports.cshtml")]
    public class Areas_egmedia_admin_Views_Offers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GetPriceOffer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 788, true);
            WriteLiteral(@"<section id=""offer_admin"">
    <div class=""container mt-5"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""table-responsive"">
                    <table class=""table table-dark table-hover table-bordered"">
                        <thead>
                            <tr>
                                <th scope=""col"">Tam adı</th>
                                <th scope=""col"">Emaİl</th>
                                <th scope=""col"">Telefon nömrəsİ</th>
                                <th scope=""col"">Mesaj</th>
                                <th scope=""col"">Tarİx</th>
                                <th scope=""col"">Cavablandırlıbmı?</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 19 "/Users/ibrahimlien/Desktop/BackEnd/EGmedia/EGmediaBack/Areas/egmedia_admin/Views/Offers/Index.cshtml"
                             foreach (var message in Model)
                            {

#line default
#line hidden
            BeginContext(912, 89, true);
            WriteLiteral("                                <tr>\n                                    <th scope=\"row\">");
            EndContext();
            BeginContext(1002, 16, false);
#line 22 "/Users/ibrahimlien/Desktop/BackEnd/EGmedia/EGmediaBack/Areas/egmedia_admin/Views/Offers/Index.cshtml"
                                               Write(message.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(1018, 46, true);
            WriteLiteral("</th>\n                                    <td>");
            EndContext();
            BeginContext(1065, 13, false);
#line 23 "/Users/ibrahimlien/Desktop/BackEnd/EGmedia/EGmediaBack/Areas/egmedia_admin/Views/Offers/Index.cshtml"
                                   Write(message.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1078, 46, true);
            WriteLiteral("</td>\n                                    <td>");
            EndContext();
            BeginContext(1125, 19, false);
#line 24 "/Users/ibrahimlien/Desktop/BackEnd/EGmedia/EGmediaBack/Areas/egmedia_admin/Views/Offers/Index.cshtml"
                                   Write(message.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1144, 46, true);
            WriteLiteral("</td>\n                                    <td>");
            EndContext();
            BeginContext(1191, 15, false);
#line 25 "/Users/ibrahimlien/Desktop/BackEnd/EGmedia/EGmediaBack/Areas/egmedia_admin/Views/Offers/Index.cshtml"
                                   Write(message.Message);

#line default
#line hidden
            EndContext();
            BeginContext(1206, 46, true);
            WriteLiteral("</td>\n                                    <td>");
            EndContext();
            BeginContext(1253, 35, false);
#line 26 "/Users/ibrahimlien/Desktop/BackEnd/EGmedia/EGmediaBack/Areas/egmedia_admin/Views/Offers/Index.cshtml"
                                   Write(message.Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 46, true);
            WriteLiteral("</td>\n                                    <td>");
            EndContext();
            BeginContext(1336, 35, false);
#line 27 "/Users/ibrahimlien/Desktop/BackEnd/EGmedia/EGmediaBack/Areas/egmedia_admin/Views/Offers/Index.cshtml"
                                    Write(@message.IsResponsed ? "Hə" : "Yox");

#line default
#line hidden
            EndContext();
            BeginContext(1372, 188, true);
            WriteLiteral("</td>\n                                    <td class=\"text-right\"><a class=\"btn bg-warning btn-warning text-white open-modal\" data-toggle=\"modal\" data-target=\"#exampleModalCenter\" data-id=\"");
            EndContext();
            BeginContext(1561, 10, false);
#line 28 "/Users/ibrahimlien/Desktop/BackEnd/EGmedia/EGmediaBack/Areas/egmedia_admin/Views/Offers/Index.cshtml"
                                                                                                                                                                                 Write(message.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1571, 14, true);
            WriteLiteral("\" data-email=\"");
            EndContext();
            BeginContext(1586, 13, false);
#line 28 "/Users/ibrahimlien/Desktop/BackEnd/EGmedia/EGmediaBack/Areas/egmedia_admin/Views/Offers/Index.cshtml"
                                                                                                                                                                                                          Write(message.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1599, 57, true);
            WriteLiteral("\">Cavabla</a></td>\n                                </tr>\n");
            EndContext();
#line 30 "/Users/ibrahimlien/Desktop/BackEnd/EGmedia/EGmediaBack/Areas/egmedia_admin/Views/Offers/Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1686, 1484, true);
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <!-- Modal -->
    <div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" style=""transform: translate(0, 0)"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" style=""font-weight: bold"" id=""exampleModalLongTitle"">Mesajınızı yazın</h5>
                    <button type=""button"" class=""close"" id=""x_btn"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <span class=""validation-span"" style=""font-size: 16px""></span>
                    <textarea name=""message"" id=""message"" rows=""10"" class=""");
            WriteLiteral(@"w-100"" style=""outline: none""></textarea>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary bg-secondary text-white"" id=""close_btn"" data-dismiss=""modal"">Bağla</button>
                    <button type=""button"" class=""btn btn-primary bg-primary text-white"" id=""send_message_to_client"">Göndər</button>
                </div>
            </div>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GetPriceOffer>> Html { get; private set; }
    }
}
#pragma warning restore 1591