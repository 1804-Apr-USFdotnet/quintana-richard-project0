using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Library.Classes
{
	public class LibraryHelper
	{
		public IEnumerable<Restaurants> GetRestaurants()
		{
			IEnumerable<Restaurants> result;
			using (var db = new RestaurantDBEntities())
			{
				var dataList = db.Restaurants.ToList();
				result = dataList.Select(x => DataToLibrary(x)).ToList();
			}
			return result;
		}

		private Restaurants DataToLibrary(Data.Restaurants x)
		{
			throw new NotImplementedException();
		}

		public void AddRestaurants(Restaurants item)
		{
			using (var db = new RestaurantDBEntities())
			{
				//db.Restaurants.Add(LibraryToData(item));
				db.SaveChanges();
			}
		}

		// mapping

		public static Restaurants DataToLibrary(Data.Restaurant dataModel)
		{
			var libModel = new Restaurants()
			{
				name = dataModel.Name
			};
			return libModel;
		}

		public static Data.Restaurant LibraryToData(Restaurants libModel)
		{
			var dataModel = new Data.Restaurant()
			{
				Name = libModel.name
			};
			return dataModel;
		}
	}
}
