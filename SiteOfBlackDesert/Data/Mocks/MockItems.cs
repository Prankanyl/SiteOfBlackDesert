using SiteOfBlackDesert.Data.Interfaces;
using SiteOfBlackDesert.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiteOfBlackDesert.Data.Mocks
{
    public class MockItems: IAllItems
    {
        public static IEnumerable<Items> GetSetAllItems 
        {
            get 
            {
                return new List<Items>
                {
                    new Items
                    {
                        name = "Ржавый меч",
                        descriptions="Затупившийся меч, покрытый ржавчиной",
                        img="/img/00010001.png",
                        damage="6~10",
                        protection="0",
                        accuracy="10",
                        evasion="0",
                        damage_reduction="0",
                        is_favourite=false,
                    },
                    new Items
                    {
                        name = "Меч ополченца",
                        descriptions="Меч массового производства для ополченцев",
                        img="/img/00010002.png",
                        damage="8~12",
                        protection="0",
                        accuracy="10",
                        evasion="0",
                        damage_reduction="0",
                        is_favourite = true,
                    },
                    new Items
                    {
                        name = "Лук Кзарки",
                        descriptions="Лук, в котором таится дьявольская сила Кзарки. Сила злого духа наполняет своим могуществом этот лук",
                        img="/img/00010210.png",
                        damage="18~22",
                        protection="0",
                        accuracy="10",
                        evasion="0",
                        damage_reduction="0",
                        is_favourite=true,
                    },
                    new Items
                    {
                        name = "Щит предела Пэнгочи",
                        descriptions="Щит Пэнгочи, позволяющий повысить навыки до максимума",
                        img="/img/00010105.png",
                        damage="1~3",
                        protection="4",
                        accuracy="28",
                        evasion="4",
                        damage_reduction="2",
                        is_favourite=false,
                    },
                    new Items
                    {
                        name = "Стальной кинжал искр",
                        descriptions="Кинжал, таящий энергию огня",
                        img="/img/00010303.png",
                        damage="0~0",
                        protection="0",
                        accuracy="0",
                        evasion="0",
                        damage_reduction="0",
                        is_favourite=false,
                    },
                    new Items 
                    {
                        name = "Доспехи Кайдикт", 
                        descriptions="Душа Кайдикта, великого воина прошлого, заключена в этом предмете, и дарует ему огромную мощь", 
                        img="/img/00011522.png", 
                        damage="0", 
                        protection="84", 
                        accuracy="0", 
                        evasion="152", 
                        damage_reduction="46", 
                        is_favourite=true,
                    },
                    new Items 
                    {
                        name = "Шлем Арши", 
                        descriptions="Шлем Арши предназначенный для Арены", 
                        img="/img/00010821.png", 
                        damage="0", 
                        protection="73", 
                        accuracy="0", 
                        evasion="144", 
                        damage_reduction="48", 
                        is_favourite=true,
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
