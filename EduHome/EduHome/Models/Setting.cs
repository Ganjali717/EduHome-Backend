using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Logo { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(100)]
        public string AboutTask { get; set; }
        [StringLength(100)]
        public string FbIcon { get; set; }
        [StringLength(100)]
        public string PinterestIcon { get; set; }
        [StringLength(100)]
        public string VimIcon { get; set; }
        [StringLength(100)]
        public string TwitterIcon { get; set; }
    }
}
