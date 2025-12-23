using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace PortfolioBlogApp.Models
{
    public static class DataStore
    {
        // Projects
        public static List<Project> Projects = new List<Project>
        {
            new Project { Id=1, Title="Project 1", Description="Description for Project 1", ImageUrl="/Images/project1.jpg" },
            new Project { Id=2, Title="Project 2", Description="Description for Project 2", ImageUrl="/Images/project2.jpg" },
            new Project { Id=3, Title="Project 3", Description="Description for Project 3", ImageUrl="/Images/project3.jpg" }
        };

        // Blog Posts
        public static List<BlogPost> BlogPosts = new List<BlogPost>
        {
            new BlogPost { Id=1, Title="Blog Post 1", Content="Full content of Blog Post 1", PostedOn=System.DateTime.Now.AddDays(-2)},
            new BlogPost { Id=2, Title="Blog Post 2", Content="Full content of Blog Post 2", PostedOn=System.DateTime.Now.AddDays(-1)}
        };

        // Contact Messages
        public static List<ContactMessage> ContactMessages = new List<ContactMessage>();
    }
}
