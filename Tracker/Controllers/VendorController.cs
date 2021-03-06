using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Tracker.Models;

namespace Tracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
    return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
    Vendor newVendor = new Vendor(vendorName, vendorDescription);
    return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
    Dictionary<string, object> model = new Dictionary<string, object>();
    Vendor selectedVendor = Vendor.Find(id);
    List<Order> vendorOrders = selectedVendor.Orders;
    model.Add("vendor", selectedVendor);
    model.Add("order", vendorOrders);
    return View(model);
    }
  }
}