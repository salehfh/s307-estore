#pragma checksum "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Product\Productdetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92cc8a5ec5786904bff78a9b154ea625234510da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Productdetails), @"mvc.1.0.view", @"/Views/Product/Productdetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92cc8a5ec5786904bff78a9b154ea625234510da", @"/Views/Product/Productdetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d782f7feb41a58f2b8cce76d714001228f193603", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Productdetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("load-more"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Product\Productdetails.cshtml"
  
    ViewData["Title"] = "Productdetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 5 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Product\Productdetails.cshtml"
Write(await Component.InvokeAsync("Banner",new { Title = "Single Product" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

     <!-- Testimonial slider starts -->
    <section class=""testimonial-slider-product-detail"">

        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-lg-12"">
                    <div class=""owl-carousel"">
                        
");
#nullable restore
#line 15 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Product\Productdetails.cshtml"
                         foreach (Productimages image in Model.Product.Productimages)
                        {


                         
                               if (Model.Product.Productimages.ToArray().Length<3)
                         {

#line default
#line hidden
#nullable disable
            WriteLiteral("                              <div class=\"item\" style=\"height:500px;width:500px\">\n\n                                <div class=\"slide-img\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "92cc8a5ec5786904bff78a9b154ea625234510da8463", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 868, "~/images/", 868, 9, true);
#nullable restore
#line 25 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Product\Productdetails.cshtml"
AddHtmlAttributeValue("", 877, image.Img, 877, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </div>\n\n\n                            </div>\n                             <div class=\"item\" style=\"height:500px;width:500px\">\n\n                                <div class=\"slide-img\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "92cc8a5ec5786904bff78a9b154ea625234510da10313", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1157, "~/images/", 1157, 9, true);
#nullable restore
#line 33 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Product\Productdetails.cshtml"
AddHtmlAttributeValue("", 1166, image.Img, 1166, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </div>\n\n\n                            </div>\n                             <div class=\"item\" style=\"height:500px;width:500px\">\n\n                                <div class=\"slide-img\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "92cc8a5ec5786904bff78a9b154ea625234510da12168", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1446, "~/images/", 1446, 9, true);
#nullable restore
#line 41 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Product\Productdetails.cshtml"
AddHtmlAttributeValue("", 1455, image.Img, 1455, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </div>\n\n\n                            </div>\n");
#nullable restore
#line 46 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Product\Productdetails.cshtml"
                         }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                               <div class=\"item\" style=\"height:500px;width:500px\">\n\n                                <div class=\"slide-img\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "92cc8a5ec5786904bff78a9b154ea625234510da14330", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1819, "~/images/", 1819, 9, true);
#nullable restore
#line 52 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Product\Productdetails.cshtml"
AddHtmlAttributeValue("", 1828, image.Img, 1828, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </div>\n\n\n                            </div>\n");
#nullable restore
#line 57 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Product\Productdetails.cshtml"
                        }
                             
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \n                        \n\n                         \n\n\n                    </div>\n                    <div class=\"product-detail text-center\">\n                        <h3>\n                           ");
#nullable restore
#line 69 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Product\Productdetails.cshtml"
                      Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </h3>\n                        <p>\n                            ");
#nullable restore
#line 72 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Product\Productdetails.cshtml"
                       Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </p>\n\n                        <div class=\"product-add-to-card\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92cc8a5ec5786904bff78a9b154ea625234510da17306", async() => {
                WriteLiteral(@" 
                            <div class=""product-quantity"">
                                

                                
                                <p>Quantity</p>
                                <div class=""product-count d-inline-block"">
                                    <span class=""input-number-decrement minuspilus""> <i class=""fas fa-minus""></i></span>

                                    <input style=""width: 100px;text-align: center;"" class=""input-number"" type=""number""");
                BeginWriteAttribute("value", " value=\"", 2987, "\"", 3017, 1);
#nullable restore
#line 85 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Product\Productdetails.cshtml"
WriteAttributeValue("", 2995, Model.Basket.Quantity, 2995, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"  min=""0"" max=""100"">
                                    
                                    <span class=""input-number-increment minuspilus""> <i class=""fas fa-plus""></i></span>
                                   
                                </div>
                              <p>$");
#nullable restore
#line 90 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Product\Productdetails.cshtml"
                             Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                                \n                            </div>\n                            <div class=\"add-to-card-btn\">\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92cc8a5ec5786904bff78a9b154ea625234510da19235", async() => {
                    WriteLiteral("add to cart");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Product\Productdetails.cshtml"
                                                                                                WriteLiteral(Model.Product.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Product\Productdetails.cshtml"
                                                                                                                                       WriteLiteral(Model.Basket.Quantity);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Quantity"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Quantity", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Quantity"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            </div>\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n                    </div>\n\n                </div>\n            </div>\n\n        </div>\n        </div>\n\n\n    </section>\n    <!-- Testomonial slider ends -->\n    ");
#nullable restore
#line 109 "C:\Users\saleh\Desktop\Final-Project-Estore-main\Estore-back\Estore\Estore\Views\Product\Productdetails.cshtml"
Write(await Html.PartialAsync("_SubscribePartial", Model.Subscribe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591