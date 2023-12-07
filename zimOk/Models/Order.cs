namespace zimOk.Models
{
    using System;
    using System.Collections.Generic;

    public class Order
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalPrice => OrderItems.Sum(item => item.ProductPrice * item.Quantity);

        // Navigation property
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
