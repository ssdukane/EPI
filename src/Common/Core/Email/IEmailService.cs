﻿/*
Commerce Starter Kit for EPiServer

All rights reserved. See LICENSE.txt in project root.

Copyright (C) 2013-2014 Oxx AS
Copyright (C) 2013-2014 BV Network AS

*/

using EPi.Commerce.Core.Objects.SharedViewModels;

namespace EPi.Commerce.Core.Email
{
	public interface IEmailService
	{
		bool SendResetPasswordEmail(string email, string subject, string body, string passwordHash, string resetUrl);
        bool SendWelcomeEmail(string email);
		bool SendWelcomeEmail(string email, string subject, string body);
		bool SendOrderReceipt(PurchaseOrderModel order);
		bool SendDeliveryReceipt(PurchaseOrderModel order, string language = null);
	}
}
