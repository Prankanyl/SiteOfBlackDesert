using System;
using System.Collections.Generic;
using System.Text;

namespace SiteOfBlackDesert.Data.Models
{
    class Items
    {
        public int id { set; get; }
        public string category { set; get; }
        public string name { set; get; }
        public string descriptions { set; get; }
        public string img { set; get; }
        public int  CategoryItemsID { set; get; }
        public virtual CategoryItems CategoryItems { set; get; }
    }
}
