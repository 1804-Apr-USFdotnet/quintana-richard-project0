using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
	class Restaurants
	{
		// fields
		private string _name;
		private string _address;
		private string _city;
		private string _state;
		private string _zipcode;

		// constructors
		public Restaurants (string name, string address, string city, string state, string zipcode)
		{
			_name = name;
			_address = address;
			_city = city;
			_state = state;
			_zipcode = zipcode;
		}

		// implementations
		public string name { get { return _name; } set { _name = value; } }
		public string address { get { return _address; } set { _address = value; } }
		public string city { get { return _city; } set { _city = value; } }
		public string state { get { return _state; } set { _state = value; } }
		public string zipcode { get { return _zipcode; } set { _zipcode = value; } }

		public Restaurants()
		{
			_name = "";
			_address = "";
			_city = "";
			_state = "";
			_zipcode = "";
		}
	}
}
