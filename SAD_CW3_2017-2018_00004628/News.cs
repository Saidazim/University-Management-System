using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD_CW3_2017_2018_00004628
{
    public class News
    {
        [Key]
        public int NewsID { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(255)]
        public string Body { get; set; }
        [StringLength(255)]
        public string Timestamp { get; set; }
        [StringLength(255)]
        public string ImageUrl { get; set; }
    }
}
