using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProject.Domain.Models
{
	public class ProductLine
	{
		public int ProductLineID { get; private set; }
		public int ProductID { get; private set; }
		public int OrderID { get; private set; }
		public Product Product { get;}
		public Order Order { get;}

		public ProductLine(int productLineID, int productID, int orderID)
		{
			ProductLineID = productLineID;
			ProductID = productID;
			OrderID = orderID;

			BindingList<Order> orders = new BindingList<Order>(new List<Order>());
		}

		/// <summary>
		/// Checks if ProductLineID or ProductID or OrderID is greater than 0
		/// </summary>
		/// <returns>Bool</returns>
		protected bool InformationValid()
		{
			Debug.Assert(ProductLineID != null, "ProductLineID is null");
			Debug.Assert(OrderID != null, "OrderID was null");
			Debug.Assert(ProductID != null, "ProductID was null");

			if (ProductLineID == 0) return false;
			if (OrderID == 0) return false;
			if (ProductID == 0) return false;

			return true;
		}
	}
}
