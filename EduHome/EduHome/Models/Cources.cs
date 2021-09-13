using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Cources
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Image { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(200)]
        public string Desc { get; set; }
        [StringLength(100)]
        public string RedirectURL { get; set; }
    }
}
