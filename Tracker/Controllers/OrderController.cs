using Microsoft.AspNetCore.Mvc;
using Tracker.Models;
using System.Collections.Generic;

namespace Tracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
    Vendor vendor = Vendor.Find(vendorId);
     return View(vendor);
    }

    [HttpGet("/vandors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
    Odrer order = Order.Find(orderId);
    Vendor vendor = Vendor.Find(vendorId);
    Dictionary<string, object> model = new Dictionary<string, object>();
    model.Add("order", order);
    model.Add("vendor", vendor);
    return View(model);
    }

  }
}