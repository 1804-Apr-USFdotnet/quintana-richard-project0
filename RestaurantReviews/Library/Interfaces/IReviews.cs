using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
	interface IReviews
	{
		int Review_Id { get; set; }
		int Rating { get; set; }
		string Customer { get; set; }
	}
}
