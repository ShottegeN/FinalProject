using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop.ViewModels
{
    public class OrderViewModel
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = null!;

        public decimal Price { get; set; }

        public decimal DeliveryPrice { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? SendingDate { get; set; }

        public string OrderSatus { get; set; } = null!;

        public AddressViewModel DeliveryAddress { get; set; } = null!;

        public Guid UserId { get; set; }

        public IEnumerable<ProductInfoViewModel> Products { get; set; } = new List<ProductInfoViewModel>();

    }
}
