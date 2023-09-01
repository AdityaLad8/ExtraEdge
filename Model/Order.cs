namespace ExtraEdgeMobile.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal TotalPrice { get; set; }
   
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
