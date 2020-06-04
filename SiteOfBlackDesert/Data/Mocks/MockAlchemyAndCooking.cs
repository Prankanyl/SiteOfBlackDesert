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
        private readonly ICategoryAlchemyAndCooking _CategoryAlchemyAndCooking = new MockCategoryAlchemyAndCooking();
        public CategoryAlchemyAndCooking GetIndexCategiryAlchemyAndCooking(int index)
        {
            int count = 0;

            foreach (CategoryAlchemyAndCooking item in _CategoryAlchemyAndCooking.AllCategoriesAlchemyAndCooking)
            {
                if (index == count)
                {
                    return (item);
                }
                count += 1;
            }
            CategoryAlchemyAndCooking LastElement = _CategoryAlchemyAndCooking.AllCategoriesAlchemyAndCooking.Last();
            return (LastElement);
        }
        public IEnumerable<AlchemyAndCooking> GetSetAllAlchemyAndCooking
        {
            get
            {
                return new List<AlchemyAndCooking>
                {
                    new AlchemyAndCooking
                    {
                        name = "Алоэ",
                        descriptions="Продукт культивации",
                        img="",
                        CategoryAlchemyAndCooking = _CategoryAlchemyAndCooking.AllCategoriesAlchemyAndCooking.First()
                    },
                    new AlchemyAndCooking
                    {
                        name = "Медовуха",
                        descriptions="Алкогольный напиток",
                        img="",
                        CategoryAlchemyAndCooking = _CategoryAlchemyAndCooking.AllCategoriesAlchemyAndCooking.First()
                    },
                    new AlchemyAndCooking
                    {
                        name = "Бадьян",
                        descriptions="Продукт культивации",
                        img="",
                        CategoryAlchemyAndCooking = _CategoryAlchemyAndCooking.AllCategoriesAlchemyAndCooking.First()
                    },
                    new AlchemyAndCooking
                    {
                        name = "Азалия",
                        descriptions="Природный материал",
                        img="",
                        CategoryAlchemyAndCooking = _CategoryAlchemyAndCooking.AllCategoriesAlchemyAndCooking.Last()
                    },
                    new AlchemyAndCooking
                    {
                        name = "Алмаз",
                        descriptions="Обработаный материал для изготовления предметов",
                        img="",
                        CategoryAlchemyAndCooking = _CategoryAlchemyAndCooking.AllCategoriesAlchemyAndCooking.Last()
                    },
                    new AlchemyAndCooking
                    {
                        name = "Алхимический порошок",
                        descriptions="Порошок от которго исходит загадочная энергия",
                        img="",
                        CategoryAlchemyAndCooking = _CategoryAlchemyAndCooking.AllCategoriesAlchemyAndCooking.Last()
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
