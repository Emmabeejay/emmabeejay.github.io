using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aquafarms.Models
{
	public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
	{
		protected override void Seed(ProductContext context)
		{
			GetCategories().ForEach(c => context.Categories.Add(c));
			GetProducts().ForEach(p => context.Products.Add(p));
		}

		private static List<Category> GetCategories()
		{
			var categories = new List<Category> {
				new Category
				{
					CategoryID = 1,
					CategoryName = "Farmer Products"
				},
				new Category
				{
					CategoryID = 2,
					CategoryName = "Consumer Products"
				},
			};

			return categories;
		}

		private static List<Product> GetProducts()
		{
			var products = new List<Product> {
				new Product
				{
					ProductID = 1,
					ProductName = "Fingerlings",
					Description = "4-6 weeks old",
					ImagePath="fingerling.jpg",
					UnitPrice = 20.75,
					CategoryID = 1
			   },
				new Product
				{
					ProductID = 2,
					ProductName = "Post Fingerlings",
					Description = "6-10 weeks old",
					ImagePath="post-fingerlings.jpg",
					UnitPrice = 25.75,
					 CategoryID = 1
			   },
				new Product
				{
					ProductID = 3,
					ProductName = "Juvenile",
					Description = "6-12 weeks old",
					ImagePath="juvenile",
					UnitPrice = 35.50,
					CategoryID = 1
				},
				new Product
				{
					ProductID = 4,
					ProductName = "Post Juvenile",
					Description = "12-15 weeks old!",
					ImagePath="post-juvenile.jpg",
					UnitPrice = 38.50,
					CategoryID = 1
				},
				new Product
				{
					ProductID = 5,
					ProductName = "Jumbo",
					Description = "Beyond 15 weeks!",
					ImagePath="jumbo.jpg",
					UnitPrice = 44.95,
					CategoryID = 1
				},
				new Product
				{
					ProductID = 6,
					ProductName = "Smoking",
					Description = "Approximately 20 weeks old!",
					ImagePath="roasting.jpg",
					UnitPrice = 650.00,
					CategoryID = 2
				},
				new Product
				{
					ProductID = 7,
					ProductName = "Smoked Fish",
					Description = "Our specially smoked and seasoned fish",
					ImagePath="roasted-catfish.jpg",
					UnitPrice = 1000.00,
					CategoryID = 2
				},
				new Product
				{
					ProductID = 8,
					ProductName = "Table-size",
					Description = "Averaged sized fish avalable once weekly",
					ImagePath="tablesize.jpg",
					UnitPrice = 1000.00,
					CategoryID = 2
				},
				new Product
				{
					ProductID = 9,
					ProductName = "Medium-Sized",
					Description = "Beyond 1Kg average weighted fishes for special order. Price is per Kg!",
					ImagePath="mediumsize.jpg",
					UnitPrice = 1150.00,
					CategoryID = 2
				},
				new Product
				{
					ProductID = 10,
					ProductName = "Big-sized",
					Description = "1500 average weighted fishes. Price is per unit!",
					ImagePath="fish-drawing.jpg",
					UnitPrice = 2050.00,
					CategoryID = 2
				},
				new Product
				{
					ProductID = 11,
					ProductName = "Large-sized",
					Description = "Beyond 2Kg weighted fishes. Price is per unit!",
					ImagePath="catfish-nobackground.jpg",
					UnitPrice = 2950.00,
					CategoryID = 2
				},
				new Product
				{
					ProductID = 12,
					ProductName = "Male-Broodstock",
					Description = "Over 12-months old male fishes ready for reproduction.",
					ImagePath="broodstock.jpg",
					UnitPrice = 6000.00,
					CategoryID = 1
				},
				new Product
				{
					ProductID = 13,
					ProductName = "Female-Broodstock",
					Description = "Over 12-months old female fishes with eggs ready for hatching.",
					ImagePath="broodstock.jpg",
					UnitPrice = 10000.00,
					CategoryID = 1
				},
				
			};

			return products;
		}
	}

}