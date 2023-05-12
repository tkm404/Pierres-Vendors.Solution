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
      Order newOrder = new Order("buns", "bread product", 4, "05/12/2023");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void SetTitle_SetsTitleOfOrder_Order()
    {
      string title = "buns";
      Order newOrder = new Order(title, "bread product", 4, "05/12/2023");
      Assert.AreEqual(title, newOrder.Title);
    }
    
    [TestMethod]
    public void SetDescription_SetsDescriptionOfOrder_Order()
    {
      string desc = "bread product";
      Order newOrder = new Order("buns", desc, 4, "05/12/2023");
      Assert.AreEqual(desc, newOrder.Description);
    }
  }
}