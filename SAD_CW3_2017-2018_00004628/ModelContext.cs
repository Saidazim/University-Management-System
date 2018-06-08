using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD_CW3_2017_2018_00004628
{
    public class ModelContext: DbContext
    {
        public DbSet<Staff> StaffList { get; set; }
        public DbSet<Modules> ModulesList { get; set; }
        public DbSet<Events> EventsList { get; set; }
        public DbSet<News> NewsList { get; set; }
    }
}
