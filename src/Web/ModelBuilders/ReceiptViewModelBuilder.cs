using EPiServer;
using Mediachase.Commerce;
using EPi.Commerce.Core.Objects.SharedViewModels;
using EPi.Commerce.Web.Business;
using EPi.Commerce.Web.Business.Payment;
using EPi.Commerce.Web.Controllers;
using EPi.Commerce.Web.Models.PageTypes.System;
using EPi.Commerce.Web.Models.ViewModels;

namespace EPi.Commerce.Web.ModelBuilders
{
    public class ReceiptViewModelBuilder : IReceiptViewModelBuilder
    {
        private readonly IContentRepository _contentRepository;
        private readonly ISiteSettingsProvider _siteConfiguration;
        private readonly ICurrentMarket _currentMarket;

        public ReceiptViewModelBuilder(IContentRepository contentRepository, ISiteSettingsProvider siteConfiguration, ICurrentMarket currentMarket)
        {
            _contentRepository = contentRepository;
            _siteConfiguration = siteConfiguration;
            _currentMarket = currentMarket;
        }

        public ReceiptViewModel BuildFor(DibsPaymentProcessingResult processingResult)
        {
            var receiptPage = _contentRepository.Get<ReceiptPage>(_siteConfiguration.GetSettings().ReceiptPage);
            var model = new ReceiptViewModel(receiptPage);
            model.CheckoutMessage = processingResult.Message;
            model.Order = new OrderViewModel(_currentMarket.GetCurrentMarket().DefaultCurrency.Format, processingResult.Order);
            return model;
        }
    }
}