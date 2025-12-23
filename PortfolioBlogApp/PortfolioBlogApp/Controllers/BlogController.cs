using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PortfolioBlogApp.Models;

using System.Web.Mvc;
using PortfolioBlogApp.Models;
using System.Linq;
using System.Collections.Generic;

namespace PortfolioBlogApp.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Index()
        {
            var blogs = DataStore.BlogPosts;
            return View(blogs);
        }

        public ActionResult Details(int id)
        {
            var blog = DataStore.BlogPosts.FirstOrDefault(b => b.Id == id);
            if (blog == null)
                return HttpNotFound();

            // Load comments from Session
            var sessionKey = $"BlogComments_{id}";
            if (Session[sessionKey] != null)
            {
                blog.Comments = (List<string>)Session[sessionKey];
            }

            return View(blog);
        }

        [HttpPost]
        public ActionResult AddComment(int id, string comment)
        {
            if (string.IsNullOrWhiteSpace(comment))
            {
                TempData["Error"] = "Comment cannot be empty!";
                return RedirectToAction("Details", new { id = id });
            }

            var sessionKey = $"BlogComments_{id}";
            List<string> comments = Session[sessionKey] as List<string> ?? new List<string>();
            comments.Add(comment);
            Session[sessionKey] = comments;

            return RedirectToAction("Details", new { id = id });
        }
    }
}
