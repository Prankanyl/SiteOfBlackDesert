using SiteOfBlackDesert.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteOfBlackDesert.Data.Interfaces
{
    public interface IAlchemyAndCooking
    {
        static IEnumerable<AlchemyAndCooking> GetSetAllAlchemyAndCooking { get; }
        AlchemyAndCooking getObjectAlchemyAndCooking(int itemId);
    }
}
