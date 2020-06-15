using SiteOfBlackDesert.Data.Interfaces;
using SiteOfBlackDesert.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SiteOfBlackDesert.Data.Repository
{
    class AlchemyAndCookingRepository : IAlchemyAndCooking
    {
        private readonly AppDBContent appDBContent;
        public AlchemyAndCookingRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<AlchemyAndCooking> GetSetAllAlchemyAndCooking => appDBContent.AlchemyAndCooking.Include(c => c.CategoryAlchemyAndCooking);

        public AlchemyAndCooking getObjectAlchemyAndCooking(int itemId) => appDBContent.AlchemyAndCooking.FirstOrDefault(p => p.id == itemId);
    }
}
