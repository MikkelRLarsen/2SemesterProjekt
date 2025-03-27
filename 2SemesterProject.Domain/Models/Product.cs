using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Models
{
	public class Product
	{
		public int ProductID { get; private set; }
		public string ProductName { get; private set; }
		public double ProductPrice { get; private set; }

		public List<ProductLine> ProductLines { get;}

		public Product(int productID, string productName, double productPrice)
		{
			ProductID = productID;
			ProductName = productName;
			ProductPrice = productPrice;
		}


		/// <summary>
		/// Checks if ProductID and ProductPrice is greater than 0 and if ProductName contains any numbers or speciel characters
		/// </summary>
		/// <returns>Bool</returns>
		protected bool InformationValid()
		{
			Debug.Assert(ProductID != null, "ProductID was null");
			Debug.Assert(ProductPrice != null, "ProductPrice was null");

			if (ProductID == 0) return false;
			if (ProductName.Any(ch => !char.IsLetterOrDigit(ch))) return false;
			if (ProductName.Any(ch => !char.IsDigit(ch))) return false;
			if (ProductPrice >  0) return false;

			return true;

		}
	}
}
