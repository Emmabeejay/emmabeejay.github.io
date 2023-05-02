<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckoutStart.aspx.cs" Inherits="Aquafarms.Checkout.CheckoutStart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <input ID="myValue" type="hidden" runat="server" />

    <script src="https://js.paystack.co/v1/inline.js"></script>
    <script>
        function payWithPaystack() {
            var amount = '@amt';
            var cost = document.getElementById("myValue").value;
            var handler = PaystackPop.setup({
                key: 'pk_test_03e94000c87ce9aedfdb27d9d3abb8926e704441',
                email: 'emmabeejay@gmail.com',
                amount: cost,
                ref: '' + Math.floor((Math.random() * 1000000000) + 1), // generates a pseudo-unique reference. Please replace with a reference you generated. Or remove the line entirely so our API will generate one for you
                metadata: {
                    custom_fields: [
                        {
                            display_name: "Mobile Number",
                            variable_name: "mobile_number",
                            value: "+2348012345678"
                        }
                    ]
                },
                callback: function (response) {
                    alert('success. transaction ref is ' + response.reference);
                },
                onClose: function () {
                    alert('window closed');
                }
            });
            handler.openIframe();
        }
    </script>
    <button type="button" onclick="payWithPaystack()"> Pay </button> 

    
</asp:Content>

