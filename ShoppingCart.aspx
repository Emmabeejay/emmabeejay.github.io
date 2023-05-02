<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="Aquafarms.ShoppingCart_aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="ShoppingCartTitle" runat="server" class="ContentHead"><h1>Shopping Cart</h1></div>
    <asp:GridView ID="CartList" runat="server" AutoGenerateColumns="False" ShowFooter="True" GridLines="Vertical" CellPadding="4"
        ItemType="Aquafarms.Models.CartItem" SelectMethod="GetShoppingCartItems" 
        CssClass="table table-striped table-bordered" >   
        <Columns>
        <asp:BoundField DataField="ProductID" HeaderText="ID" SortExpression="ProductID" />        
        <asp:BoundField DataField="Product.ProductName" HeaderText="Name" />        
        <asp:BoundField DataField="Product.UnitPrice" HeaderText="Price (each)" DataFormatString="{0:c}"/>     
        <asp:TemplateField   HeaderText="Quantity">            
                <ItemTemplate>
                    <asp:TextBox ID="PurchaseQuantity" Width="40" runat="server" Text="<%#: Item.Quantity %>"></asp:TextBox> 
                </ItemTemplate>        
        </asp:TemplateField>    
        <asp:TemplateField HeaderText="Item Total">
                <ItemTemplate>
                    <%#: String.Format( new System.Globalization.CultureInfo("en-NG"), "{0:c}", ((Convert.ToDouble(Item.Quantity)) *  Convert.ToDouble(Item.Product.UnitPrice)))%>

                </ItemTemplate>
        </asp:TemplateField> 
        <asp:TemplateField HeaderText="Remove Item">            
                <ItemTemplate>
                    <asp:CheckBox id="Remove" runat="server"></asp:CheckBox>
                </ItemTemplate>        
        </asp:TemplateField>    
        </Columns>    
    </asp:GridView>
    <div>
        <strong>
            <asp:Label ID="LabelTotalText" runat="server" Text="Order Total: "></asp:Label>
            <asp:Label ID="lblTotal" runat="server" EnableViewState="false"></asp:Label>
            
        </strong> 
    </div>
    <br />
    <table> 
    <tr>
      <td>
        <asp:Button runat="server" Text="Update" OnClick="UpdateBtn_Click" />
      </td>
      <td>
        <!--Checkout Placeholder -->
        <asp:Label ID="cartTotal" runat="server" EnableViewState="false"></asp:Label>
        <button Type="button" OnClick="payWithPaystack()" > Checkout </button>
        <!--<asp:Button ID="CheckoutBtn" runat="server" Text="paystackCheckout" OnClick="CheckoutBtn_Click" />-->
      </td>
    </tr>
    </table>

    <script>
        var cost = <%=Amt%>;
        function payWithPaystack() {
            var price = cost;
            var handler = PaystackPop.setup({
                key: 'pk_live_eba0369d4c67db4634d4c7a032edad8ce2c0cf5b',
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
                    alert(cost);
                }
            });
            handler.openIframe();
        }
    </script>
    <script src="https://js.paystack.co/v1/inline.js"></script>

</asp:Content>
