using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System.Collections.Generic;
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
      Vendor newVendor = new Vendor("Pierres Bagels", "Authentic bagels from the NW");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void VendorInformation_CreatesNameAndDescription_String()
    {
      string name = "Pierres Bagels";
      string description = "Authentic bagels from the NW";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Name;
      string result2 = newVendor.Description;
      Assert.AreEqual(name, result);
      Assert.AreEqual(description, result2);
    
    }

    [TestMethod]
    public void GetVendorId_ReturnsVendorId_Int()
    {
      string name = "Pierres Bagels";
      string description = "Authentic bagels from the NW";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorsObjects_VendorList()
    {
      string name1 = "Pierres Bagels";
      string name2 = "Authentic bagels from the NW";
      string description1 = "Pierres Lox";
      string description2 = "Authentic Lox the NW";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void FindVendor_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "Pierres Bagels";
      string name2 = "Authentic bagels from the NW"; 
      string description1 = "Pierres Lox";
      string description2 = "Authentic Lox the NW"; 
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

  [TestMethod]
  public void AddOrder_OrderPlacedFromVendor_OrderList()
  {
    string name = "Pierres Bagels";
    string description = "Authentic bagels from the NW";
    Vendor newVendor = new Vendor(name, description);
    List<Order> newList = new List<Order> { newOrder };
    newVendor.AddOrder(newOrder);

    List<Order> result = newVendor.Orders;
    CollectionAssert.AreEqual(newList, result);
  }


  }
}