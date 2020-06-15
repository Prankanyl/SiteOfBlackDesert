using SiteOfBlackDesert.Data.Interfaces;
using SiteOfBlackDesert.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SiteOfBlackDesert.Data.Repository
{
    class ItemsRepository : IAllItems
    {
        private readonly AppDBContent appDBContent;
        public ItemsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Items> GetSetAllItems => appDBContent.Items.Include(c => c.CategoryItems);

        public IEnumerable<Items> GetSetFavItems => appDBContent.Items.Where(p => p.is_favourite).Include(c => c.CategoryItems);

        public Items getObjectItem(int itemId) => appDBContent.Items.FirstOrDefault(p => p.id == itemId);
    }
}
