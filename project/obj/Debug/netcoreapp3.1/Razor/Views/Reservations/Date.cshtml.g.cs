#pragma checksum "C:\Users\Conor\Documents\GitHub\IS4439\project\Views\Reservations\Date.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3344b44848f32e075f60c84d8bd9338e2f403a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_Date), @"mvc.1.0.view", @"/Views/Reservations/Date.cshtml")]
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
#line 1 "C:\Users\Conor\Documents\GitHub\IS4439\project\Views\_ViewImports.cshtml"
using project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Conor\Documents\GitHub\IS4439\project\Views\_ViewImports.cshtml"
using project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3344b44848f32e075f60c84d8bd9338e2f403a8", @"/Views/Reservations/Date.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6489460591dedbaaa7ef634782f0f12b0f7a4e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservations_Date : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<project.Models.Booking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reservations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookingInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/datatable.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""hero-wrap hero-wrap-2 bg-image"" data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-end justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center"">
                <h1 class=""mb-2 bread"">Date</h1>
 
            </div>
        </div>
    </div>
</section>

<section class=""ftco-section ftco-no-pt ftco-no-pb"">
    <div class=""container-fluid px-0"">
        <div class=""row d-flex justify-content-center no-gutters"">
            <div class=""col-md-10 order-md-last ftco-animate makereservation p-4 p-md-5 pt-5"">
                <div class=""py-md-5"">

                    <div class=""row"">

                        <div class=""heading-section ftco-animate mb-5"">
                            <span class=""subheading"">Bookings</span>
                            <h2 class=""mb-4"">");
#nullable restore
#line 25 "C:\Users\Conor\Documents\GitHub\IS4439\project\Views\Reservations\Date.cshtml"
                                        Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        </div>\r\n\r\n                        <div class=\"col-lg-12 mb-4\">\r\n                            <div class=\"card\">\r\n\r\n\r\n                                <ul class=\"listHorizontal card py-3 bg-image\">\r\n");
#nullable restore
#line 33 "C:\Users\Conor\Documents\GitHub\IS4439\project\Views\Reservations\Date.cshtml"
                                     using (Html.BeginForm("Date", "Reservations"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"ml-4\"><p class=\"text-white\">Filter by Date</p></li>\r\n                                        <li class=\"ml-4\">");
#nullable restore
#line 36 "C:\Users\Conor\Documents\GitHub\IS4439\project\Views\Reservations\Date.cshtml"
                                                    Write(Html.TextBox("dt", "", new { @type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
            WriteLiteral("                                        <li class=\"ml-4\"><input type=\"submit\" value=\"Filter\" class=\"btn btn-primary py-3 px-5\" /></li>\r\n                                        <li class=\"ml-4\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3344b44848f32e075f60c84d8bd9338e2f403a87015", async() => {
                WriteLiteral("<input type=\"button\" value=\"Reset Filter\" class=\"btn btn-primary py-3 px-5\" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 40 "C:\Users\Conor\Documents\GitHub\IS4439\project\Views\Reservations\Date.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </ul>



                            </div>
                        </div>
                    </div>
                    <!--datatable start-->

                    <div class=""table-responsive"">
                        <div id=""dataTable_wrapper""
                             class=""dataTables_wrapper dt-bootstrap4"">

                            <div class=""row"">
                                <div class=""col-sm-12"">
                                    <table class=""table table-bordered dataTable""
                                           id=""dataTable"" cellspacing=""0"" role=""grid""
                                           aria-describedby=""dataTable_info"">
                                        <thead>
                                            <tr role=""row"">
                                                <th class=""sorting_asc bg-yellow""
                                                    tabindex=""0"" aria-controls=""dataTable"" rowspan=""1""
        ");
            WriteLiteral(@"                                            colspan=""1"" aria-sort=""ascending""
                                                    aria-label=""Name: activate to sort column descending""
                                                    style=""width: 64px;"">Booking #</th>
                                                <th class=""sorting_asc bg-yellow""
                                                    tabindex=""0"" aria-controls=""dataTable"" rowspan=""1""
                                                    colspan=""1"" aria-sort=""ascending""
                                                    aria-label=""Name: activate to sort column descending""
                                                    style=""width: 64px;"">Name</th>
                                                <th class=""sorting bg-yellow""
                                                    tabindex=""0"" aria-controls=""dataTable"" rowspan=""1""
                                                    colspan=""1""
                                    ");
            WriteLiteral(@"                aria-label=""Position: activate to sort column ascending""
                                                    style=""width: 81px;"">Email</th>
                                                <th class=""sorting bg-yellow""
                                                    tabindex=""0"" aria-controls=""dataTable"" rowspan=""1""
                                                    colspan=""1""
                                                    aria-label=""Office: activate to sort column ascending""
                                                    style=""width: 56px;"">Date</th>
                                                <th class=""sorting bg-yellow ""
                                                    tabindex=""0"" aria-controls=""dataTable"" rowspan=""1""
                                                    colspan=""1""
                                                    aria-label=""Office: activate to sort column ascending""
                                                    style=""width: 56");
            WriteLiteral(@"px;"">Service</th>
                                                <th class=""sorting bg-yellow""
                                                    tabindex=""0"" aria-controls=""dataTable"" rowspan=""1""
                                                    colspan=""1""
                                                    aria-label=""Age: activate to sort column ascending""
                                                    style=""width: 31px;"">Time</th>
                                                <th class=""sorting bg-yellow""
                                                    tabindex=""0"" aria-controls=""dataTable"" rowspan=""1""
                                                    colspan=""1""
                                                    aria-label=""Age: activate to sort column ascending""
                                                    style=""width: 31px;"">Guests</th>
                                                <th class=""sorting bg-yellow""
                                                  ");
            WriteLiteral(@"  tabindex=""0"" aria-controls=""dataTable"" rowspan=""1""
                                                    colspan=""1""
                                                    aria-label=""Start date: activate to sort column ascending""
                                                    style=""width: 68px;"">Diet Requirements</th>

                                            </tr>
                                        </thead>
                                        <tfoot>
                                        <tbody>

");
#nullable restore
#line 107 "C:\Users\Conor\Documents\GitHub\IS4439\project\Views\Reservations\Date.cshtml"
                                             foreach (Booking b in ViewBag.Bookings)
                                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr role=\"row\" class=\"odd\">\r\n\r\n                                                <td class=\"sorting_1\" style=\"text-align:center\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3344b44848f32e075f60c84d8bd9338e2f403a814091", async() => {
#nullable restore
#line 112 "C:\Users\Conor\Documents\GitHub\IS4439\project\Views\Reservations\Date.cshtml"
                                                                                                                                                                                  Write(b.BookingNum);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "C:\Users\Conor\Documents\GitHub\IS4439\project\Views\Reservations\Date.cshtml"
                                                                                                                                                            WriteLiteral(b.BookingNum);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 113 "C:\Users\Conor\Documents\GitHub\IS4439\project\Views\Reservations\Date.cshtml"
                                               Write(b.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 114 "C:\Users\Conor\Documents\GitHub\IS4439\project\Views\Reservations\Date.cshtml"
                                               Write(b.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 115 "C:\Users\Conor\Documents\GitHub\IS4439\project\Views\Reservations\Date.cshtml"
                                               Write(b.BookingDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 116 "C:\Users\Conor\Documents\GitHub\IS4439\project\Views\Reservations\Date.cshtml"
                                               Write(b.Service);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 117 "C:\Users\Conor\Documents\GitHub\IS4439\project\Views\Reservations\Date.cshtml"
                                               Write(b.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 118 "C:\Users\Conor\Documents\GitHub\IS4439\project\Views\Reservations\Date.cshtml"
                                               Write(b.NumGuests);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 119 "C:\Users\Conor\Documents\GitHub\IS4439\project\Views\Reservations\Date.cshtml"
                                               Write(b.Diet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                            </tr>\r\n");
#nullable restore
#line 122 "C:\Users\Conor\Documents\GitHub\IS4439\project\Views\Reservations\Date.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                        </tbody>
                                    </table>
                                </div>
                            </div>

                        </div>
                    </div>



                </div>
            </div>

        </div>
    </div>



");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n        <script src=\"//cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js\"></script>\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3344b44848f32e075f60c84d8bd9338e2f403a819956", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        <script>\r\n            $(document).ready(function () {\r\n                $(\'#dataTable\').DataTable();\r\n            });\r\n\r\n\r\n        </script>\r\n\r\n    ");
            }
            );
            WriteLiteral("\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<project.Models.Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591
