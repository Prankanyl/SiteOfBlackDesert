using System;
using System.Collections.Generic;
using System.Text;
using SiteOfBlackDesert.Data.Interfaces;
using SiteOfBlackDesert.Data.Models;

namespace SiteOfBlackDesert.Data.Mocks
{
    class MockCategoty : ICategoryItems 
    {
        public IEnumerable<CategoryItems> AllCategories
        {
            get 
            {
                return new List<CategoryItems> 
                {
                    new CategoryItems { categoryitemsname="Основное оружие", descriptions="Меч, лук, талисман"},
                    new CategoryItems { categoryitemsname="Доп. оружие", descriptions="Щит, кинжал"},
                    new CategoryItems { categoryitemsname="Доспехи", descriptions="Шлем, доспех"},
                };
            }
        }
    }
}
