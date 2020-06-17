using Microsoft.AspNetCore.Mvc;
using SiteOfBlackDesert.Data.Interfaces;
using SiteOfBlackDesert.Data.Mocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteOfBlackDesert.Controllers
{
    public class ItemsController : Controller
    {
        private readonly MockItems _allItems;
        private readonly MockCategoty _allCategories;

        public ItemsController(MockItems iallItems, MockCategoty iItemsCategories)
        {
            _allItems = iallItems;
            _allCategories = iItemsCategories;
        }
    }
}
