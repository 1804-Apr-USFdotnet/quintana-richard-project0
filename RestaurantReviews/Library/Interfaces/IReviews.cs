using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
	interface IReviews
	{
		int Rating { get; set; }
		string Customer { get; set; }
	}
}
