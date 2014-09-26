using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinics2.Models
{
    public enum PriceType { Paradontology = 1, Terapy = 2, Ortopia = 3 };

    public class Service
    {
        

        public string Name { get; set; }
        public string Units { get; set; }
        public string Price { get; set; }
        public PriceType PriceType { get; set; }

        public static readonly IEnumerable<Service> Services = new List<Service>
        {
            new Service { Name = "Консультация", Units = "Назначения, направления", Price = "40 грн", PriceType = PriceType.Paradontology  },
            new Service { Name = "Профессиональная гигиена полости рта", Units = "Снятие мягкого и твёрдого налёта щёткой и ультразвуком за один зуб.", Price = "14 грн", PriceType = PriceType.Paradontology  },
            new Service { Name = "Антисептическая обработка полости рта", Units = "", Price = "30 грн", PriceType = PriceType.Paradontology  },
            new Service { Name = "Инъекция лекарственных препаратов", Units = "Восстановление кости одна инъекция.", Price = "110 грн", PriceType = PriceType.Paradontology  },
            new Service { Name = "Аппликация лекарственных мазей", Units = "", Price = "40 грн", PriceType = PriceType.Paradontology  },
            new Service { Name = "Лазерная терапия генерализованных форм заболеваний дёсен.", Units = "Лечение всей челюсти + лекарства", Price = "100 грн", PriceType = PriceType.Paradontology  },
            new Service { Name = "Лазерная терапия локализованных форм заболеваний десен.", Units = "Лечение участка десны +лекарства", Price = "50 грн", PriceType = PriceType.Paradontology  },
            new Service { Name = "Бак посев содержимого  дёсен.", Units = "Состав микрофлоры + чувствительность к препаратом.", Price = "250 грн.", PriceType = PriceType.Paradontology  },
            new Service { Name = "Закрытый кюретаж пародонтального кармана одного зуба", Units = "", Price = "50 грн.", PriceType = PriceType.Paradontology  },
            new Service { Name = "Закрытый кюретаж окружной круговой связки ", Units = "В области одного зуба", Price = "110 грн", PriceType = PriceType.Paradontology  },
            new Service { Name = "Глубокий скайлинг пародонтального кармана", Units = "Инструментальный, ультразвуковой", Price = "110 грн", PriceType = PriceType.Paradontology  },
            new Service { Name = "Пародонтологическая повязка (БФ – 6)", Units = "", Price = "30 грн", PriceType = PriceType.Paradontology  },
            new Service { Name = "Пародонтологическая повязка с водным дентином", Units = "", Price = "75 грн", PriceType = PriceType.Paradontology  },
            new Service { Name = "Фотодинамическая терапия ", Units = "", Price = "110 грн", PriceType = PriceType.Paradontology  },
            new Service { Name = "Гидромассаж десен", Units = "(Включая лекарственные вещества)", Price = "120 грн", PriceType = PriceType.Paradontology  },
        
            new Service { Name = "Анестезия проводниковая", Units = "", Price = "50 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Аппликационная анестезия", Units = "", Price = "30 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Изолирующая прокладка", Units = "", Price = "30 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Пломба Latelux", Units = "", Price = "80 - 120 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "\"Эстелайт\". \"Дайрект- X\"", Units = "", Price = "130 – 200 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Пломба  Gradia direct", Units = "", Price = "200  грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Пломба Amelogen", Units = "", Price = "200  грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Пломбирование стеклоиономерным цементом", Units = "", Price = "120 – 230 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Лечебная прокладка Кальцевит", Units = "", Price = "20 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Прокладка Ионосит", Units = "", Price = "30 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Изолирующая прокладка", Units = "", Price = "30 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Эстетическая реставрация", Units = "", Price = "300 - 600 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Реставрационный мост", Units = "", Price = "1000 - 1500 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Покрытие фтором (Фусс мусс)", Units = "За одну челюсть", Price = "50 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Рэм терапия", Units = "За один зуб", Price = "20 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Серебрение", Units = "За один зуб", Price = "50 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Обработка корневого кала ультразвуком", Units = "За один канал", Price = "20 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Машинная обработка корневого канала", Units = "За один канал", Price = "80 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Раcпломбирование К/K", Units = "За один канал", Price = "20 – 100 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Наложение «девит»  «паро» пасты", Units = "", Price = "50 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Обработка канала после «девит»  «паропасты»", Units = "", Price = "50 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Пломбирование канала.", Units = "Само резорбирующиеся цементы", Price = "100 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Пломбирование одного корневого канала \"Феоредент\"", Units = "", Price = "60 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Пломбирование одного корневого канала \"Эндометазон\"", Units = "", Price = "90 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Пломбирование одного корневого канала \"H plus\"", Units = "", Price = "100 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Временная повязка", Units = "Водный дентин", Price = "30 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Штифт ( Титан)", Units = "Биоинертный металл", Price = "70 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Штифт (Стекловолокно)", Units = "Прозрачный материал", Price = "120 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Постановка кальция в корневой канал", Units = "", Price = "70 грн", PriceType = PriceType.Terapy  },
            new Service { Name = "Постановка пасты «Камфокам»", Units = "", Price = "60 грн", PriceType = PriceType.Terapy  },
        
            new Service { Name = "Металлокерамическая коронка", Units = "За единицу", Price = "500 – 700 грн", PriceType = PriceType.Ortopia  },
            new Service { Name = "Металлопластмассовая коронка", Units = "За единицу", Price = "300 грн", PriceType = PriceType.Ortopia  },
            new Service { Name = "Цельнолитая металлическая коронка", Units = "За единицу", Price = "240 грн", PriceType = PriceType.Ortopia  },
            new Service { Name = "Штампованная металлическая коронка", Units = "За единицу", Price = "200 грн", PriceType = PriceType.Ortopia  },
            new Service { Name = "Съёмный пластиночный протез", Units = "Одна челюсть", Price = "550 грн", PriceType = PriceType.Ortopia  },
            new Service { Name = "Сьемный пратез «Deeflex» (Нейлон)", Units = "Одна челюсть", Price = "От 1800 грн", PriceType = PriceType.Ortopia  },
            new Service { Name = "Бюгельный протез на кламерах", Units = "Одна челюсть", Price = "2800 - 3500", PriceType = PriceType.Ortopia  },
            new Service { Name = "Бюгельный протез на замках", Units = "Одна челюсть", Price = "От 4500 грн", PriceType = PriceType.Ortopia  }
        };

    }


}