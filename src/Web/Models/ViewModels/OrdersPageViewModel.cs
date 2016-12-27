/*
Commerce Starter Kit for EPiServer

All rights reserved. See LICENSE.txt in project root.

Copyright (C) 2013-2014 Oxx AS
Copyright (C) 2013-2014 BV Network AS

*/

using System.Collections.Generic;
using EPi.Commerce.Core.Objects.SharedViewModels;
using EPi.Commerce.Web.Models.PageTypes;

namespace EPi.Commerce.Web.Models.ViewModels
{
	public class OrdersPageViewModel : PageViewModel<OrdersPage>
	{
		public List<OrderViewModel> Orders { get; set; }
		public string CustomerName { get; set; }

		public OrdersPageViewModel(OrdersPage currentPage)
			: base(currentPage)
		{
			Orders = new List<OrderViewModel>();
		}
	}
}
