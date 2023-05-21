using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System;
using System.Collections.Generic;

namespace PierresVendors.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("buns", "bread product", 4, "some year");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void SetTitle_SetsTitleOfOrder_Order()
    {
      string title = "buns";
      Order newOrder = new Order(title, "bread product", 4, "some year");
      Assert.AreEqual(title, newOrder.Title);
    }
    
    [TestMethod]
    public void SetDescription_SetsDescriptionOfOrder_Order()
    {
      string desc = "bread product";
      Order newOrder = new Order("buns", desc, 4, "some year");
      Assert.AreEqual(desc, newOrder.Description);
    }

    [TestMethod]
    public void SetPrice_SetsPriceOfOrder_Order()
    {
      int price = 4;
      Order newOrder = new Order("buns", "bread product", price, "some year");
      string dollars = "$4";
      Assert.AreEqual(dollars, newOrder.Price);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsCorrectItems_OrderList()
    {
      Order newOrder1 = new Order("buns", "bread product", 4, "some year");
      Order newOrder2 = new Order("loaves", "bread product", 6, "some year");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
        [TestMethod]
    public void ClearAll_ClearsAllVendorsFromList_VendorList()
    {
      Order newOrder1 = new Order("buns", "bread product", 4, "some year");
      List<Order> expected = new List<Order> { };
      Order.ClearAll();
      CollectionAssert.AreEqual(expected, Order.GetAll());
    }
    
  }
}