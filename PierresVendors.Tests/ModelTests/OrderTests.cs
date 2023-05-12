using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresVendors.Models;
using System;

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
      Order newOrder = new Order("Pierres Bagels", "12 sesame bagels", "May 12, 2023", 25);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderInformation_ReturnsInformation_String()
    {
      string title = "Pierres Bagels";
      string information = "12 sesame bagels";
      string date = "May 12, 2023";
      int price = 25;
      Order newOrder = new Order(title, information, date, price);
      string result1 = newOrder.Title;
      string result2 = newOrder.Information;
      string result3 = newOrder.Date;
      int result4 = newOrder.Price;
      Assert.AreEqual(title, result1);
      Assert.AreEqual(information, result2);
      Assert.AreEqual(date, result3);
      Assert.AreEqual(price, result4);
    }

    [TestMethod]
    public void SetOrderDescription_SetDescription_String()
    {
      string title = "Pierres Bagels";
      string information = "12 sesame bagels";
      string date = "May 12, 2023";
      int price = 25;
      Order newOrder = new Order(title, information, date, price);
      string updatedInformation = "24 poppy seed bagels";
      newOrder.Information = updatedInformation;
      string result = newOrder.Information;
      Assert.AreEqual(updatedInformation, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrdersList()
    {
      string title1 = "Pierres Bagels";
      string information1 = "12 sesame bagels";
      string date1 = "May 12, 2023";
      int price1 = 25;
      string title2 = "Pierres Bagels";
      string information2 = "24 poppy seed bagels";
      string date2 = "May 13, 2023";
      int price2 = 50;
      Order newOrder1 = new Order(title1, information1, date1, price1);
      Order newOrder2 = new Order(title2, information2, date2, price2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string title = "Pierres Bagels";
      string information = "12 sesame bagels";
      string date = "May 12, 2023";
      int price = 25;
      Order newOrder = new Order(title, information, date, price);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    // [TestMethod]
    // public void Find_ReturnsCorrectItem_Item()
    // {
    //   //Arrange
    //   string description01 = "Walk the dog";
    //   string description02 = "Wash the dishes";
    //   Item newItem1 = new Item(description01);
    //   Item newItem2 = new Item(description02);

    //   //Act
    //   Item result = Item.Find(2);

    //   //Assert
    //   Assert.AreEqual(newItem2, result);
    // }
  }
}