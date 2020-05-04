using Dimitrios_Stratigos_Assignment4.Models;


namespace Dimitrios_Stratigos_Assignment4.Strategies
{
    public class Payment : IPaymentMethod
    {
        public string SetPayment(PaymentEnum method)
        {
            switch ((int)method)
            {
                case 1:
                    return "pay on Delivery";

                case 2:
                    return "pay with Credit/Debit Card";

                case 3:
                    return "pay by Bank Transfer";

                default:
                    return "pay with Cash";
            }
        }
    }
}
