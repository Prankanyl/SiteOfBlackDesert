using SiteOfBlackDesert.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace SiteOfBlackDesert.Data.Interfaces
{
    public interface ICategoryAlchemyAndCooking
    {
        public IEnumerable<CategoryAlchemyAndCooking> AllCategoriesAlchemyAndCooking { get; }
    }
}
