using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWeb.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string titulo { get; set; }
        public string resumo { get; set; }
        public string categoria { get; set; }
    }
}