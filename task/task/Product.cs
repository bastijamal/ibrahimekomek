using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
	internal class Product
	{
		public int No { get; set; }
		private int _no;
		private int _price;
		public int Price { 
			get {
				return _price;
			} 
			set {
				if (value > 0)
				{
				 _price= value;
				}

				else {
					throw new PriceMustBeGratherThanZeroException("qiymet 0 menfi olammaz");
				}
			} 
		}
		public string Name { get; set; }

		public Type Type { get; set; }
		public Product()
		{
			No= ++ _no;
		}
	}
}
