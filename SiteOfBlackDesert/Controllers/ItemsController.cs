using Microsoft.AspNetCore.Mvc;
using SiteOfBlackDesert.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteOfBlackDesert.Controllers
{
    public class ItemsController : Controller
    {
        private readonly IAllItems _allItems;
        private readonly ICategoryItems _allCategories;
        public ItemsController(IAllItems iallItems, ICategoryItems iItemsCategories)
        {
            _allItems = iallItems;
            _allCategories = iItemsCategories;
        }
        public ViewResult ListItems()
        {
            var items = _allItems.GetSetAllItems;
            //var items = "hello";
            //ViewBag.Items = items;
            return View(items);
        }
    }
}
