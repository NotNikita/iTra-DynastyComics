#pragma checksum "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75e3debd17e41819a481f8834877d6cd0f5b02bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comic_Details), @"mvc.1.0.view", @"/Views/Comic/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\_ViewImports.cshtml"
using Comics.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\_ViewImports.cshtml"
using Comics.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\_ViewImports.cshtml"
using Comics.Web.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\_ViewImports.cshtml"
using Westwind.AspNetCore.Markdown;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75e3debd17e41819a481f8834877d6cd0f5b02bd", @"/Views/Comic/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"035048ab6ed1451b309340a0aa9283d8f22745f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Comic_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Comic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn color2-bg comic-controller btn-gradient ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToWishList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
  
    ViewData["Title"] = "Comic";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""main-container"">
    <div class=""container"">
        <header id=""content-header"">
            <section id=""comic-header"" class=""content-header-section d-flex"">
                <div class=""backdrop"">
                    <div class=""cover""");
            BeginWriteAttribute("style", " style=\"", 396, "\"", 438, 4);
            WriteAttributeValue("", 404, "background-image:", 404, 17, true);
            WriteAttributeValue(" ", 421, "url(", 422, 5, true);
#nullable restore
#line 15 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
WriteAttributeValue("", 426, Model.Img, 426, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 436, ");", 436, 2, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                </div>
                <div class=""splitter""></div>
                <div class=""inner align-self-end"">
                    <div class=""section-details"">
                        <div class=""page-details"">
                            <div class='header-intro'>
                                <a");
            BeginWriteAttribute("href", " href=\"", 763, "\"", 770, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 23 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                               Write(Model.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Comics\r\n                                </a> &nbsp;&nbsp;·&nbsp;&nbsp;\r\n                                Released <a");
            BeginWriteAttribute("href", " href=\"", 942, "\"", 949, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\'font-weight: normal;\'>");
#nullable restore
#line 25 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                                                            Write(Model.Released.Value.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </div>\r\n                            <h1>\r\n                                ");
#nullable restore
#line 28 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<small> ");
#nullable restore
#line 28 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                              Write(Localizer["BrandNew"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                            </h1>
                        </div>
                    </div>
                </div>
            </section>
        </header>

        <section id=""content-toolbar"" class=""content-toolbar mb-5"">
            <div class=""col-profile-max"">
                <div class=""row align-items-center justify-content-between py-4"">
                    <div id=""comic-statbar"" class=""col d-flex flex-row align-items-center"">
                        <div class=""d-flex"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75e3debd17e41819a481f8834877d6cd0f5b02bd9252", async() => {
#nullable restore
#line 41 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                                                                                                                       Write(Localizer["Wish List"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                                                                                                     WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75e3debd17e41819a481f8834877d6cd0f5b02bd11860", async() => {
#nullable restore
#line 42 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                                                                                                              Write(Localizer["Edit"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                                                                                            WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col-auto ml-auto d-none d-md-flex"">

                        <div class=""comic-my-controls d-flex"">
                            <div class=""row no-gutters w-100 justify-content-end"">
                                <div class=""col-3"">
                                    <div class=""comic-controller"">
");
#nullable restore
#line 51 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                         if (Model.isInWishList)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"fas fa-heart\"></span>\r\n");
#nullable restore
#line 54 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"

                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"far fa-heart\"></span>\r\n");
#nullable restore
#line 59 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"label-icon\">");
#nullable restore
#line 60 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                                           Write(Localizer["WantIt"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </section>

        <section id=""comic-details"">

            <div class=""tab-content col-profile-max"">
                <div class=""tab-pane fade show active"" id=""overview"" role=""tabpanel"" aria-labelledby=""nav-overview-tab"">
                    <div class=""cg-grid"">

                        <section id=""summary"">
                            <div class=""row listing-content"">
                                <div class=""col-12 listing-description"">
                                    <p>	");
#nullable restore
#line 80 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                      Write(Markdown.ParseHtmlString(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                                <div class=""col-12"">

                                    <div class=""row details-addtl copy-small mt-3"">
                                        <div class=""col-xxl-4 col-lg-6 col-6 mb-3 details-addtl-block"">
                                            <div class=""name"">
                                                ");
#nullable restore
#line 87 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                           Write(Localizer["Format"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                            <div class=\"value\">\r\n                                                ");
#nullable restore
#line 90 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                           Write(Localizer["Comic"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""col-xxl-4 col-lg-6 col-6 mb-3 details-addtl-block"">
                                            <div class=""name"">
                                                ");
#nullable restore
#line 96 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                           Write(Localizer["PageCount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                            <div class=\"value\">\r\n                                                ");
#nullable restore
#line 99 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                           Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 99 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                                            Write(Localizer["pages"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""col-xxl-4 col-lg-6 col-6 mb-3 details-addtl-block"">
                                            <div class=""name"">
                                                ");
#nullable restore
#line 105 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                           Write(Localizer["Price"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                            <div class=\"value\">\r\n                                                ");
#nullable restore
#line 108 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                           Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>

                                        <div class=""col-xxl-4 col-lg-12 col-6 mb-3 details-addtl-block"">
                                            <div class=""name"">
                                                ");
#nullable restore
#line 114 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                           Write(Localizer["Tags"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                            <div class=\"value\">\r\n                                                ");
#nullable restore
#line 117 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                           Write(Model.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>

                                    </div>

                                </div>
                            </div>
                        </section>

                        <aside class=""cg-grid-side"">
                            <div class=""content-sidebar-wrapper overlap"">
                                <div class=""comic-cover-view mx-auto"">

                                    <div class=""cover-art"">
                                        <a");
            BeginWriteAttribute("href", " href=", 6486, "", 6502, 1);
#nullable restore
#line 132 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
WriteAttributeValue("", 6492, Model.Img, 6492, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"cover-gallery\"");
            BeginWriteAttribute("title", " title=", 6524, "", 6542, 1);
#nullable restore
#line 132 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
WriteAttributeValue("", 6531, Model.Name, 6531, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=", 6547, "", 6562, 1);
#nullable restore
#line 132 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
WriteAttributeValue("", 6552, Model.Img, 6552, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 6562, "", 6578, 1);
#nullable restore
#line 132 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
WriteAttributeValue("", 6567, Model.Name, 6567, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                    </div>

                                </div>

                                <div class=""row"">
                                    <div class=""col justify-content-center"">
                                        <div class=""d-flex align-items-center justify-content-center text-center"">
                                            <div class=""copy-medium mr-4"">
                                                <i class=""fas fa-heart""></i>
                                                <span class=""ml-1"">777");
            WriteLiteral(@"</span>
                                            </div>
                                        </div>

                                    </div>
                                </div>


                                <div class=""separator""></div>
                            </div>
                        </aside>
                    </div>
                </div>
                <div class=""tab-pane fade grid-form "" id=""my-details"" role=""tabpanel"" aria-labelledby=""nav-my-details-tab"">
                </div>
            </div>
        </section>

");
#nullable restore
#line 160 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
         if (User.Identity.IsAuthenticated && !User.IsInRole("guest"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"prepared\" class=\"row justify-content-center\">\r\n                <div class=\"container\">\r\n                    <div class=\"col col-12\" style=\"margin-top:15px;\">\r\n                        <h4>");
#nullable restore
#line 165 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                       Write(Localizer["Comments"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <hr />\r\n                    </div>\r\n");
#nullable restore
#line 168 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 170 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                   Write(await Html.PartialAsync("~/Views/Shared/_CommCreate.cshtml", new Comment() { ItemId = Model.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 170 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                                                                                                          
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 174 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"

            var commentsId = "comments" + @Model.Id;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row justify-content-center col-md-12\"");
            BeginWriteAttribute("id", " id=\"", 8509, "\"", 8525, 1);
#nullable restore
#line 176 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
WriteAttributeValue("", 8514, commentsId, 8514, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 177 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                   await Html.RenderPartialAsync("~/Views/Shared/CommentsList.cshtml", Model.Comments); 

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 179 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75e3debd17e41819a481f8834877d6cd0f5b02bd27680", async() => {
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
            WriteLiteral(@"
<script>
    const updateHub = new signalR.HubConnectionBuilder()
        .withUrl(""/updates"")
        .build();

    updateHub.on('UpdateTable', function (lot_id, user_id, user_name) {
        var model_id = lot_id;
        if (model_id == lot_id) {
            var user_td = document.createElement('td');
            var user_link = document.createElement('a');
            user_link.classList.add('object-link');

            var link_text = document.createTextNode(user_name);
            user_link.appendChild(link_text);
            user_link.href = ""/Users/Profile/"" + user_id;
            user_td.appendChild(user_link);
        }
    })

    updateHub.start().then(function () {
        console.log(""First"");
        updateHub.invoke('JoinGroup', ");
#nullable restore
#line 207 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
                                 Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n        console.log(");
#nullable restore
#line 208 "D:\UniverCity\iTransition\Comics\Comics.Web\Views\Comic\Details.cshtml"
               Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n\r\n        console.log(\"Third\");\r\n        $(\'#sendButton\').click(function() {\r\n\r\n            updateHub.invoke(\'Send\', lot_id, user_id, user_name, lot_id);\r\n\r\n        });\r\n        console.log(\"Fourth\");\r\n    });\r\n\r\n</script>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>(function () { var uv = document.createElement('script'); uv.type = 'text/javascript'; uv.async = true; uv.src = '//widget.uservoice.com/edoXvUiLvxUooiGFzaymDQ.js'; var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(uv, s) })()</script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75e3debd17e41819a481f8834877d6cd0f5b02bd30614", async() => {
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
                WriteLiteral(@"

    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/js-cookie@2/src/js.cookie.min.js""></script>
    <script type=""text/javascript"" src=""https://leagueofcomicgeeks.com/assets/js/underscore-min.js""></script>
    <script type=""text/javascript"" src=""https://leagueofcomicgeeks.com/assets/js/jquery-general.min.js?v=202012141""></script>
    <script type=""text/javascript"" src=""https://leagueofcomicgeeks.com/assets/js/jquery.lazyload.min.js?v=20201214""></script>
    <script type=""text/javascript"" src=""https://leagueofcomicgeeks.com/assets/js/jquery.colorbox.min.js""></script>
    <script type=""text/javascript"" src=""https://leagueofcomicgeeks.com/assets/js/jquery-summernote.min.js?v=20201214""></script>
    <script src=""https://leagueofcomicgeeks.com/assets/js/jquery-ui.min.js?v=20201018""></script>
    <script type=""text/javascript"" src=""https://leagueofcomicgeeks.com/assets/js/comic-list.min.js?v=20201214""></script>
    <");
                WriteLiteral(@"script type=""text/javascript"" src=""https://leagueofcomicgeeks.com/assets/js/typeahead.min.js""></script>
    <script type=""text/javascript"" src=""https://leagueofcomicgeeks.com/assets/js/feed.min.js?v=20201214""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/tinysort/2.3.6/tinysort.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/tinysort/2.3.6/jquery.tinysort.min.js""></script>

");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Comic> Html { get; private set; }
    }
}
#pragma warning restore 1591
