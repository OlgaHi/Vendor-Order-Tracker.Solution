using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;
using System.Collections.Generic;
using System;

namespace Tracker.Tests
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
      Vendor newVendor = new Vendor("", "");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = " ";
      Vendor newVendor = new Vendor(name, "");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetName_ReturnsName_String()
    {
      string name = " ";
      Vendor newVendor = new Vendor(name, "");
      string updatedName = "Picasso";
      newVendor.Name = updatedName;
      string result = newVendor.Name;
      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "";
      Vendor newVendor = new Vendor(name, "");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name1 = "Kolosok";
      string name2 = "Hot bread";
      Vendor newVendor1 = new Vendor(name1, "");
      Vendor newVendor2 = new Vendor(name2, "");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "Kolosok";
      string name2 = "Hot bread";
      Vendor newVendor1 = new Vendor(name1, "");
      Vendor newVendor2 = new Vendor(name2, "");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string vendorName = "Kolosok";
      Vendor newVendor = new Vendor(vendorName, "");
      string titleOrder = "Pastry";
      Order newOrder = new Order(titleOrder, "", 1, "");
      List<Order> newList = new List<Order> { newOrder }; 
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}