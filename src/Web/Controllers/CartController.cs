﻿/*
Commerce Starter Kit for EPiServer

All rights reserved. See LICENSE.txt in project root.

Copyright (C) 2013-2014 Oxx AS
Copyright (C) 2013-2014 BV Network AS

*/

using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Mediachase.Commerce.Orders;
using EPi.Commerce.Core.Objects;
using EPi.Commerce.Web.Business.Analytics;
using EPi.Commerce.Web.Business.Delivery;
using EPi.Commerce.Web.Models.PageTypes;
using EPi.Commerce.Web.Models.ViewModels;
using EPi.Commerce.Web.Services;
using LineItem = Mediachase.Commerce.Orders.LineItem;

namespace EPi.Commerce.Web.Controllers
{

    [TemplateDescriptor(Inherited = true)]
    public class CartController : PageController<CartSimpleModulePage>
    {
        private readonly IPostNordClient _postNordClient;

        public CartController(IPostNordClient postNordClient)
        {
            _postNordClient = postNordClient;
        }

        public async Task<JsonResult> GetDeliveryLocations(string streetAddress, string city, string postalCode)
        {
            string streetNumber = string.Empty;

            if (!string.IsNullOrEmpty(streetAddress))
            {
                streetAddress = streetAddress.TrimEnd();


                // Parse the street name and number (if any) from the street address

                var i = streetAddress.Length - 1;
                bool hasDigit = false;

                for (; 0 <= i; --i)
                {
                    if (char.IsDigit(streetAddress[i]))
                    {
                        hasDigit = true;
                        continue;
                    }

                    if (!char.IsLetter(streetAddress[i]))
                    {
                        break;
                    }
                }

                ++i;



                if (hasDigit && i < streetAddress.Length)
                {
                    streetNumber = streetAddress.Substring(i);
                    streetAddress = streetAddress.Substring(0, i).Trim();
                }
                else
                {
                    streetNumber = null;
                }
            }


            if (string.IsNullOrEmpty(postalCode))
            {
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
            }

            try
            {
                var x = (await _postNordClient.FindNearestByAddress(new RegionInfo("NO"), city, postalCode, streetAddress, streetNumber)).
                    Select(sp => new DeliveryLocation(
                        new ServicePoint() { Id = sp.Id, Name = sp.Name, Address = sp.DeliveryAddress.StreetName + ' ' + sp.DeliveryAddress.StreetNumber, City = sp.DeliveryAddress.City, PostalCode = sp.DeliveryAddress.PostalCode },
                        sp.Name));
                return Json(x, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
            }
            return Json(new { success = false }, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// The main view for the cart.
        /// </summary>
        public ViewResult Index(CartSimpleModulePage currentPage)
        {
            CartModel model = new CartModel(currentPage);

            Track(model);

            return View(model);
        }

        private void Track(CartModel model)
        {
            // Track Analytics. 
            // TODO: Remove when GA add-in is fixed
            GoogleAnalyticsTracking tracking = new GoogleAnalyticsTracking(ControllerContext.HttpContext);

            // Add the products
            int i = 1;
            foreach (LineItem lineItem in model.LineItems)
            {
                tracking.ProductAdd(code: lineItem.Code,
                    name: lineItem.DisplayName,
                    quantity: (int)lineItem.Quantity,
                    price: (double)lineItem.PlacedPrice,
                    position: i
                    );
                i++;
            }

            // Step 1 is to review the cart
            tracking.Action("checkout", "{\"step\":1}");
        }
    }
}
