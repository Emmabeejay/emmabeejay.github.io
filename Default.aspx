<%@ Page Title="Welcome to Aquafarms" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Aquafarms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<section id="head-container">
		<header>
			<h1 id="top"><%: Title %></h1>
		</header>
		<!--<h2>Connecting consumers and farmers together for all your aquatic needs.</h2>-->
		<h2 style="text-align: center">Connecting consumers to aqua farm products directly from the farm.</h2>
	</section>
	<section class="intro-container">
		<img src="Images/fish10.jpg" />
	</section>
	<!--<div class="box-container">
		<img src="Images/fish10.jpg" />
	</div>-->
	<section class="box-container">
		<div>
			<h1> Aquafarms is for everyone who consumes Aquatic products.</h1>
			<ul class="service-list">
				<li> 
					<a href="#" title="fish for households, women and wifes">
						<h3>Household</h3>
						<h4>Buy one-off and pick-up at your convenience</h4>
					</a>
				</li>
				<li> 
					<a href="#" title="fish for hotels, restaurants and bar owners">
						<h3>Restaurants & Bars</h3>
						<h4>Subscribe to a monthly/weekly based delivery</h4>
					</a>
				</li>
				<li> 
					<a href="#" title="fish for social events, parties">
						<h3>Socials</h3>
						<h4>Buy in advance and schedule delivery to specific date</h4>
					</a>
				</li>
			</ul>
		</div>
		<section class="container11">
			<div class="box-container-layout">
				<div>
					<h2> Connecting consumers directly to farmers.</h2>
					<p>Our products are delivered from a select of the most reputable farmers in your city.</p>
					<div>
						<a href="#" class="btn"> Shop Now</a>
					</div>
				</div>
				<section class="img-content-container">
					<img src="Images/consumer-farmer.jpg" alt="#">
				</section>
			</div>
		</section>
		<div class="short-text">
			<h2>Satisfaction Guaranteed</h2>
			Shop with peace of mind with our 100% risk free shopping
			<br>
			Get a full refund if unhappy with the product received.
		</div>
	</section>

	<hr>
	<div>
		<div id="container3">
			<div id="row7">
				<button class="btn">Prices</button>
			</div>
			<div id="newsletter-container">
				<p>Join our Newsletter to recieve deals and specials</p>
				<div>
					<span class="footer-subscribenewsletteremail">
						Email *

					</span>
					<span class="footer-subscribenewslettersubmit">
						Subscribe
					</span>
				</div>
			</div>
			<div id="row8">
				<button class="btn">Specials</button>
			</div>
		</div>
		<div class="short-text">
			<h2>Customer satisfaction is our priority</h2>
			Order now and choose one of our 3-delivery methods at checkout
			<div>
				<ul class="service-list-minor">
						<li>
							<a href="#" title="Aquafarms spot pick up">
							<h4>Spot Pick-Up</h4>
							Pick up at any of our locations nearest to you
						</a>
					</li>
					<li>
						<a href="#">
							<h4>Farm Pick-Up</h4>
							Visit our farm location to pick up your order
						</a>
					</li>
					<li>
                        <a href="#">
							<h4>Home Delivery</h4>
							See if your address is in our service areas
                        </a>
					</li>
				</ul>
			</div>
		</div>
	</div>
	<hr>
	<section class="box-container">
		<h1 id="top3">Product Categories</h1>
		<div class="box-container-layout">			
			<div class="img-content-container">
				<img src="Images/Tilapia1.jpg" />
				<!--<h2 id="top2">Fingerlings</h2>-->
				<button class="btn">Tilapia</button>
			</div>
			<p>Shop Tilapia fish</p>
			<div>
				<p>Shop our Catfish category</p>
			</div>
			<div class="img-content-container">
				<img src="Images/catfish-nobackground.jpg" />
				<button class="btn">Catfish</button>
			</div>
			<div class="img-content-container">
				<img src="Images/kote.jpg" />
				<button class="btn">Horse Mackerel (Kote)</button>
			</div>
			<p>Shop Kote category</p>
		</div>
	</section>
</asp:Content>
