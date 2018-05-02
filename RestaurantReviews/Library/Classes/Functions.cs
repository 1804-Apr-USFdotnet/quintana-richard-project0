using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviews.Library.Interfaces;
using Data;

namespace RestaurantReviews.Library.Classes
{
	public class Functions : IFunctions
	{
		private List<Restaurants> restaurants;


		//Output all restaurants
		public List<Restaurants> Restaurants_overall(string arrange = "")
		{
			List<Restaurants> r = new List<Restaurants>();
			if (arrange != "")
			{
				arrange.ToLower();
				if (arrange.Contains("ascen"))
					restaurants.Sort();
				else
					restaurants = restaurants.OrderByDescending(x => x.rating).ToList(); 
				r = restaurants;
				restaurants = con.GetAllRestaurants();
				return r;
			}
			return restaurants;
		}

		// Searches for restaurant
		public Restaurants GetRestaurant(string name_of_restaurant)
		{ 
			return RestaurantSearch(name_of_restaurant)[0];
		}

		public string RestaurantDescribtions(string name_of_restaurant)
		{
			var rest = RestaurantSearch(name_of_restaurant)[0];

			return rest.ToString();
		}

		public List<Restaurants> RestaurantSearch(string search)
		{
			List<Restaurants> r = new List<Restaurants>();
			foreach (var restaurant in restaurants)
			{
				if (restaurant.names.Contains(search))
				{
					r.Add(restaurant);
				}
			}
			return r;
		}

		// Grab all of the reviews for the selected Restaurant
		public List<Reviews> Reviews(int restID)
		{
			List<Reviews> reviews = con.GetAllOfRestaurantsReviews(restID);

			return reviews;
		}
	}
}
