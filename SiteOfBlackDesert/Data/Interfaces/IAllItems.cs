using SiteOfBlackDesert.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteOfBlackDesert.Data.Interfaces
{
    public interface IAllItems
    {
        public static IEnumerable<Items> GetSetAllItems { get; }
        public IEnumerable<Items> GetSetFavItems { get; }
        public Items getObjectItem(int itemId);
    }
}
