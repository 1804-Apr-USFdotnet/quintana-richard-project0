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
		private RestaurantDBEntities db;
		public IEnumerable<Restaurants> GetRestaurant()
		{
			IEnumerable<Restaurants> result;
			using (db = new RestaurantDBEntities())
			{
				var dataList = db.Restaurant.ToList();
				result = dataList.Select(x => DataToLibrary(x)).ToList();
			}
			return result;
		}

		public void AddRestaurant(Restaurants item)
		{
			using (db = new RestaurantDBEntities())
			{
				db.Restaurant.Add(LibraryToData(item));
				db.SaveChanges();
			}
		}

		// mapping

		public static Restaurants DataToLibrary(Data.Restaurants dataModel)
		{
			var libModel = new Restaurants()
			{
				name = dataModel.names
			};
			return libModel;
		}

		public static Data.Restaurants LibraryToData(Restaurants libModel)
		{
			var dataModel = new Data.Restaurants()
			{
				names = libModel.name
			};
			return dataModel;
		}
	}
}
