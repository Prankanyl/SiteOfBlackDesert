using SiteOfBlackDesert.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteOfBlackDesert.Data.Interfaces
{
    public interface IAlchemyAndCooking
    {
        IEnumerable<AlchemyAndCooking> GetSetAllAlchemyAndCooking { get; }
        AlchemyAndCooking getObjectAlchemyAndCooking(int itemId);
        public CategoryAlchemyAndCooking GetIndexCategiryAlchemyAndCooking(int index);
    }
}
