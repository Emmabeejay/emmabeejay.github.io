﻿using Aquafarms.Logic;
using Aquafarms.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Web.ModelBinding;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNet.Identity;

namespace Aquafarms
{
	public partial class ShoppingCart_aspx : System.Web.UI.Page, IDisposable
	{
		public string Amt { get; set; } = "";
		protected void Page_Load(object sender, EventArgs e)
		{
			ShoppingCartActions usersShoppingCart = new ShoppingCartActions();
			
			try
			{
				decimal cartTotal = 0;
				cartTotal = usersShoppingCart.GetTotal();
				Amt = cartTotal.ToString();
				if (cartTotal > 0)
				{
					// Display Total.
					lblTotal.Text = String.Format("{0:c}", cartTotal);
				}
				else
				{
					LabelTotalText.Text = "";
					lblTotal.Text = "";
					ShoppingCartTitle.InnerText = "Shopping Cart is Empty";
					//UpdateBtn_Click.Visible = false;
				}
			}
			finally
			{
				usersShoppingCart.Dispose();
			}
		}
		public List<CartItem> GetShoppingCartItems()
		{
			ShoppingCartActions actions = new ShoppingCartActions();
			return actions.GetCartItems();
		}

		public List<CartItem> UpdateCartItems()
		{
			ShoppingCartActions usersShoppingCart = new ShoppingCartActions();
			try
			{
				String cartId = usersShoppingCart.GetCartId();

				ShoppingCartActions.ShoppingCartUpdates[] cartUpdates = new ShoppingCartActions.ShoppingCartUpdates[CartList.Rows.Count];
				for (int i = 0; i < CartList.Rows.Count; i++)
				{
					IOrderedDictionary rowValues = new OrderedDictionary();
					rowValues = GetValues(CartList.Rows[i]);
					cartUpdates[i].ProductId = Convert.ToInt32(rowValues["ProductID"]);

					CheckBox cbRemove = new CheckBox();
					cbRemove = (CheckBox)CartList.Rows[i].FindControl("Remove");
					cartUpdates[i].RemoveItem = cbRemove.Checked;

					TextBox quantityTextBox = new TextBox();
					quantityTextBox = (TextBox)CartList.Rows[i].FindControl("PurchaseQuantity");
					cartUpdates[i].PurchaseQuantity = Convert.ToInt16(quantityTextBox.Text.ToString());
				}
				usersShoppingCart.UpdateShoppingCartDatabase(cartId, cartUpdates);
				CartList.DataBind();
				lblTotal.Text = String.Format("{0:c}", usersShoppingCart.GetTotal());
				return usersShoppingCart.GetCartItems();
			}
			finally
			{
				usersShoppingCart.Dispose();
			}
		}

		public static IOrderedDictionary GetValues(GridViewRow row)
		{
			IOrderedDictionary values = new OrderedDictionary();
			foreach (DataControlFieldCell cell in row.Cells)
			{
				if (cell.Visible)
				{
					// Extract values from the cell.
					cell.ContainingField.ExtractValuesFromCell(values, cell, row.RowState, true);
				}
			}
			return values;
		}

		protected void UpdateBtn_Click(object sender, EventArgs e)
		{
			UpdateCartItems();
		}
		protected void CheckoutBtn_Click(object sender, EventArgs e)
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
			Response.Redirect("Checkout/CheckoutStart.aspx");
		}
		protected void CheckoutImgBtn_Click(object sender, ImageClickEventArgs e)
		{

		}
	}
}