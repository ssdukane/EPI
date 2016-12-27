using EPi.Commerce.Core.Objects.SharedViewModels;

namespace EPi.Commerce.Web.Business.Payment
{
    public interface IStockUpdater
    {
        void AdjustStocks(PurchaseOrderModel order);
    }
}