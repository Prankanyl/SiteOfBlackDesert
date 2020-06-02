using SiteOfBlackDesert.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteOfBlackDesert.Data.Interfaces
{
    interface IAllItems
    {
        IEnumerable<Items> GetSetAllItems { get; }
        IEnumerable<Items> GetSetFavItems { get; set; }
        Items getObjectItem(int itemId);
        public CategoryItems GetIndexCategiryItems(int index);
    }
}
