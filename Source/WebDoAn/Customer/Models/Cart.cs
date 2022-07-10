using Customer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Foot.Models
{
    public class Cart 
    {
        private List<ItemCart> carts = new List<ItemCart>();

        public void addItem(ItemCart item)
        {
            carts.Add(item);
        }

        public List<ItemCart> getAllItems()
        {
            return carts;
        }
        public decimal getTotal()
        {
            decimal total = 0;
            foreach (ItemCart item in carts)
            {
                total += item.Price * item.Quantity;
            }

            return total;
        }
    }
}
