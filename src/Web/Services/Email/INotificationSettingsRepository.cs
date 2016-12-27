using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EPi.Commerce.Web.Models.ViewModels.Email;

namespace EPi.Commerce.Web.Services.Email
{
    public interface INotificationSettingsRepository
    {
        NotificationSettings GetNotificationSettings(string language = null);
    }
}
