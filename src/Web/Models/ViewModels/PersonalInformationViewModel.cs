/*
Commerce Starter Kit for EPiServer

All rights reserved. See LICENSE.txt in project root.

Copyright (C) 2013-2014 Oxx AS
Copyright (C) 2013-2014 BV Network AS

*/

using EPi.Commerce.Core.Objects;
using EPi.Commerce.Web.Models.PageTypes;

namespace EPi.Commerce.Web.Models.ViewModels
{
    public class PersonalInformationViewModel : PageViewModel<PersonalInformationPage>
    {
        public PersonalSettingsForm PersonalSettingsForm { get; set; }

        public PersonalInformationViewModel(PersonalInformationPage currentPage) : base(currentPage)
        {
            PersonalSettingsForm = new PersonalSettingsForm();
        }
    }
}
