using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresVendors.Models;
using System;

namespace PierresVendors.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("buns", "bread product", 4);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void SetTitle_SetsTitleOfOrder_Order()
    {
      string title = "buns";
      Order newOrder = new Order(title, "bread product", 4);
      Assert.AreEqual(title, newOrder.Title);
    }
    
    [TestMethod]
    public void SetDescription_SetsDescriptionOfOrder_Order()
    {
      string desc = "bread product";
      Order newOrder = new Order("buns", desc, 4);
      Assert.AreEqual(desc, newOrder.Description);
    }

    [TestMethod]
    public void SetPrice_SetsPriceOfOrder_Order()
    {
      int price = 4;
      Order newOrder = new Order("buns", "bread product", price);
      Assert.AreEqual(price, newOrder.Price);
    }
    [TestMethod]
    public void PurchaseDate_SetsDateOfOrder_DateTime()
    {
      DateTime expectedDate = new DateTime(2023, 5, 12);
      Order newOrder = new Order("buns", "bread product", 4);
      DateTime actualDate = newOrder.PurchaseDate(2023, 5, 12);
      string expected = expectedDate.ToString();
      string actual = actualDate.ToString();
      Assert.AreEqual(expected, actual);
    }
  }
}