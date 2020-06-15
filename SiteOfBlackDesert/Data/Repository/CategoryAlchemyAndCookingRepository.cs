using SiteOfBlackDesert.Data.Interfaces;
using SiteOfBlackDesert.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteOfBlackDesert.Data.Repository
{
    class CategoryAlchemyAndCookingRepository : ICategoryAlchemyAndCooking
    {
        private readonly AppDBContent appDBContent;
        public CategoryAlchemyAndCookingRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<CategoryAlchemyAndCooking> AllCategoriesAlchemyAndCooking => appDBContent.CategoryAlchemyAndCooking;
    }
}
