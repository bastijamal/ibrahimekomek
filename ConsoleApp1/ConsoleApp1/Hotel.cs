using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Hotel
	{

		public string Name { get; set; }

		public List<Room> rooms = new List<Room>();

		public Hotel(string name) 
		{
			Name = name;
		}

		public void AddProduct(Room room)
		{
			rooms.Add(room);
		}

		public Room MakeReservation( int? roomId)
		{
			if(roomId==null) throw new NullReferenceException("ID SEHV DAXIL OLUNUB");

			foreach (Room room in rooms)
			{
				if (room.IsAvialable)
				{
					Console.WriteLine("rezerv olundu");
					room.IsAvialable = false;
					Console.WriteLine(room);
				}
				else
				{
					Console.WriteLine("artiq rezerv olunub");
				}
			}
			return null;

		}

=

	}
}
