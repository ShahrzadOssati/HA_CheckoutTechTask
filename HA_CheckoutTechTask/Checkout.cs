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
		private List<string> scannedItems = new List<string>();

		public void Scan(string item)
		{
			//Add item to the list
			//Note: there is no requirement in the problem state for handling
			//      invalid SKUs and thhis method returning void would
			//      necessitate adding exceptions to  alert the caller that an
			//      invalid product with no price had been scanned. I have
			//      opted to not implement this as this was not in the requirements
			scannedItems.Add(item);
		}

		public int GetTotalPrice() 
		{
			int totalPriceA = 0, totalPriceB = 0, totalPriceC = 0, totalPriceD = 0;

			//Calculating the total price based on the content elements in the list

			int countA = scannedItems.Count(item => item == "A");
			int countB = scannedItems.Count(item => item == "B");
			int countC = scannedItems.Count(item => item == "C");
			int countD = scannedItems.Count(item => item == "D");

			//Total for A			
			totalPriceA = ((countA % 3) * 50) + ((countA / 3) * 130);
			//Total for B
			totalPriceB = ((countB % 2) * 30) + ((countB / 2) * 45);

			totalPriceC = countC * 20;
			totalPriceD = countD * 15;

			Console.WriteLine("Calculating total price...");
			return totalPriceA + totalPriceB + totalPriceC + totalPriceD;
		}
	}
}
