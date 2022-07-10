using Microsoft.AspNetCore.Mvc;

namespace Customer.Models
{
    public class ItemCart
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
    }
}
