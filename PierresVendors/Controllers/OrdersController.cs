using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using PierresVendors.Models;

namespace PierresVendors.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }


  }
}