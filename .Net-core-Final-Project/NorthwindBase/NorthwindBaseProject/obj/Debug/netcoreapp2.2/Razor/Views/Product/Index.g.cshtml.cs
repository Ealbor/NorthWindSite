#pragma checksum "C:\Users\emalb\Desktop\.net core final project\.Net-core-Final-Project\NorthwindBase\NorthwindBaseProject\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf26e01553cf58de8a88be122cef46d10b799671"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Northwind.Views.Home.Product.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(Northwind.Views.Home.Product.Views_Product_Index))]
namespace Northwind.Views.Home.Product
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf26e01553cf58de8a88be122cef46d10b799671", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc336443358a39bf31ac02f3d17194e98e1e1151", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 49, true);
            WriteLiteral("<div id=\"User\" style=\"display:none;\" data-email=\"");
            EndContext();
            BeginContext(50, 18, false);
#line 1 "C:\Users\emalb\Desktop\.net core final project\.Net-core-Final-Project\NorthwindBase\NorthwindBaseProject\Views\Product\Index.cshtml"
                                            Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(68, 17, true);
            WriteLiteral("\" data-customer=\"");
            EndContext();
            BeginContext(86, 25, false);
#line 1 "C:\Users\emalb\Desktop\.net core final project\.Net-core-Final-Project\NorthwindBase\NorthwindBaseProject\Views\Product\Index.cshtml"
                                                                                Write(User.IsInRole("Customer"));

#line default
#line hidden
            EndContext();
            BeginContext(111, 413, true);
            WriteLiteral(@"""></div>
<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">Product</th>
            <th scope=""col"" class=""text-right"">
                <span id=""priceFilter"" class=""text-primary""><i class=""fas fa-filter""></i> Price</span>
            </th>
            <th scope=""col"" class=""text-right"">Stock</th>
        </tr>
    </thead>
    <tbody id=""product_table"" data-id=""");
            EndContext();
            BeginContext(525, 10, false);
#line 12 "C:\Users\emalb\Desktop\.net core final project\.Net-core-Final-Project\NorthwindBase\NorthwindBaseProject\Views\Product\Index.cshtml"
                                  Write(ViewBag.id);

#line default
#line hidden
            EndContext();
            BeginContext(535, 2613, true);
            WriteLiteral(@""">

    </tbody>
</table>
<!-- max price footer -->
<div id=""priceBar"" class=""border-top border-secondary bg-light p-2 pr-4 text-right"">
    Maximum Price: <span id=""maxPrice"">none</span>
    <i id=""priceDown"" data-val=""-5"" class=""fas fa-chevron-circle-down ml-1 text-primary""></i>
    <i id=""priceUp"" data-val=""5"" class=""fas fa-chevron-circle-up text-primary""></i>
</div>
<!-- cart item modal -->
<div id=""cartModal"" class=""modal fade"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Add to Cart?</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div style=""display:none;"" id=""ProductId""></div>
                <div class=""row"">
                    <");
            WriteLiteral(@"div class=""col col-xs-5""><strong>Product</strong></div>
                    <div class=""col col-xs-2 text-right""><strong>Price</strong></div>
                    <div class=""col col-xs-2""><strong>Quantity</strong></div>
                    <div class=""col col-xs-3 text-right""><strong>Total</strong></div>
                </div>
                <div class=""row"">
                    <div class=""col col-xs-5 pt-2"" id=""ProductName"">Cool Product</div>
                    <div class=""col col-xs-2 pt-2 text-right"">
                        $<span id=""UnitPrice"">9.99</span>
                    </div>
                    <div class=""col col-xs-2"">
                        <input type=""number"" min=""1"" value=""1"" id=""Quantity"" class=""form-control"" />
                    </div>
                    <div class=""col col-xs-3 pt-2 text-right"">
                        $<span id=""Total"">0.00</span>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
       ");
            WriteLiteral(@"         <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                <button type=""button"" class=""btn btn-primary"" id=""addToCart"">Continue</button>
            </div>
        </div>
    </div>
</div>
<!-- toast -->
<div id=""cart_toast"" class=""toast"" role=""alert"" aria-live=""assertive"" aria-atomic=""true"">
    <div class=""toast-header"">
        <strong id=""toast_header"">This is a toast header</strong>
    </div>
    <div class=""toast-body"" id=""toast_body"">
        This is a toast message.
    </div>
</div>
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3167, 51, true);
                WriteLiteral("\r\n    <script src=\"../../js/product.js\"></script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
