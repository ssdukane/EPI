using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPi.Commerce.Web.Business.Payment;
using EPi.Commerce.Web.Models.ViewModels;

namespace EPi.Commerce.Web.Controllers
{
    public interface IReceiptViewModelBuilder
    {
        ReceiptViewModel BuildFor(DibsPaymentProcessingResult processingResult);
    }
}