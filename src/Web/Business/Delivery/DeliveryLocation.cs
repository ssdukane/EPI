﻿using EPi.Commerce.Core.Objects;

namespace EPi.Commerce.Web.Business.Delivery
{
    public class DeliveryLocation
    {
        public DeliveryLocation(ServicePoint value, string text)
        {
            this.value = value;
            this.text = text;
        }

        public ServicePoint value { get; private set; }
        public string text { get; private set; }
    }
}