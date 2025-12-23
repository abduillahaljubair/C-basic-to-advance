using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Collections.Generic;

using System;
using System.Collections.Generic;

namespace PortfolioBlogApp.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PostedOn { get; set; }
        public List<string> Comments { get; set; } = new List<string>(); // Saved in Session
    }
}
