using Aquafarms.Logic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aquafarms
{
	public partial class AddToCart : System.Web.UI.Page, IDisposable
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string rawId = Request.QueryString["ProductID"];
			int productId;
			if (!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out productId))
			{
				ShoppingCartActions usersShoppingCart = new ShoppingCartActions();
				try
				{
					usersShoppingCart.AddToCart(Convert.ToInt16(rawId));

				}
				finally
				{
					usersShoppingCart.Dispose();
				}


			}
			else
			{
				Debug.Fail("ERROR : We should never get to AddToCart.aspx without a ProductId.");
				throw new Exception("ERROR : It is illegal to load AddToCart.aspx without setting a ProductId.");
			}
			Response.Redirect("ShoppingCart.aspx");
		}

	}
	
}