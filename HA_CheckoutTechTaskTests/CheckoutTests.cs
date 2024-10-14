using Microsoft.VisualStudio.TestTools.UnitTesting;
using HA_CheckoutTechTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA_CheckoutTechTask.Tests
{
	[TestClass()]
	public class CheckoutTests
	{
		[TestMethod()]
		public void ScanTest()
		{
			Assert.Fail();
		}
		[TestMethod()]
		public void GetTotalPriceTest()
		{
			Assert.Fail();
		}

		[TestMethod()]
		public void TestEmpty()
		{
			ICheckout checkout = new Checkout();
			checkout.Scan("");
			int thePrice = checkout.GetTotalPrice();
			Assert.AreEqual(thePrice, 0);
		}

		[TestMethod()]
		public void TestA()
		{
			ICheckout checkout = new Checkout();
			checkout.Scan("A");
			int thePrice = checkout.GetTotalPrice();
			Assert.AreEqual(thePrice, 50);
		}

		[TestMethod()]
		public void TestAB()
		{
			ICheckout checkout = new Checkout();
			checkout.Scan("A");
			checkout.Scan("B");
			int thePrice = checkout.GetTotalPrice();
			Assert.AreEqual(thePrice, 80);
		}

		[TestMethod()]
		public void TestCDBA()
		{
			ICheckout checkout = new Checkout();
			checkout.Scan("C");
			checkout.Scan("D");
			checkout.Scan("B");
			checkout.Scan("A");
			int thePrice = checkout.GetTotalPrice();
			Assert.AreEqual(thePrice, 115);
		}
		[TestMethod()]
		public void TestAA()
		{
			ICheckout checkout = new Checkout();
			checkout.Scan("A");
			checkout.Scan("A");
			int thePrice = checkout.GetTotalPrice();
			Assert.AreEqual(thePrice, 100);
		}

		[TestMethod()]
		public void TestAAA()
		{
			ICheckout checkout = new Checkout();
			checkout.Scan("A");
			checkout.Scan("A");
			checkout.Scan("A");
			int thePrice = checkout.GetTotalPrice();
			Assert.AreEqual(thePrice, 130);
		}

		[TestMethod()]
		public void TestAAAA()
		{
			ICheckout checkout = new Checkout();
			checkout.Scan("A");
			checkout.Scan("A");
			checkout.Scan("A");
			checkout.Scan("A");
			int thePrice = checkout.GetTotalPrice();
			Assert.AreEqual(thePrice, 180);
		}
		[TestMethod()]
		public void TestAAAAA()
		{
			ICheckout checkout = new Checkout();
			checkout.Scan("A");
			checkout.Scan("A");
			checkout.Scan("A");
			checkout.Scan("A");
			checkout.Scan("A");
			int thePrice = checkout.GetTotalPrice();
			Assert.AreEqual(thePrice, 230);
		}
		[TestMethod()]
		public void TestAAAAAA()
		{
			ICheckout checkout = new Checkout();
			checkout.Scan("A");
			checkout.Scan("A");
			checkout.Scan("A");
			checkout.Scan("A");
			checkout.Scan("A");
			checkout.Scan("A");
			int thePrice = checkout.GetTotalPrice();
			Assert.AreEqual(thePrice, 260);
		}

		[TestMethod()]
		public void TestAAAB()
		{
			ICheckout checkout = new Checkout();
			checkout.Scan("A");
			checkout.Scan("A");
			checkout.Scan("A");
			checkout.Scan("B");
			int thePrice = checkout.GetTotalPrice();
			Assert.AreEqual(thePrice, 160);
		}

		[TestMethod()]
		public void TestAAABB()
		{
			ICheckout checkout = new Checkout();
			checkout.Scan("A");
			checkout.Scan("A");
			checkout.Scan("A");
			checkout.Scan("B");
			checkout.Scan("B");
			int thePrice = checkout.GetTotalPrice();
			Assert.AreEqual(thePrice, 175);
		}

		[TestMethod()]
		public void TestAAABBD()
		{
			ICheckout checkout = new Checkout();
			checkout.Scan("A");
			checkout.Scan("A");
			checkout.Scan("A");
			checkout.Scan("B");
			checkout.Scan("B");
			checkout.Scan("D");
			int thePrice = checkout.GetTotalPrice();
			Assert.AreEqual(thePrice, 190);
		}

		[TestMethod()]
		public void TestDABABA()
		{
			ICheckout checkout = new Checkout();
			checkout.Scan("D");
			checkout.Scan("A");
			checkout.Scan("B");
			checkout.Scan("A");
			checkout.Scan("B");
			checkout.Scan("A");
			int thePrice = checkout.GetTotalPrice();
			Assert.AreEqual(thePrice, 190);
		}

		[TestMethod()]
		public void TestDABABAA()
		{
			ICheckout checkout = new Checkout();
			checkout.Scan("D");
			checkout.Scan("A");
			checkout.Scan("B");
			checkout.Scan("A");
			checkout.Scan("A"); // A qualifying discount
			checkout.Scan("B"); // B qualifying Discount
			checkout.Scan("A"); //this should be full price 50
			int thePrice = checkout.GetTotalPrice();
			Assert.AreEqual(thePrice, 240);
		}
		[TestMethod()]
		public void TestIncrementalAOnly() 
		{
			ICheckout checkout = new Checkout();
			checkout.Scan("A");
			Assert.AreEqual(checkout.GetTotalPrice(), 50);
			checkout.Scan("A");
			Assert.AreEqual(checkout.GetTotalPrice(), 100);
			checkout.Scan("A");
			Assert.AreEqual(checkout.GetTotalPrice(), 130);
			checkout.Scan("A");
			Assert.AreEqual(checkout.GetTotalPrice(), 180);
		}
	}
}