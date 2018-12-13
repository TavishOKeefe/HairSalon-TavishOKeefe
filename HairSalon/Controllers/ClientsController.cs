using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
    public class ClientsController : Controller
    {

        [HttpGet("/stylist/{stylistId}/client/new")]
        public ActionResult New(int stylistId)
        {
          Stylist stylist = Stylist.Find(stylistId);
            return View(stylist);
        }

        [HttpPost("/client/delete")]
        public ActionResult DeleteAll()
        {
            Client.ClearAll();
            return View();
        }

        [HttpGet("/stylist/{stylistId}/client/{clientId}")]
        public ActionResult Show(int stylistId, int clientId)
        {
            Client client = Client.Find(clientId);
            Dictionary<string, object> model = new Dictionary<string, object>();
            Stylist stylist = Stylist.Find(stylistId);
            model.Add("client", client);
            model.Add("stylist", stylist);
            return View("Show", model);
      }

      [HttpGet("/stylist/{stylistId}/client/{clientId}/edit")]
      public ActionResult Edit(int stylistId, int clientId)
      {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Stylist stylist = Stylist.Find(stylistId);
        model.Add("stylist", stylist);
        Client client = Client.Find(clientId);
        model.Add("client", client);
        return View(model);
      }

      [HttpPost("/stylist/{stylistId}/client/{clientId}")]
      public ActionResult Update(int stylistId, int clientId, string newName)
      {
        Client client = Client.Find(clientId);
        client.Edit(newName);
        Dictionary<string, object> model = new Dictionary<string, object>();
        Stylist stylist = Stylist.Find(stylistId);
        model.Add("stylist", stylist);
        model.Add("client", client);
        return View("Show", model);
      }
    }
}
