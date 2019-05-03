namespace pizza
{
    public class PizzaService
    {
        public Order PlaceOrder(Customer customer, Address deliveryAddress, Pizza pizza)
        {
            var order = new Order
            {
                Customer = customer,
                DeliveryAddress = deliveryAddress,
                Pizza = pizza,
                DeliveryState = DeliveryState.Ordered
            };

            // some magic here

            return order;
        }

        public void PizzaIsReady(Order order)
        {
            order.DeliveryState = DeliveryState.WaitingForPickup;
        }

        public void PizzaIsPickedUpByDriver(Order order)
        {
            order.DeliveryState = DeliveryState.OnDelivery;
        }

        public void PizzaIsDelivered(Order order)
        {
            order.DeliveryState = DeliveryState.Delivered;
        }
    }
}


