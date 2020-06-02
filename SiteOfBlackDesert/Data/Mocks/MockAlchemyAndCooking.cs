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
                        name = "Ржавый меч",
                        descriptions="Затупившийся меч, покрытый ржавчиной",
                        img="",
                        CategoryAlchemyAndCooking = _CategoryAlchemyAndCooking.AllCategoriesAlchemyAndCooking.First()
                    },
                    new AlchemyAndCooking
                    {
                        name = "Меч ополченца",
                        descriptions="Меч массового производства для ополченцев",
                        img="",
                        CategoryAlchemyAndCooking = _CategoryAlchemyAndCooking.AllCategoriesAlchemyAndCooking.First()
                    },
                    new AlchemyAndCooking
                    {
                        name = "Лук Кзарки",
                        descriptions="Лук, в котором таится дьявольская сила Кзарки. Сила злого духа наполняет своим могуществом этот лук",
                        img="",
                        CategoryAlchemyAndCooking = _CategoryAlchemyAndCooking.AllCategoriesAlchemyAndCooking.First()
                    },
                    new AlchemyAndCooking
                    {
                        name = "Щит предела Пэнгочи",
                        descriptions="Щит Пэнгочи, позволяющий повысить навыки до максимума",
                        img="",
                        CategoryAlchemyAndCooking = _CategoryAlchemyAndCooking.AllCategoriesAlchemyAndCooking.Last()
                    },
                    new AlchemyAndCooking
                    {
                        name = "Стальной кинжал искр",
                        descriptions="Кинжал, таящий энергию огня",
                        img="",
                        CategoryAlchemyAndCooking = _CategoryAlchemyAndCooking.AllCategoriesAlchemyAndCooking.Last()
                    },
                    new AlchemyAndCooking
                    {
                        name = "Доспехи Кайдикт",
                        descriptions="Душа Кайдикта, великого воина прошлого, заключена в этом предмете, и дарует ему огромную мощь",
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
