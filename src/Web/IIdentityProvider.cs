using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace EPi.Commerce.Web
{
    public interface IIdentityProvider
    {
        IIdentity GetIdentity();
    }
}