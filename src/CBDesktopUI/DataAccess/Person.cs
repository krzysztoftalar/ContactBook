using CBDesktopUI.Library.DataAccess;
using CBDesktopUI.Library.Models;
using System;
using System.Collections.Generic;

namespace CBDesktopUI.DataAccess
{
    public class Person : EventArgs
    {
        private PersonData personData = new PersonData();
        public event EventHandler OperationApprovedEvent;

        public Person()
        {
            DetailsList = new PersonDetailModel();
        }

        private PersonDbModel _contact;

        public PersonDbModel Contact
        {
            get => _contact;
            set { _contact = value; }
        }

        private PersonDetailModel _detailsList;

        public PersonDetailModel DetailsList
        {
            get => _detailsList;
            set { _detailsList = value; }
        }

        private PhoneDbModel _phone;

        public PhoneDbModel Phone
        {
            get => _phone;
            set { _phone = value; }
        }

        private AddressDbModel _address;

        public AddressDbModel Address
        {
            get => _address;
            set { _address = value; }
        }


        public void AddContact(string firstName, string lastName, string emailAddress, string description)
        {
            Contact = new PersonDbModel
            {
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress,
                Description = description
            };
        }

        public void AddPhone(string phoneNumber, int phoneTypesId)
        {
            Phone = new PhoneDbModel
            {
                PhoneNumber = phoneNumber,
                PhoneNumberTypeID = phoneTypesId
            };

            DetailsList.Phones.Add(Phone);
        }

        public void AddAddress(int addressTypeId, string homeNumber, string street, string city, string country)
        {
            Address = new AddressDbModel
            {
                AddressTypeID = addressTypeId,
                HomeNumber = homeNumber,
                Street = street,
                City = city,
                Country = country
            };

            DetailsList.Addresses.Add(Address);
        }

        public bool SaveContact()
        {
            //personData = new PersonData();

            //personData.SaveContact(Contact, DetailsList);

            //OperationApprovedEvent?.Invoke(this, EventArgs.Empty);

            return true;
        }

        public List<PersonDbModel> GetContacts()
        {
            return personData.GetContacts();
        }

        public void DeleteContact(int id)
        {
            //personData.DeletePerson(id);

            OperationApprovedEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
