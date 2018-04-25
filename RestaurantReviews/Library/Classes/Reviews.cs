using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
	class Reviews : IReviews
	{
		// fields
		private int _Rating;
		private string _Customer;

		// constructors
		public Reviews(int Rating, string Customer)
		{
			_Rating = Rating;
			_Customer = Customer;
		}

		// implementations
		public int Rating { get { return _Rating; } set { _Rating = value; } }
		public string Customer { get { return _Customer; } set { _Customer = value; } }
	}
}
