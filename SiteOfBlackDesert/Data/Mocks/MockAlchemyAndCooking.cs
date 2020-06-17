using SiteOfBlackDesert.Data.Interfaces;
using SiteOfBlackDesert.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiteOfBlackDesert.Data.Mocks
{
    public class MockAlchemyAndCooking : IAlchemyAndCooking
    {
        public static IEnumerable<AlchemyAndCooking> GetSetAllAlchemyAndCooking
        {
            get
            {
                return new List<AlchemyAndCooking>
                {
                    new AlchemyAndCooking
                    {
                        name = "Алоэ",
                        category = "Кулинария",
                        descriptions="Продукт культивации",
                        img="/img/00007347.png",
                    },
                    new AlchemyAndCooking
                    {
                        name = "Медовуха",
                        category = "Кулинария",
                        descriptions="Алкогольный напиток",
                        img="/img/00009206.png",
                    },
                    new AlchemyAndCooking
                    {
                        name = "Бадьян",
                        category = "Кулинария",
                        descriptions="Продукт культивации",
                        img="/img/00005402.png",
                    },
                    new AlchemyAndCooking
                    {
                        name = "Азалия",
                        category = "Алхимия",
                        descriptions="Природный материал",
                        img="/img/00007019.png",
                    },
                    new AlchemyAndCooking
                    {
                        name = "Алмаз",
                        category = "Алхимия",
                        descriptions="Обработаный материал для изготовления предметов",
                        img="/img/00004463.png",
                    },
                    new AlchemyAndCooking
                    {
                        name = "Алхимический порошок",
                        category = "Алхимия",
                        descriptions="Порошок от которго исходит загадочная энергия",
                        img="/img/00004924.png",
                    },
                };
            }
        }
        public AlchemyAndCooking getObjectAlchemyAndCooking(int itemId)
        {
            throw new NotImplementedException();
        }
    }
}
