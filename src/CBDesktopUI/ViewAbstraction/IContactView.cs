using CBDesktopUI.Library.Models;
using System;
using System.Collections.Generic;

namespace CBDesktopUI.ViewAbstraction
{
    public interface IContactView : IBaseView
    {
        event EventHandler CreateContact;
        PersonDbModel GetContact();
        PhoneDbModel GetPhone();
        AddressDbModel GetAddress();
        PersonDetailModel ContactDetails { get; set; }
        List<PhoneTypeDbModel> PhoneType { get; set; }
        List<AddressTypeDbModel> AddressType { get; set; }        
    }
}
