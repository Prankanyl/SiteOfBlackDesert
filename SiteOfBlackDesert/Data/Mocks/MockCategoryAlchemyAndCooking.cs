using System;
using System.Collections.Generic;
using System.Text;
using SiteOfBlackDesert.Data.Interfaces;
using SiteOfBlackDesert.Data.Models;

namespace SiteOfBlackDesert.Data.Mocks
{
    public class MockCategoryAlchemyAndCooking : ICategoryAlchemyAndCooking
    {
        public IEnumerable<CategoryAlchemyAndCooking> AllCategoriesAlchemyAndCooking
        {
            get
            {
                return new List<CategoryAlchemyAndCooking>
                {
                    new CategoryAlchemyAndCooking {name="Кулинария", descriptions="Варить!)"},
                    new CategoryAlchemyAndCooking {name="Алхимия", descriptions="Мешать!)"},
                };
            }
        }
    }
}
