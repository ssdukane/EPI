﻿/*
Commerce Starter Kit for EPiServer

All rights reserved. See LICENSE.txt in project root.

Copyright (C) 2013-2014 Oxx AS
Copyright (C) 2013-2014 BV Network AS

*/

using System.Collections.Generic;
using EPi.Commerce.Web.Models.PageTypes;

namespace EPi.Commerce.Web.Models.ViewModels
{
    public class ShoppingCategoryViewModel : PageViewModel<ShoppingCategoryPage>
    {
        public ShoppingCategoryViewModel(ShoppingCategoryPage currentPage)
            : base(currentPage)
        {
            
        }
        public string CommerceRootCategoryName { get; set; }
        public string CommerceCategoryIds { get; set; }
		public string ParentName { get; set; }

        public int NumberOfProductsToShow { get; set; }


        public IEnumerable<ShoppingCategoryPage> CategoryPages { get; set; }
    }
}
