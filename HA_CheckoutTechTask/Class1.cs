using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA_CheckoutTechTask
{
    public interface ICheckout
    {
		void Scan(string item);
		int GetTotalPrice();
	}

	public class Checkout : ICheckout
	{
		public void Scan(string item)
		{ }
		public int GetTotalPrice() 
		{
			return 0; 
		}
	}
}
