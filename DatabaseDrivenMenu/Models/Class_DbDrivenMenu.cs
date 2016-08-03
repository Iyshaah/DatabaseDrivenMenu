using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DatabaseDrivenMenu.Models
{
    public class Class_DbDrivenMenu
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Parent_ID { get; set; }
    }

    public class Class_DbDrivenMenuDBContext : DbContext
    {
        public DbSet<Class_DbDrivenMenu> Class_DbDrivenMenus { get; set; }
    }

}