namespace ToyShop.Data.Models.Enumerations
{
    public class OrderStatusTranslator
    {
        public static string TranslateToBg(OrderStatus orderStatus)
        {
            switch (orderStatus)
            {
                case OrderStatus.Processing: return "Обработва се..";
                case OrderStatus.Sent: return "Изпратена";
                case OrderStatus.Delivered: return "Доставена";
                default: return "Анулирана";
            }
        }

        public static OrderStatus TranslateToEng(string orderStatus)
        {
            switch (orderStatus)
            {
                case "Обработва се..": return OrderStatus.Processing;
                case "Изпратена": return  OrderStatus.Sent;
                case "Доставена": return  OrderStatus.Delivered;
                default: return OrderStatus.Cancelled;
            }
        }
    }
}
