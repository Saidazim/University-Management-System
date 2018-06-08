using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD_CW3_2017_2018_00004628
{
    public class Modules
    {
        [Key]
        public int ModuleID { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int EnrolledStudents { get; set; }
        [StringLength(255)]
        public string ModuleLeader { get; set; }
    }
}
