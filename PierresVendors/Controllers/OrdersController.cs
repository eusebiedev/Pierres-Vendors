using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using PierresVendors.Models;

namespace PierresVendors.Controllers
{
  public class OrdersController : Controller
  {

    // [HttpGet("/items/new")]
    // public ActionResult New()
    // {
    //   return View();
    // }

    // [HttpGet("/categories/{categoryId}/items/{itemId}")]
    // public ActionResult Show(int categoryId, int itemId)
    // {
    //   Item item = Item.Find(itemId);
    //   Category category = Category.Find(categoryId);
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   model.Add("item", item);
    //   model.Add("category", category);
    //   return View(model);
    // }

    // [HttpGet("/categories/{categoryId}/items/new")]
    // public ActionResult New(int categoryId)
    // {
    //   Category category = Category.Find(categoryId);
    //   return View(category);
    // }


  }
}