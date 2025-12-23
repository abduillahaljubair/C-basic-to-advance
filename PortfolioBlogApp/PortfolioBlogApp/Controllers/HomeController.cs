using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PortfolioBlogApp.Models;

using System.Web.Mvc;
using PortfolioBlogApp.Models;

namespace PortfolioBlogApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var projects = DataStore.Projects;
            return View(projects);
        }
    }
}
