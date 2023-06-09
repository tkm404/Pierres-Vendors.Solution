using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresVendors.Models;
using System;

namespace PierresVendors.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test name", "test desc");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Suzie's Deli";
      Vendor newVendor = new Vendor(name, "test desc");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDesc_ReturnsDescription_String()
    {
      string desc = "Restaurant";
      Vendor newVendor = new Vendor("Suzie's Deli", desc);
      string result = newVendor.Description;
      Assert.AreEqual(desc, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name, "test desc");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_Vendor()
    {
      string name1 = "Test1";
      string name2 = "Test2";
      Vendor newVendor1 = new Vendor(name1, "testdesc1");
      Vendor newVendor2 = new Vendor(name2, "testdesc2");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "Test1";
      string name2 = "Test2";
      Vendor newVendor1 = new Vendor(name1, "testdesc1");
      Vendor newVendor2 = new Vendor(name2, "testdesc2");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string title = "bread";
      string desc = "bread product";
      int price = 4;
      string date = "some date";
      Order newOrder = new Order(title, desc, price, date);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Test1";
      string venDesc = "testdesc1";
      Vendor newVendor = new Vendor(name, venDesc);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void ClearAll_ClearsAllVendorsFromList_VendorList()
    {
      string name1 = "Test1";
      Vendor newVendor1 = new Vendor(name1, "testdesc1");
      List<Vendor> expected = new List<Vendor> { };
      Vendor.ClearAll();
      CollectionAssert.AreEqual(expected, Vendor.GetAll());
    }
  }
}