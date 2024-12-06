namespace ToyShop.Data.Models.Enumerations
{
    public class OrderStatusTranslator
    {
        public static string Translate(OrderStatus orderStatus)
        {
            switch (orderStatus)
            {
                case OrderStatus.Processing: return "Обработва се..";
                case OrderStatus.AwaitingDelivery: return "Очаква доставка";
                case OrderStatus.Delivered: return "Доставена";
                default: return "Анулирана";
            }
        }
    }
}
