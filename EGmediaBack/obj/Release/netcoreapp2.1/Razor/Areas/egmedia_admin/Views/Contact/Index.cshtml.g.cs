#pragma checksum "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Areas\egmedia_admin\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "096e5338293c512ecbe11bef910d7274e18f0ebc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_egmedia_admin_Views_Contact_Index), @"mvc.1.0.view", @"/Areas/egmedia_admin/Views/Contact/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/egmedia_admin/Views/Contact/Index.cshtml", typeof(AspNetCore.Areas_egmedia_admin_Views_Contact_Index))]
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
#line 1 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Areas\egmedia_admin\Views\_ViewImports.cshtml"
using EGmediaBack;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Areas\egmedia_admin\Views\_ViewImports.cshtml"
using EGmediaBack.Models;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Areas\egmedia_admin\Views\_ViewImports.cshtml"
using EGmediaBack.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"096e5338293c512ecbe11bef910d7274e18f0ebc", @"/Areas/egmedia_admin/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36b4d0d1144ab4353627fe4dc794c8b22fe07b7f", @"/Areas/egmedia_admin/Views/_ViewImports.cshtml")]
    public class Areas_egmedia_admin_Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContactMessage>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 807, true);
            WriteLiteral(@"<section id=""contact_admin"">
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
#line 19 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Areas\egmedia_admin\Views\Contact\Index.cshtml"
                             foreach (var message in Model)
                            {

#line default
#line hidden
            BeginContext(935, 90, true);
            WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">");
            EndContext();
            BeginContext(1026, 16, false);
#line 22 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Areas\egmedia_admin\Views\Contact\Index.cshtml"
                                               Write(message.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(1042, 47, true);
            WriteLiteral("</th>\r\n                                    <td>");
            EndContext();
            BeginContext(1090, 13, false);
#line 23 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Areas\egmedia_admin\Views\Contact\Index.cshtml"
                                   Write(message.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1103, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1151, 19, false);
#line 24 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Areas\egmedia_admin\Views\Contact\Index.cshtml"
                                   Write(message.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1170, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1218, 15, false);
#line 25 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Areas\egmedia_admin\Views\Contact\Index.cshtml"
                                   Write(message.Message);

#line default
#line hidden
            EndContext();
            BeginContext(1233, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1281, 35, false);
#line 26 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Areas\egmedia_admin\Views\Contact\Index.cshtml"
                                   Write(message.Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1316, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1365, 35, false);
#line 27 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Areas\egmedia_admin\Views\Contact\Index.cshtml"
                                    Write(@message.IsResponsed ? "Hə" : "Yox");

#line default
#line hidden
            EndContext();
            BeginContext(1401, 189, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-right\"><a class=\"btn bg-warning btn-warning text-white open-modal\" data-toggle=\"modal\" data-target=\"#exampleModalCenter\" data-id=\"");
            EndContext();
            BeginContext(1591, 10, false);
#line 28 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Areas\egmedia_admin\Views\Contact\Index.cshtml"
                                                                                                                                                                                 Write(message.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1601, 13, true);
            WriteLiteral("\"data-email=\"");
            EndContext();
            BeginContext(1615, 13, false);
#line 28 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Areas\egmedia_admin\Views\Contact\Index.cshtml"
                                                                                                                                                                                                         Write(message.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1628, 59, true);
            WriteLiteral("\">Cavabla</a></td>\r\n                                </tr>\r\n");
            EndContext();
#line 30 "C:\Users\User\Desktop\Egmedia website\EGmediaBack\EGmediaBack\Areas\egmedia_admin\Views\Contact\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1718, 1511, true);
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
                    <textarea name=""message"" id=""message""");
            WriteLiteral(@" rows=""10"" class=""w-100"" style=""outline: none""></textarea>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContactMessage>> Html { get; private set; }
    }
}
#pragma warning restore 1591