using EPi.Commerce.Web.Models.ViewModels;

namespace EPi.Commerce.Web.Business.ClientTracking
{
    public interface IGoogleAnalyticsTracker
    {
        void TrackAfterPayment(ReceiptViewModel model);
        void TrackPromotionImpression(string id, string name, string bannerName);
        string GetPromotionClickScript(string id, string name, string bannerName);
    }
}