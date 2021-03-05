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

    
  }
}