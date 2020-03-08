using CBDesktopUI.Library.DataAccess;
using CBDesktopUI.Library.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CBDesktopUI
{
    public partial class MainWindow : Form
    {
        ComboBoxData formData = new ComboBoxData();
        PersonModel detailsList = new PersonModel();
        TypesList types;
        PhoneDbModel phone;
        AdressDbModel address;

        public MainWindow()
        {
            InitializeComponent();

            types = formData.LoadForm();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var person = new PersonDbModel
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                EmailAddress = emailAddress.Text,
                Description = description.Text
            };

            PersonData personData = new PersonData();

            //zabezpieczyć!
            personData.SavePerson(person, detailsList);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            mainPanel.Enabled = true;

            phoneTypes.DataSource = types.PhoneTypes.Select(x => x.Name).ToList();
            addressesTypes.DataSource = types.AdressesTypes.Select(x => x.Name).ToList();
        }

        private void AddNewAddress_Click(object sender, EventArgs e)
        {
            address = new AdressDbModel
            {
                AddressTypeID = types.AdressesTypes.FirstOrDefault(x => x.Name == addressesTypes.Text).Id,
                HomeNumber = homeNumber.Text,
                Street = street.Text,
                City = city.Text,
                Country = country.Text
            };


            if (city.Text.Length > 0)
            {
                detailsList.Addresses.Add(address);
            }

            homeNumber.Text = "";
            street.Text = "";
            city.Text = "";
            country.Text = "";
        }

        private void AddNewPhone_Click(object sender, EventArgs e)
        {
            phone = new PhoneDbModel
            {
                PhoneNumberTypeID = types.PhoneTypes.FirstOrDefault(x => x.Name == phoneTypes.Text).Id,
                PhoneNumber = phoneNumber.Text
            };

            if (phoneNumber.Text.Length > 0)
            {
                detailsList.Phones.Add(phone);
            }

            phoneNumber.Text = "";
        }
    }
}
