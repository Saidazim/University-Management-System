using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD_CW3_2017_2018_00004628
{
    public class Staff
    {
        [Key]
        public int StaffID { get; set; }
        [StringLength(255)]
        public string FullName { get; set; }
        [StringLength(255)]
        public string Type { get; set; }
        [StringLength(255)]
        public string Age { get; set; }
        [StringLength(255)]
        public string BirthDate { get; set; }
        [StringLength(255)]
        public string Modules { get; set; }
        [StringLength(255)]
        public string ImageUrl { get; set; }
        [StringLength(255)]
        public string EdBackground { get; set; }
        public bool Gender { get; set; }
    }
}
