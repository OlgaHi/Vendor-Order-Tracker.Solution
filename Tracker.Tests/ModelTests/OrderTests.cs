using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using Tracker.Models;
using System;

namespace Tracker.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesObjectOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", 1, "1");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_Title()
    {
      string title = "Pastry";
      string description = "";
      int price = 3;
      string date = "12/02/2000";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "";
      Order newOrder = new Order("", description, 1, "");
      string updatedDescription = "cookies";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string description = "";
      Order newOrder = new Order("", description, 1, "");
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    } 

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      Order newOrder1 = new Order("", "", 1, "");
      Order newOrder2 = new Order("", "", 2, "");
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}