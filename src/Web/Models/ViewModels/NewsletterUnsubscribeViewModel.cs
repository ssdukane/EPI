﻿/*
Commerce Starter Kit for EPiServer

All rights reserved. See LICENSE.txt in project root.

Copyright (C) 2013-2014 Oxx AS
Copyright (C) 2013-2014 BV Network AS

*/

using System.ComponentModel.DataAnnotations;
using EPi.Commerce.Web.Models.PageTypes;

namespace EPi.Commerce.Web.Models.ViewModels
{
	public class NewsletterUnsubscribeViewModel : PageViewModel<NewsletterUnsubscribePage>
	{
		public NewsletterUnsubscribeViewModel() { }

		public NewsletterUnsubscribeViewModel(NewsletterUnsubscribePage currentPage)
			: base(currentPage)
		{

		}

		[Required]
		[EmailAddress]
		public string Email { get; set; }
		public string ErrorResponse { get; set; }

	}
}
