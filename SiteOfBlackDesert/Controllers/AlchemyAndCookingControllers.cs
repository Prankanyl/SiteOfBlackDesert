using Microsoft.AspNetCore.Mvc;
using SiteOfBlackDesert.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteOfBlackDesert.Controllers
{
    public class AlchemyAndCookingControllers : Controller
    {
        private readonly IAlchemyAndCooking _allAlchemyAndCooking;
        private readonly ICategoryAlchemyAndCooking _allCategoriesAlchemyAndCooking;

        public AlchemyAndCookingControllers(IAlchemyAndCooking iallAlchemyAndCooking, ICategoryAlchemyAndCooking iallCategoriesAlchemyAndCooking)
        {
            _allAlchemyAndCooking = iallAlchemyAndCooking;
            _allCategoriesAlchemyAndCooking = iallCategoriesAlchemyAndCooking;
        }
    }
}
