using SiteOfBlackDesert.Data.Interfaces;
using SiteOfBlackDesert.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteOfBlackDesert.Data.Repository
{
    class CategoryItemsRepository : ICategoryItems
    {
        private readonly AppDBContent appDBContent;
        public CategoryItemsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<CategoryItems> AllCategories => appDBContent.CategoryItems;
    }
}
