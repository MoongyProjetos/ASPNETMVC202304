namespace WebAPIEX01.models
{
    public class PaypalObject
    {
        public Purchase_Units[] purchase_units { get; set; }
        public string intent { get; set; }
        public Payment_Source payment_source { get; set; }
    }

}
