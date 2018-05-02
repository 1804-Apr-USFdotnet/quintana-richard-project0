using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviews.Library.Classes;
using System.Xml.Serialization;

namespace RestaurantReviews.Library.Interfaces
{
	interface IFunctions
	{
		List<Restaurants> Read();

		void Write(List<Restaurants> restaurants);

		//Search for restarurants
		List<Restaurants> RestaurantSearch(string search);

		//Descriptions of restaurants
		string RestaurantDescribtions(string name_of_restaurant);

		//Output restaurant
		Restaurants GetRestaurant(string name_of_restaurant);

		//Arrange restaurants
		List<Restaurants> Restaurants_overall(string arrange = "");
	}
}
