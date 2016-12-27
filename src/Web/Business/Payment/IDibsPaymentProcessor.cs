using System.Security.Principal;
using EPi.Commerce.Core.PaymentProviders.DIBS;

namespace EPi.Commerce.Web.Business.Payment
{
    public interface IDibsPaymentProcessor
    {
        DibsPaymentProcessingResult ProcessPaymentResult(DibsPaymentResult result, IIdentity identity);
    }
}