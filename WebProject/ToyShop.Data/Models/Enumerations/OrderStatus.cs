using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop.Data.Models.Enumerations
{
    public enum OrderStatus
    {
        [Description("Обработва се")]
        Processing = 0,

        [Description("Очаква доставка")]
        AwaitingDelivery = 1,

        [Description("Доставена")]
        Delivered = 2,

        [Description("Анулирана")]
        Cancelled = 3
    }
}
