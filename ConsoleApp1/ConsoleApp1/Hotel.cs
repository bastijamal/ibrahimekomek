using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Hotel
	{

		//- MakeReservation() - Parametr olaraq nullable int tipindən bir roomId qəbul edir əgər roomId null olaraq geriyə NullReferanceException qaytarır əks halda göndərilən
		//			 roomId-li otaq


		public string Name { get; set; }
		public List<Room> rooms;

		public void AddProduct(Room room)
		{
			rooms.Add(room);
		}

		public Room MakeReservation( int roomId)
		{
			return rooms.FirstOrDefault(p => p.Id == roomId)!;
		}

	}
}
