/*
Commerce Starter Kit for EPiServer

All rights reserved. See LICENSE.txt in project root.

Copyright (C) 2013-2014 Oxx AS
Copyright (C) 2013-2014 BV Network AS

*/

using EPiServer.Core;
using EPi.Commerce.Core.Objects.SharedViewModels;
using EPi.Commerce.Web.Models.PageTypes.System;

namespace EPi.Commerce.Web.Models.ViewModels
{
	public class ReceiptViewModel : PageViewModel<ReceiptPage>
	{
		public ReceiptViewModel()
		{
		}

		public ReceiptViewModel(ReceiptPage currentPage)
			: base(currentPage)
		{
			ThankYouText = currentPage.ThankYouText;
			ThankYouTitle = currentPage.ThankYouTitle;
		}

		public OrderViewModel Order { get; set; }
		public string CheckoutMessage { get; set; }

	    public string ThankYouTitle { get; set; }
	    public virtual XhtmlString ThankYouText { get; set; }

	}
}
