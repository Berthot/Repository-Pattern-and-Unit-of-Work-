namespace UnitOfShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Number  { get; set; }

        public int CustumerId { get; set; }

        public Customer Custumer { get; set; }
    }
}