using SiteOfBlackDesert.Data.Interfaces;
using SiteOfBlackDesert.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiteOfBlackDesert.Data.Mocks
{
    class MockItems: IAllItems
    {
        private readonly ICategoryItems _CategoryItems = new MockCategoty();
        public CategoryItems GetIndexCategiryItems(int index)
        {
            int count = 0;

            foreach (CategoryItems item in _CategoryItems.AllCategories)
            {
                if (index == count)
                {
                    return (item);
                }
                count += 1;
            }
            CategoryItems LastElement = _CategoryItems.AllCategories.Last();
            return (LastElement);
        }
        public IEnumerable<Items> GetSetAllItems 
        {
            get 
            {
                return new List<Items>
                {
                    new Items
                    {
                        name = "Ржавый меч",
                        descriptions="Затупившийся меч, покрытый ржавчиной",
                        img="",
                        damage="6~10",
                        protection="0",
                        accuracy="10",
                        evasion="0",
                        damage_reduction="0",
                        is_favourite=true,
                        CategoryItems = _CategoryItems.AllCategories.First()
                    },
                    new Items
                    {
                        name = "Меч ополченца",
                        descriptions="Меч массового производства для ополченцев",
                        img="",
                        damage="8~12",
                        protection="0",
                        accuracy="10",
                        evasion="0",
                        damage_reduction="0",
                        is_favourite = true,
                        CategoryItems = _CategoryItems.AllCategories.First()
                    },
                    new Items
                    {
                        name = "Лук Кзарки",
                        descriptions="Лук, в котором таится дьявольская сила Кзарки. Сила злого духа наполняет своим могуществом этот лук",
                        img="",
                        damage="18~22",
                        protection="0",
                        accuracy="10",
                        evasion="0",
                        damage_reduction="0",
                        is_favourite=true,
                        CategoryItems = _CategoryItems.AllCategories.First()
                    },
                    new Items
                    {
                        name = "Щит предела Пэнгочи",
                        descriptions="Щит Пэнгочи, позволяющий повысить навыки до максимума",
                        img="",
                        damage="1~3",
                        protection="4",
                        accuracy="28",
                        evasion="4",
                        damage_reduction="2",
                        is_favourite=true,
                        CategoryItems = this.GetIndexCategiryItems(1)
                    },
                    new Items
                    {
                        name = "Стальной кинжал искр",
                        descriptions="Кинжал, таящий энергию огня",
                        img="",
                        damage="0~0",
                        protection="0",
                        accuracy="0",
                        evasion="0",
                        damage_reduction="0",
                        is_favourite=true,
                        CategoryItems = this.GetIndexCategiryItems(1)
                    },
                    new Items 
                    {
                        name = "Доспехи Кайдикт", 
                        descriptions="Душа Кайдикта, великого воина прошлого, заключена в этом предмете, и дарует ему огромную мощь", 
                        img="", 
                        damage="0", 
                        protection="84", 
                        accuracy="0", 
                        evasion="152", 
                        damage_reduction="46", 
                        is_favourite=true,
                        CategoryItems = _CategoryItems.AllCategories.Last()
                    },
                    new Items 
                    {
                        name = "Шлем Арши", 
                        descriptions="Шлем Арши предназначенный для Арены", 
                        img="", 
                        damage="0", 
                        protection="73", 
                        accuracy="0", 
                        evasion="144", 
                        damage_reduction="48", 
                        is_favourite=true,
                        CategoryItems = _CategoryItems.AllCategories.Last()
                    },
                };
            }
        }
        public IEnumerable<Items> GetSetFavItems { get; set; }
        public Items getObjectItem(int itemId)
        {
            throw new NotImplementedException();
        }
    }
}
