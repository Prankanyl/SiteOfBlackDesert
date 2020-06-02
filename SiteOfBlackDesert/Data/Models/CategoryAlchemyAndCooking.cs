using System;
using System.Collections.Generic;
using System.Text;

namespace SiteOfBlackDesert.Data.Models
{
    public class CategoryAlchemyAndCooking
    {
        public int id { set; get; }
        public string name { set; get; }
        public string descriptions { set; get; }
        public List<AlchemyAndCooking> items { set; get; }
    }
}
