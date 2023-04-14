using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarWPF
{
    internal class UsersChoice
    {
		private DateTime _date;

		public DateTime _Date
		{
			get { return _date; }
			set { _date = value; }
		}
		private List<FoodModel> _userListFood;

		public List<FoodModel> _UserListFood
		{
			get { return _userListFood; }
			set { _userListFood = value; }
		}


	}
}
