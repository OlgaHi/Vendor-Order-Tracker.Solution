using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using Tracker.Models;
using System;

namespace Tracker.Tests
{
  [TestClass]
  public class OrderTest
  {
    [TestMethod]
    public void OrderConstructor_CreatesObjectOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", 1, "1");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_Title()
    {
      //Arrange
      string title = "Pastry";
      string description = "";
      int price = 3;
      string date = "12/02/2000";

      //Act
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(title, result);
    }

  }
}