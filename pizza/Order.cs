namespace pizza
{
    public class Order
    {
        public Customer Customer { get; set; }
        public Address DeliveryAddress { get; set; }
        public Pizza Pizza { get; set; }
        public DeliveryState DeliveryState { get; set; }
    }
}