using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Events
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Date { get; set; }
        [StringLength(50)]
        public string Image { get; set; }
        [StringLength(100)]
        public string Item { get; set; }
        [StringLength(50)]
        public string Time { get; set; }
        [StringLength(50)]
        public string Location { get; set; }
        [StringLength(50)]
        public string RedirectUrl { get; set; }
    }
}
