using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Notice
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Date { get; set; }
        [StringLength(150)]
        public string Desc { get; set; }

    }
}
