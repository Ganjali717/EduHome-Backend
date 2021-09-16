using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Image { get; set; }
        public string Date { get; set; }
        public string CommentCount { get; set; }
        public string ByKim { get; set; }
        public string Title { get; set; }
        public string RedirectUrl { get; set; }
    }
}
