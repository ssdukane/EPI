/*
Commerce Starter Kit for EPiServer

All rights reserved. See LICENSE.txt in project root.

Copyright (C) 2013-2014 Oxx AS
Copyright (C) 2013-2014 BV Network AS

*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EPi.Commerce.Web.Business.ClientTracking;
using EPi.Commerce.Web.Models.Blocks;
using EPi.Commerce.Web.Models.PageTypes;
using EPi.Commerce.Web.Models.ViewModels;

namespace EPi.Commerce.Web.Controllers
{
    public class BannerBlockController : BlockController<BannerBlock>
    {
        private readonly IGoogleAnalyticsTracker _googleAnalyticsTracker;

        public BannerBlockController(IGoogleAnalyticsTracker googleAnalyticsTracker)
        {
            _googleAnalyticsTracker = googleAnalyticsTracker;
        }

        public override ActionResult Index(BannerBlock currentBlock)
        {
            if(string.IsNullOrEmpty(currentBlock.PromotionId) == false ||
               string.IsNullOrEmpty(currentBlock.PromotionName) == false)
            {
                _googleAnalyticsTracker.TrackPromotionImpression(currentBlock.PromotionId, currentBlock.PromotionName, currentBlock.PromotionBannerName);
            }

            return View("_bannerblock", currentBlock);
        }


    }
}
