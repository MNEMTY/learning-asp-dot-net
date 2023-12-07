namespace zimOk.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }

        public int Quantity { get; set; }

        // Navigation properties
        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
