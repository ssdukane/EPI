﻿/*
Commerce Starter Kit for EPiServer

All rights reserved. See LICENSE.txt in project root.

Copyright (C) 2013-2014 Oxx AS
Copyright (C) 2013-2014 BV Network AS

*/

using System.Linq;
using System.Web.Mvc;
using EPiServer.Security;
using Mediachase.Commerce;
using Mediachase.Commerce.Customers;
using Mediachase.Commerce.Orders;
using Mediachase.Commerce.Security;
using EPi.Commerce.Core.Objects.SharedViewModels;
using EPi.Commerce.Core.Repositories.Interfaces;
using EPi.Commerce.Core.Services;
using EPi.Commerce.Web.Models.PageTypes;
using EPi.Commerce.Web.Models.ViewModels;

namespace EPi.Commerce.Web.Controllers
{
	public class OrdersPageController : PageControllerBase<OrdersPage>
	{
		private readonly IOrderService _orderService;
	    private readonly ICurrentMarket _currentMarket;

		public OrdersPageController(IOrderService orderService, ICurrentMarket currentMarket)
		{
			_orderService = orderService;
		    _currentMarket = currentMarket;
		}


		// GET: OrdersPage
		public ActionResult Index(OrdersPage currentPage)
		{
			var model = new OrdersPageViewModel(currentPage);
			model.CustomerName = CustomerContext.Current.CurrentContact.FirstName;
            var orders = _orderService.GetOrdersByUserId(EPiServer.Security.PrincipalInfo.CurrentPrincipal.GetContactId());
			model.Orders = orders.OrderByDescending(x => x.Created).Select(CreateOrderViewModel).ToList();
			
			return View(model);
		}


		private OrderViewModel CreateOrderViewModel(PurchaseOrderModel order)
		{
            var model = new OrderViewModel(_currentMarket.GetCurrentMarket().DefaultCurrency.Format, order);
			// TODO order-payment method
			model.PaymentMethod = order.ProviderId;

			return model;
		}
	}
}
