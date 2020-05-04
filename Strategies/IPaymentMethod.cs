using Dimitrios_Stratigos_Assignment4.Models;

namespace Dimitrios_Stratigos_Assignment4.Strategies
{
    public interface IPaymentMethod
    {
        string SetPayment(PaymentEnum method);
    }
}
