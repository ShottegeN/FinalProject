﻿namespace ToyShop.Data.Models
{
    public class ShoppingCartProduct
    {
        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; } = null!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
