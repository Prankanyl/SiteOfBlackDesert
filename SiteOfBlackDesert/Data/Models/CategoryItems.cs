﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SiteOfBlackDesert.Data.Models
{
    public class CategoryItems
    {
        public int id { set; get; }
        public string categoryitemsname { set; get; }
        public string descriptions { set; get; }
        public List<Items> items { set; get; }
    }
}
