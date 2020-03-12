using CBDesktopUI.Library.Models;
using System;
using System.Collections.Generic;

namespace CBDesktopUI.ViewAbstraction
{
    public interface IContactView : IBaseView
    {
        event EventHandler CreateContact;
        event EventHandler EditContact;
        event EventHandler AddPhone;
        event EventHandler EditPhone;
        event EventHandler AddAddress;
        event EventHandler EditAddress;
        event EventHandler PhoneTypeSelected;
        event EventHandler AddressTypeSelected;

        List<PhoneTypeDbModel> PhoneType { get; set; }
        List<AddressTypeDbModel> AddressType { get; set; }

        int ContactId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        string Description { get; set; }

        int PhoneId { get; set; }
        int PhoneNumberTypeID { get; }
        string PhoneNumber { get; set; }

        int AddressId { get; set; }
        int AddressTypeID { get; }
        string HomeNumber { get; set; }
        string Street { get; set; }
        string City { get; set; }
        string Country { get; set; }
    }
}
