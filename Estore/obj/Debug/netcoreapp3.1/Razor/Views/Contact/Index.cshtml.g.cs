#pragma checksum "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19a63340477e869eb03e4f085411342b4be8c1ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19a63340477e869eb03e4f085411342b4be8c1ef", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d782f7feb41a58f2b8cce76d714001228f193603", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n  ");
#nullable restore
#line 6 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
Write(await Component.InvokeAsync("Banner",new { Title = "Contact Us" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n    <!-- Contact area starts -->\n    <section class=\"contact-area\">\n        <div class=\"container\">\n            <div class=\"google-map  d-flex justify-content-center align-items-center mb-5\">\n                <iframe");
            BeginWriteAttribute("src", " src=\"", 343, "\"", 369, 1);
#nullable restore
#line 13 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
WriteAttributeValue("", 349, Model.Map.GoogleMap, 349, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                    width=""100%"" height=""450px"" style=""border:0;"" allowfullscreen=""true"" loading=""lazy""></iframe>
            </div>
            <div class=""row"">
                <div class=""col-12"">
                    <h2 class=""contact-title"">Get in Touch</h2>
                </div>
                <div class=""col-lg-8"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19a63340477e869eb03e4f085411342b4be8c1ef7174", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-12"">
                                <div class=""form-group"">
                                    <textarea class=""form-control w-100 h-100"" name=""message"" id=""message"" cols=""30"" rows=""9"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Enter Message'"" placeholder=""Enter Message"" style=""margin-top: 0px; margin-bottom: 0px; height: 87px;""></textarea>
                                </div>
                            </div>
                            <div style=""right:8px;"" class=""col-sm-6 position-relative"">
                                <div class=""form-group"">
                                    <input class=""form-control"" name=""name"" id=""name"" type=""text"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Enter your name'"" placeholder=""Enter your name"">
                                </div>
                            </div>
                            <div style=""left:8px"" class=""col-sm-6 position");
                WriteLiteral(@"-relative"">
                                <div class=""form-group"">
                                    <input class=""form-control"" name=""email"" id=""email"" type=""email"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Enter email address'"" placeholder=""Email"">
                                </div>
                            </div>
                            <div class=""col-12"">
                                <div class=""form-group"">
                                    <input class=""form-control"" name=""subject"" id=""subject"" type=""text"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Enter Subject'"" placeholder=""Enter Subject"">
                                </div>
                            </div>
                        </div>
                        <div class=""form-group mt-3"">
                            <button type=""submit"" class=""btn"">Send</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n                <div class=\"col-lg-3 offset-lg-1\">\n");
#nullable restore
#line 50 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
                 foreach (ContactInfo contact in Model.ContactInfos)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"contact-info\">\n");
#nullable restore
#line 53 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
                         if (contact.ContactType == "Email")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"contact-info-icon\"><i class=\"far fa-envelope\"></i></span>\n");
#nullable restore
#line 56 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
                    }
                        else if (contact.ContactType == "Address")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"contact-info-icon\"><i class=\"fas fa-home\"></i></span>\n");
#nullable restore
#line 60 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"


                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <span class=\"contact-info-icon\"><i class=\"fas fa-mobile-alt\"></i></span>\n");
#nullable restore
#line 66 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
                            
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        \n                        <div class=\"contact-info-body\">\n                            <h3>");
#nullable restore
#line 71 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
                           Write(contact.Contactinfo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                            <p>");
#nullable restore
#line 72 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
                          Write(contact.ContactText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        </div>\n                    </div>\n");
#nullable restore
#line 75 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \n                    \n                </div>\n            </div>\n        </div>\n    </section>\n\n    <!-- Contact area ends -->\n\n    ");
#nullable restore
#line 85 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
Write(await Html.PartialAsync("_GalleryPartial",Model.Galleries));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591