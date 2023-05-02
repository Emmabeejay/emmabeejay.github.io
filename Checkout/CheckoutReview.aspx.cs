using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Web.ModelBinding;
using Aquafarms.Logic;
using Aquafarms.Models;

namespace Aquafarms.Checkout
{
	public partial class CheckoutReview : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
		protected void CheckoutConfirm_Click(object sender, EventArgs e)
		{
			ShoppingCartActions usersShoppingCart = new ShoppingCartActions();
			try
			{
				Session["payment_amt"] = usersShoppingCart.GetTotal();
			}
			finally
			{
				usersShoppingCart.Dispose();
			}
			Response.Redirect("CheckoutStart.aspx");
		}
	}
	
}