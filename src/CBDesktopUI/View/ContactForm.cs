using CBDesktopUI.Library.Models;
using CBDesktopUI.ViewAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CBDesktopUI
{
    public partial class ContactForm : Form, IContactView
    {
        public PersonDetailModel ContactDetails { get; set; }
        public List<PhoneTypeDbModel> PhoneType
        {
            get => phonesTypes.DataSource as List<PhoneTypeDbModel>;
            set
            {
                phonesTypes.DisplayMember = "Name";
                phonesTypes.ValueMember = "Id";
                phonesTypes.DataSource = value.Select(x =>
                    new { Name = x.Name, Id = x.Id }).ToList();
            }
        }
        public List<AddressTypeDbModel> AddressType
        {
            get => addressesTypes.DataSource as List<AddressTypeDbModel>;
            set
            {
                addressesTypes.DisplayMember = "Name";
                addressesTypes.ValueMember = "Id";
                addressesTypes.DataSource = value.Select(x =>
                    new { Name = x.Name, Id = x.Id }).ToList();
            }
        }

        public event EventHandler CreateContact;

        public ContactForm()
        {
            InitializeComponent();

            ContactDetails = new PersonDetailModel();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            CreateContact?.Invoke(sender, e);
        }

        private void AddNewPhone_Click(object sender, EventArgs e)
        {
            ContactDetails.Phones.Add(GetPhone());

            ClearPhone();
        }

        private void AddNewAddress_Click(object sender, EventArgs e)
        {
            ContactDetails.Addresses.Add(GetAddress());

            ClearAddress();
        }

        public void OpenView()
        {
            ShowDialog();
        }

        public PersonDbModel GetContact()
        {
            return new PersonDbModel
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                EmailAddress = emailAddress.Text,
                Description = description.Text
            };
        }

        public PhoneDbModel GetPhone()
        {
            int.TryParse(phonesTypes.SelectedValue.ToString(), out int id);

            return new PhoneDbModel
            {
                PhoneNumberTypeID = id,
                PhoneNumber = phoneNumber.Text
            };
        }

        public AddressDbModel GetAddress()
        {
            int.TryParse(addressesTypes.SelectedValue.ToString(), out int id);

            return new AddressDbModel
            {
                AddressTypeID = id,
                HomeNumber = homeNumber.Text,
                Street = street.Text,
                City = city.Text,
                Country = country.Text
            };
        }

        public void ClearPhone()
        {
            phoneNumber.Text = string.Empty;
        }

        public void ClearAddress()
        {
            homeNumber.Text = string.Empty;
            street.Text = string.Empty;
            city.Text = string.Empty;
            country.Text = string.Empty;
        }
    }
}
