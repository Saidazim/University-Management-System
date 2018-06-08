using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD_CW3_2017_2018_00004628
{
    public class Events
    {
        [Key]
        public int EventID { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string ParticipantsType { get; set; }
        [StringLength(255)]
        public string Venue { get; set; }
        [StringLength(255)]
        public string Time { get; set; }
        [StringLength(255)]
        public string Type { get; set; }
        public bool Status { get; set; }
    }
}
