/*
Commerce Starter Kit for EPiServer

All rights reserved. See LICENSE.txt in project root.

Copyright (C) 2013-2014 Oxx AS
Copyright (C) 2013-2014 BV Network AS

*/


using EPi.Commerce.Web.Models.PageTypes;
using EPi.Commerce.Web.Models.ViewModels.Email;
using EPi.Commerce.Web.Services.Email.Models;

namespace EPi.Commerce.Web.Models.ViewModels
{
	public class NewsletterViewModel : INotificationSettings
	{
		public NewsletterViewModel(NewsletterPage currentPage, NotificationSettings settings)
		{
			NewsletterPage = currentPage;

			if (settings != null)
			{
				Settings = settings;
				From = settings.From;
				Footer = settings.MailFooter.ToString();
				Header = settings.MailHeader.ToString();
			}
		}


		public NewsletterPage NewsletterPage { get; set; }
		public NotificationSettings Settings { get; set; }
		public string From { get; set; }
		public string Footer { get; set; }
		public string Header { get; set; }
		public string UnsubscribeUrl { get; set; }
	}
}
