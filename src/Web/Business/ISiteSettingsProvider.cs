using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EPi.Commerce.Web.Models.PageTypes;

namespace EPi.Commerce.Web.Business
{
    public interface ISiteSettingsProvider
    {
        SettingsBlock GetSettings();
        HomePage GetStartPage();
    }
}
