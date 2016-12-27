/*
Commerce Starter Kit for EPiServer

All rights reserved. See LICENSE.txt in project root.

Copyright (C) 2013-2014 Oxx AS
Copyright (C) 2013-2014 BV Network AS

*/

using Mediachase.Commerce.Customers;
using EPi.Commerce.Core.Objects;

namespace EPi.Commerce.Core.Repositories.Interfaces
{
    public interface ICustomerAddressRepository 
    {
        Address GetDefaultBillingAddress();
        Address GetDefaultShippingAddress();
		void SetCustomer(CustomerContact contact);
		void Save(Address address);
    }
}
