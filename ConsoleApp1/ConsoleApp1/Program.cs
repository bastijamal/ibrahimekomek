using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Hotel hotel1= new Hotel("relax");
			Room room = new Room("ab103", 23457, 54);

			hotel1.AddProduct(room);
			hotel1.MakeReservation(56);

			Console.WriteLine("-----------------------------------");



			bool exit = false;
			string choice;
			choice=Console.ReadLine();

			do
			{
				Console.WriteLine("xosh gelmisoozz");
				Console.WriteLine("1.sisteme girish");


				switch (choice)
				{
					case "1":
						Console.WriteLine("Sisteme girish");

						choice = Console.ReadLine();

						switch (choice)
						{
							case "1":
								Hotel hotel = new Hotel("maria");
								break;
							case "2":
								Console.WriteLine("butun oteller");
								 BatchBlock b                                                                                                                                                                                                              v
						break;
						}

						break;
				}




			} while (exit==true);

		}

		public delegate void Showinfo();

	}
}