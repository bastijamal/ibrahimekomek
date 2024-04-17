using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
	internal class Store
	{

		public List<Product>? productrs;


		public void AddProduct(Product product)
		{
			productrs.Add(product);	
		}

		public Product RemoveProduct(int? no)
		{
			var selectedProduct = productrs.FirstOrDefault(x => x.No == no);
			if (selectedProduct != null)
			{
				productrs.Remove(selectedProduct);
			}
			return selectedProduct!;
		}


		public Product GetProduct(int? no) {
			return productrs?.FirstOrDefault(p => p.No == no)!;
		}

		public List<Product> FilterProductsByType(Type type)
		{
			var selectedProduct =productrs.Where(p=>p.Type==type).ToList();
			return selectedProduct;
		}

		public List<Product> FilterProductsByName(string name)
		{
			var selectedProduct = productrs.Where(p => p.Name == name).ToList();
			return selectedProduct;
		}


	}
}
