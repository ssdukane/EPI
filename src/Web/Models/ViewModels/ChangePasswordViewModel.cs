/*
Commerce Starter Kit for EPiServer

All rights reserved. See LICENSE.txt in project root.

Copyright (C) 2013-2014 Oxx AS
Copyright (C) 2013-2014 BV Network AS

*/

using EPi.Commerce.Core.Objects;
using EPi.Commerce.Core.Repositories;
using EPi.Commerce.Web.Models.PageTypes;

namespace EPi.Commerce.Web.Models.ViewModels
{
	public class ChangePasswordViewModel : PageViewModel<ChangePasswordPage>
	{
		public ChangePasswordForm ChangePasswordForm { get; set; }
		public string Firstname { get; set; }

		public ChangePasswordViewModel(ChangePasswordPage currentPage)
			: base(currentPage)
		{
			ChangePasswordForm = new ChangePasswordForm();

			var contactRepository = new ContactRepository();
			var contactInformation = contactRepository.Get();
			Firstname = contactInformation.FirstName;

		}
	}
}
