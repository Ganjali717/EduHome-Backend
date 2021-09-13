using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [StringLength(500)]
        public string Image { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(150)]
        public string Desc { get; set; }
        [StringLength(50)]
        public string RedirectUrl { get; set; }
    }
}
