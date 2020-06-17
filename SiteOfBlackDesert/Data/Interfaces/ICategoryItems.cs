using SiteOfBlackDesert.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteOfBlackDesert.Data.Interfaces
{
    public interface ICategoryItems
    {
        public static IEnumerable<CategoryItems> AllCategories { get;  }
    }
}
