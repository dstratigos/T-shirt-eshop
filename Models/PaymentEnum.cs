using System.ComponentModel.DataAnnotations;

namespace Dimitrios_Stratigos_Assignment4.Models
{
    public enum PaymentEnum
    {
        [Display(Name = "Pay on Delivery")]
        Cash,

        [Display(Name = "Debit/Credit Card")]
        Card,

        [Display(Name = "Bank Transfer")]
        Bank
    }
}
