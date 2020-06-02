using System;
using System.Collections.Generic;
using System.Text;

namespace SiteOfBlackDesert.Data.Models
{
    public class AlchemyAndCooking
    {
        public int id { set; get; }
        public string name { set; get; }
        public string descriptions { set; get; }
        public string img { set; get; }
        public int CategoryAlchemyAndCookingID { set; get; }
        public virtual CategoryAlchemyAndCooking CategoryAlchemyAndCooking { set; get; }
    }
}
