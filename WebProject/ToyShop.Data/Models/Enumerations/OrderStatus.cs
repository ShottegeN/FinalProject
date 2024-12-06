using System.ComponentModel;

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
