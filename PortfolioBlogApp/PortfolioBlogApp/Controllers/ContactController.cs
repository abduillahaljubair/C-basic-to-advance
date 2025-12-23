using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using PortfolioBlogApp.Models;

using System.Web.Mvc;
using PortfolioBlogApp.Models;
using System.Collections.Generic;

namespace PortfolioBlogApp.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(ContactMessage message)
        {
            if (string.IsNullOrWhiteSpace(message.Name) ||
                string.IsNullOrWhiteSpace(message.Email) ||
                string.IsNullOrWhiteSpace(message.Message))
            {
                TempData["Error"] = "All fields are required!";
                return RedirectToAction("Index");
            }

            List<ContactMessage> messages = Session["ContactMessages"] as List<ContactMessage> ?? new List<ContactMessage>();
            messages.Add(message);
            Session["ContactMessages"] = messages;

            TempData["Success"] = "Your message has been submitted!";
            return RedirectToAction("Index");
        }
    }
}
