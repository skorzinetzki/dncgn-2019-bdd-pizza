namespace pizza
{
    public class ChangeDeliveryAddressResult
    {
        public ChangeDeliveryAddressResultType Type { get; }
        public string Message { get; }

        public ChangeDeliveryAddressResult(ChangeDeliveryAddressResultType type, string message = "")
        {
            Type = type;
            Message = message;
        }
    }
}