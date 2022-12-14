#pragma checksum "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e77b63ebeb545c0d5cee2008fcbddf5278484f70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Index), @"mvc.1.0.view", @"/Views/Payment/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\_ViewImports.cshtml"
using ePizzaHub.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\_ViewImports.cshtml"
using ePizzaHub.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\_ViewImports.cshtml"
using ePizzaHub.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\_ViewImports.cshtml"
using ePizzaHub.WebUI.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e77b63ebeb545c0d5cee2008fcbddf5278484f70", @"/Views/Payment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f6c2151b50d34e51dad0fb018e547f0aab3d83d", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_Index : ePizzaHub.WebUI.Helpers.BaseViewPage<PaymentModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
  
    ViewData["Title"] = "Payment | ePizza Hub";
    Address address = TempData.Peek<Address>("Address");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section>\r\n");
#nullable restore
#line 9 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row mt-3"">
            <div class=""col-lg-8"">
                <div class=""card mb-3"">
                    <div class=""col-sm-12"">
                        <h5 class=""mt-3"">
                            Order Details
                            <span class=""float-right"">
                                Item(s): ");
#nullable restore
#line 18 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                                    Write(Model.Cart.Items.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </span>\r\n                        </h5>\r\n                    </div>\r\n                    <hr />\r\n                    <div class=\"card-body pt-0 pb-0\">\r\n");
#nullable restore
#line 24 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                         foreach (var item in Model.Cart.Items)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""row"">
                                <div class=""col-md-5 col-lg-3 col-xl-3"">
                                    <div class=""rounded mb-3 mb-md-0"">
                                        <img class=""rounded w-100""");
            BeginWriteAttribute("src", "\r\n                                             src=\"", 1076, "\"", 1142, 1);
#nullable restore
#line 30 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
WriteAttributeValue("", 1128, item.ImageUrl, 1128, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""sample"" />
                                    </div>
                                </div>
                                <div class=""col-md-7 col-lg-9 col-xl-9"">
                                    <div class=""d-flex justify-content-between"">
                                        <div>
                                            <h5>");
#nullable restore
#line 36 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <p class=\"mb-2 text-muted small\">Size: Regular</p>\r\n                                            <p class=\"mb-2 text-muted small\">\r\n                                                Unit Price: ???");
#nullable restore
#line 39 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                                                        Write(item.UnitPrice.ToString("##.#"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </div>
                                        <div>
                                            <div class=""def-number-input number-input safari-only mb-0 w-100"">
                                                <div class=""input-group mb-3"">

                                                    <input class=""form-control sm-control"" size=""2"" min=""0"" name=""quantity""");
            BeginWriteAttribute("value", " value=\"", 2245, "\"", 2267, 1);
#nullable restore
#line 46 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
WriteAttributeValue("", 2253, item.Quantity, 2253, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly />

                                                </div>
                                            </div>

                                            <span id=""spanTotal"" class=""form-text text-muted text-center"">
                                                Total : ???");
#nullable restore
#line 52 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                                                     Write((item.UnitPrice * @item.Quantity).ToString("##.#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </span>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n\r\n                            </div>\r\n");
#nullable restore
#line 59 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                             if (Model.Cart.Items.IndexOf(item) < Model.Cart.Items.Count - 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <hr class=\"mb-4\">\r\n");
#nullable restore
#line 62 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <div class=""col-sm-12"">
                        <h5 class=""mt-2"">Delivery Address</h5>
                    </div>
                    <hr />
                    <div class=""card-body pb-0"">
                        <dl class=""row"">
                            <dt class=""col-sm-2"">
                                Street
                            </dt>
                            <dd class=""col-sm-4"" id=""address"">
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 3597, "\"", 3620, 1);
#nullable restore
#line 75 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
WriteAttributeValue("", 3605, address.Street, 3605, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" disabled  id=""street""/>
                                
                            </dd>
                            <dt class=""col-sm-2"" id=""locale"">
                                Locality
                            </dt>
                            <dd class=""col-sm-4"">
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 3978, "\"", 4003, 1);
#nullable restore
#line 82 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
WriteAttributeValue("", 3986, address.Locality, 3986, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" disabled id=""locale"" />
                               
                            </dd>
                            <dt class=""col-sm-2"">
                                Zip Code
                            </dt>
                            <dd class=""col-sm-4"">
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 4348, "\"", 4373, 1);
#nullable restore
#line 89 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
WriteAttributeValue(" ", 4356, address.ZipCode, 4357, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" disabled id=""zipcode"" />
                                
                            </dd>
                            <dt class=""col-sm-2"">
                                Contact No.
                            </dt>
                            <dd class=""col-sm-4"">
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 4723, "\"", 4752, 1);
#nullable restore
#line 96 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
WriteAttributeValue(" ", 4731, address.PhoneNumber, 4732, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" disabled id=""phonenumber"" />
                            </dd>
                        </dl>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""card mb-3"">
                    <div class=""col-sm-12"">
                        <h5 class=""mt-3""> Order Summary</h5>
                    </div>
                    <hr />
                    <div id=""paymentForm"" class=""card-body pt-0"">
                        <ul class=""list-group list-group-flush"">
                            <li class=""list-group-item d-flex justify-content-between align-items-center border-0 px-0"">
                                Amount
                                <span>+???");
#nullable restore
#line 112 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                                   Write(Model.Cart.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n                            <li class=\"list-group-item d-flex justify-content-between align-items-center border-0 px-0\">\r\n                                Tax (5%)\r\n                                <span>+???");
#nullable restore
#line 116 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                                   Write(Model.Cart.Tax);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center px-0 mb-3"">
                                <strong>Total Amount</strong>
                                <span><strong>???");
#nullable restore
#line 120 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                                          Write(Model.Cart.GrandTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span>\r\n\r\n                            </li>\r\n                        </ul>\r\n");
#nullable restore
#line 124 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                         if (CurrentUser != null)
                        {
                            //<a href="#" type="submit" class="btn btn-primary btn-block" onclick="payWithPaystack()">Pay Now</a>

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"submit\" class=\"btn btn-primary btn-block\" onclick=\"payWithPaystack()\"> Pay Now</button>\r\n");
#nullable restore
#line 128 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 134 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</section>

<script src=""https://js.paystack.co/v1/inline.js""></script>
<script>

   var paymentForm = document.getElementById('paymentForm');
paymentForm.addEventListener('submit', payWithPaystack, false);
    function payWithPaystack() {
        var reference = Math.floor((Math.random() * 1000000000) + 1)
  var handler = PaystackPop.setup({
      key: 'pk_test_c1f09ee2f9697cf65e03ac0050683a7c7498d6a0', // Replace with your public key
      name: '");
#nullable restore
#line 146 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n    email: \'");
#nullable restore
#line 147 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
       Write(CurrentUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n    amount: \'");
#nullable restore
#line 148 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
         Write(Model.GrandTotal * 100);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', // the amount value is multiplied by 100 to convert to the lowest currency unit
    currency: 'NGN', // Use GHS for Ghana Cedis or USD for US Dollars
      ref: reference, // Replace with a reference you generated
      callback: function (response) {
      /*window.location = ""/Payment/Receipt"";*/
          $.ajax({
              type: ""POST"",
              url: ""/Payment/SaveOrder"",// where you wanna post
              data: {
                  Name: name,
                  Razorpaykey: reference,
                  GrandTotal: amount,
                  userId: ");
#nullable restore
#line 160 "C:\Users\HP\Desktop\Projects\PizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                     Write(CurrentUser.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
              },
              
              error: function (jqXHR, textStatus, errorMessage) {
                  console.log(errorMessage); // Optional
              },
              success: function (data) { console.log(data) }
          });

      },



    //callback: function(response) {
    //  //this happens after the payment is completed successfully
    //  var reference = response.reference;
    //  alert('Payment complete! Reference: ' + reference);
      // Make an AJAX call to your server with the reference to verify the transaction
    //},
    onClose: function() {
      alert('Transaction was not completed, window closed.');
    },
  });
        handler.openIframe();



}
</script>


");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaymentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
