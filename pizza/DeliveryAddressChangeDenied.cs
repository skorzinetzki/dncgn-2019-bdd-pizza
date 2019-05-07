namespace pizza
{
    public class DeliveryAddressChangeDenied : ChangeDeliveryAddressResult
    {
        public string Message { get; }

        public DeliveryAddressChangeDenied(string message)
        {
            Message = message;
        }
    }
}