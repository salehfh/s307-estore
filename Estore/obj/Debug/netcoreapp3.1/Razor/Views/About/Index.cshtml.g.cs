#pragma checksum "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35490e8d5fe4c6a006eabe1b32acfbe8a1d1a507"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 2 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.AboutViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.ProductViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.BlogViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.HomeViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.ContactViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.CategoryViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.AccountViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35490e8d5fe4c6a006eabe1b32acfbe8a1d1a507", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d782f7feb41a58f2b8cce76d714001228f193603", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n  ");
#nullable restore
#line 6 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\About\Index.cshtml"
Write(await Component.InvokeAsync("Banner",new { Title = "About" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

   <!-- About area starts -->

    <section class=""about-area"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-lg-8"">
                    <div class=""about-text text-left"">
                        <h5>");
#nullable restore
#line 15 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\About\Index.cshtml"
                       Write(Model.AboutText.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" usss</h5>\n                        <h3>");
#nullable restore
#line 16 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\About\Index.cshtml"
                       Write(Model.AboutText.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                    </div>\n                    <div class=\"about-modal\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "35490e8d5fe4c6a006eabe1b32acfbe8a1d1a5077052", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 611, "~/images/", 611, 9, true);
#nullable restore
#line 19 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 620, Model.AboutText.AboutVideo.Img, 620, 31, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        <a class=\"about-play\" href=\"javascript:void(0);\"></a>\n\n\n                    </div>\n                    <div class=\"youtube-video\">\n                        <iframe id=\"existing-iframe-example\" width=\"640px\" height=\"640px\"");
            BeginWriteAttribute("src", " src=\"", 905, "\"", 944, 1);
#nullable restore
#line 25 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\About\Index.cshtml"
WriteAttributeValue("", 911, Model.AboutText.AboutVideo.Video, 911, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" frameborder=""0"" style=""border: solid 4px #37474F""></iframe>
                    </div>
                    <div id=""overlay""></div>
                </div>

            </div>
        </div>
    </section>
    <!-- About area ends -->
    <!-- Shop-information-section starts -->

    <section class=""shop-information-area"">
        <div class=""container"">
            <div class=""row justify-content-between"">
                <div class=""col-lg-6"">
                    <div class=""shop-information-title"">
                        <h3>");
#nullable restore
#line 41 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\About\Index.cshtml"
                       Write(Model.AboutShopInfo.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                    </div>\n                </div>\n                <div class=\"col-lg-5\">\n                    <div class=\"shop-information-content\">\n                        <p>");
#nullable restore
#line 46 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\About\Index.cshtml"
                      Write(Model.AboutShopInfo.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </div>\n                </div>\n            </div>\n            <div class=\"row justify-content-center\">\n");
#nullable restore
#line 51 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\About\Index.cshtml"
                 foreach (AboutShopItem item in Model.AboutShopInfo.Items)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-3 col-sm-6\">\n                    <div class=\"single-shop-information\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "35490e8d5fe4c6a006eabe1b32acfbe8a1d1a50711252", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2078, "~/images/", 2078, 9, true);
#nullable restore
#line 55 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 2087, item.Img, 2087, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        <h4>");
#nullable restore
#line 56 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\About\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                    </div>\n                </div>\n");
#nullable restore
#line 59 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\About\Index.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("               \n            </div>\n        </div>\n    </section>\n    <!-- Shop-information-section ends -->\n\n  ");
#nullable restore
#line 66 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\About\Index.cshtml"
Write(await Component.InvokeAsync("Testimonial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n \n    ");
#nullable restore
#line 69 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\About\Index.cshtml"
Write(await Html.PartialAsync("_SubscribePartial", Model.Subscribe));

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591