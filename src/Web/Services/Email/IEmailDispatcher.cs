using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPiServer.Logging;
using EPi.Commerce.Web.Services.Email.Models;

namespace EPi.Commerce.Web.Services.Email
{
    public interface IEmailDispatcher
    {
        SendEmailResponse SendEmail(Postal.Email email);
        SendEmailResponse SendEmail(Postal.Email email, ILogger log);
    }
}
