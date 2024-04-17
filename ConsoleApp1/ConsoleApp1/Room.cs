using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Program;
using System.Xml.Linq;
using System.Data.SqlTypes;
using System.Reflection.Metadata;

namespace ConsoleApp1
{
	internal class Room
	{

		//- Id - qıraqdan set etmək olmayacaq yalnız get etmək olacaq və hər dəfə yeni bir Employeee obyekt yaradıldıqda avtomatik bir vahid artacaq.

		private static int _id;
		public int Id { get; set; }

		public string Name { get; set; }

		public int Price { get; set; }
		public int PersonCapacity { get; set; }

		bool IsAvialable=true;

		public Room(string name,int price, int perscap)
		{
			Id = ++_id;
			Name = name;
			Price = price;
			PersonCapacity = perscap;
			
		}


		public string ShowInfo()
		{
			return ($" ID: {Id} name: {Name} price: {Price} personcapacity:{PersonCapacity} isavailable:{IsAvialable}");

		}

		public override string ToString()
		{
			return ShowInfo();	
		}





	}
}
