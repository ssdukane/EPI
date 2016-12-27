using System.Security.Principal;
using EPi.Commerce.Core.Objects.SharedViewModels;

namespace EPi.Commerce.Web.Business.Payment
{
    public interface IPaymentCompleteHandler
    {
        void ProcessCompletedPayment(PurchaseOrderModel orderModel, IIdentity identity);
    }
}