using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    [HttpGet("/stylist")]
    public ActionResult Index()
    {
      List<Stylist> allStylists = Stylist.GetAll();
      return View(allStylists);
    }

    [HttpGet("/stylist/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/stylist")]
    public ActionResult Create(string stylistName)
    {
      Stylist newStylist = new Stylist(stylistName);
      newStylist.Save();
      List<Stylist> allStylists = Stylist.GetAll();
      return RedirectToAction("Index", allStylists);
    }

    [HttpGet("/stylist/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Stylist selectedStylist = Stylist.Find(id);
      List<Client> stylistClients = selectedStylist.GetClients();
      model.Add("stylist", selectedStylist);
      model.Add("client", stylistClients);
      return View(model);
    }

    [HttpPost("/stylist/{stylistId}/client")]
    public ActionResult Create(string clientName, int stylistId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Stylist foundStylist = Stylist.Find(stylistId);
      Client newClient = new Client(clientName, stylistId);
      newClient.Save();
      List<Client> stylistClients = foundStylist.GetClients();
      model.Add("client", stylistClients);
      model.Add("stylist", foundStylist);
      return View("Show", model);
    }


  }
}
