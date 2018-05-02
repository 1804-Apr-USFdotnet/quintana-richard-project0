using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Library.Interfaces
{
	interface IRestaurants
	{
		int restaurant_id { get; set; }
		string name { get; set; }
		string address { get; set; }
		string city { get; set; }
		string state { get; set; }
		string zipcode { get; set; }
		double rating { get; set; }
	}
}
