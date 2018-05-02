using Data;
using Library.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews
{ 
	class MainClass
	{
	/*
		static void PrintReview(IReviews p)
		{
			Console.WriteLine("Rating={0}", p.Rating);
		}

		static void Main(string[] args)
		{
			Reviews p = new Reviews
		}
	*/

		static void Main(string[] args)
		{
			Console.WriteLine("Enter new Restaurant name: ");
			var newName = Console.ReadLine();

			var libHelper = new LibraryHelper();
			libHelper.AddRestaurant(new Library.Classes.Restaurants() { name = newName });
			// saves changes, updates dbsets

			var results = libHelper.GetRestaurant();
			Console.WriteLine("All stored restaurants:");
			foreach (var restaurant in results)
				Console.WriteLine(restaurant.name);

			Console.ReadKey();
		}
	}
}
