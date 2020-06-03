using SiteOfBlackDesert.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteOfBlackDesert.Data.Interfaces
{
    public interface IAllItems
    {
        public IEnumerable<Items> GetSetAllItems { get; }
        public IEnumerable<Items> GetSetFavItems { get; set; }
        public Items getObjectItem(int itemId);
        public CategoryItems GetIndexCategiryItems(int index);
    }
}
