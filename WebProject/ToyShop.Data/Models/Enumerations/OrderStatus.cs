using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop.Data.Models.Enumerations
{
    public enum OrderStatus
    {
        Processing = 0,
        AwaitingDelivery = 1,
        Delivered = 2,
        Cancelled = 3
    }
}
