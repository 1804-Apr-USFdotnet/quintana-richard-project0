using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSample1
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var db = new RestaurantDBEntities())
			{
				// Create and save a new Blog 
				Console.Write("Enter a name of restaurant: ");
				var name = Console.ReadLine();

				var restaurant = new Restaurant { names = name };
				db.Restaurants.Add(restaurant);
				db.SaveChanges();

				// Display all Blogs from the database 
				var query = from b in db.Restaurants
							orderby b.names
							select b;

				Console.WriteLine("All blogs in the database:");
				foreach (var item in query)
				{
					Console.WriteLine(item.names);
				}

				Console.WriteLine("Press any key to exit...");
				Console.ReadKey();
			}
		}
	}
}
