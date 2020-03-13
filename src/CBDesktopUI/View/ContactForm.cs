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
        public event EventHandler CreateContact;
        public event EventHandler EditContact;
        public event EventHandler AddPhone;
        public event EventHandler AddAddress;
        public event EventHandler PhoneTypeSelected;
        public event EventHandler AddressTypeSelected;
        public event EventHandler EditPhone;
        public event EventHandler EditAddress;

        public ContactForm()
        {
            InitializeComponent();
        }

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

        public void SetVisibilityButttons(bool visible)
        {
            SaveButton.Visible = visible;
            AddNewPhone.Visible = visible;
            AddNewAddress.Visible = visible;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ContactId <= 0 && (FirstName.Length > 0 || LastName.Length > 0))
            {
                CreateContact?.Invoke(sender, e);
            }
            else
            {
                EditContact?.Invoke(sender, e);
            }

            CloseView();
        }

        private void AddNewPhone_Click(object sender, EventArgs e)
        {
            if (ContactId <= 0)
            {
                AddPhone?.Invoke(sender, e);
            }
            else
            {
                EditPhone?.Invoke(sender, e);
            }
        }

        private void AddNewAddress_Click(object sender, EventArgs e)
        {
            if (ContactId <= 0)
            {
                AddAddress?.Invoke(sender, e);
            }
            else
            {
                EditAddress?.Invoke(sender, e);
            }
        }

        private void phonesTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            PhoneTypeSelected?.Invoke(sender, e);
        }

        private void addressesTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddressTypeSelected?.Invoke(sender, e);
        }

        public int ContactId { get; set; }

        public string FirstName
        {
            get => firstName.Text;
            set { firstName.Text = value; }
        }

        public string LastName
        {
            get => lastName.Text;
            set { lastName.Text = value; }
        }

        public string EmailAddress
        {
            get => emailAddress.Text;
            set { emailAddress.Text = value; }
        }

        public string Description
        {
            get => description.Text;
            set { description.Text = value; }
        }

        public int PhoneId { get; set; }

        public int PhoneNumberTypeID
        {
            get => int.Parse(phonesTypes.SelectedValue.ToString());
        }

        public string PhoneNumber
        {
            get => phoneNumber.Text;
            set { phoneNumber.Text = value; }
        }

        public int AddressId { get; set; }

        public int AddressTypeID
        {
            get => int.Parse(addressesTypes.SelectedValue.ToString());
        }

        public string HomeNumber
        {
            get => homeNumber.Text;
            set { homeNumber.Text = value; }
        }

        public string Street
        {
            get => street.Text;
            set { street.Text = value; }
        }

        public string City
        {
            get => city.Text;
            set { city.Text = value; }
        }

        public string Country
        {
            get => country.Text;
            set { country.Text = value; }
        }

        public void OpenView()
        {
            Show();
        }

        public void CloseView()
        {
            Close();
        }
    }
}
