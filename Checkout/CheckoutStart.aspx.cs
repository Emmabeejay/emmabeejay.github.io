using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aquafarms.Checkout
{
	public partial class CheckoutStart : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			
			if (Session["payment_amt"] != null)
			{
				string amt = Session["payment_amt"].ToString();

			}
			else
			{
				Response.Redirect("CheckoutError.aspx?ErrorCode=AmtMissing");
			}
		}
	}
}