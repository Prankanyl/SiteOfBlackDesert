using SiteOfBlackDesert.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace SiteOfBlackDesert.Data.Interfaces
{
    public interface ICategoryAlchemyAndCooking
    {
        IEnumerable<CategoryAlchemyAndCooking> AllCategoriesAlchemyAndCooking { get; }
    }
}
