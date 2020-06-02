using System;
using System.Collections.Generic;
using System.Text;

namespace SiteOfBlackDesert.Data.Models
{
    public class Items
    {
        public int id { set; get; }
        public string name { set; get; }
        public string descriptions { set; get; }
        public string img { set; get; }
        public string damage { set; get; }
        public string protection { set; get; }
        public string accuracy { set; get; }
        public string evasion { set; get; }
        public string damage_reduction { set; get; }
        public bool is_favourite { set; get; }
        public int  CategoryItemsID { set; get; }
        public virtual CategoryItems CategoryItems { set; get; }
    }
}
