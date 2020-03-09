using CBDesktopUI.DataAccess;
using CBDesktopUI.Library.DataAccess;
using CBDesktopUI.Library.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CBDesktopUI
{
    public partial class MainPanel : Form
    {
        ComboBoxData comboBoxData = new ComboBoxData();
        TypesList types;
        Person _person;

        public MainPanel(Person person)
        {
            InitializeComponent();
            ShowData();

            _person = person;
        }

        private void ShowData()
        {
            types = comboBoxData.LoadComboBox();

            phonesTypes.DataSource = types.PhoneTypes.Select(x => x.Name).ToList();
            addressesTypes.DataSource = types.AdressesTypes.Select(x => x.Name).ToList();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                _person.AddContact(firstName.Text, lastName.Text, emailAddress.Text, description.Text);
                bool result = _person.SaveContact();
            }
        }

        private void AddNewPhone_Click(object sender, EventArgs e)
        {
            if (phoneNumber.Text.Length > 0)
            {
                _person.AddPhone(phoneNumber.Text, types.PhoneTypes.FirstOrDefault(x => x.Name == phonesTypes.Text).Id);
            }

            phoneNumber.Text = "";
        }

        private void AddNewAddress_Click(object sender, EventArgs e)
        {
            _person.AddAddress(types.AdressesTypes.FirstOrDefault(x => x.Name == addressesTypes.Text).Id,
                homeNumber.Text, street.Text, city.Text, country.Text);

            homeNumber.Text = "";
            street.Text = "";
            city.Text = "";
            country.Text = "";
        }

        private void firstName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(firstName.Text))
            {
                e.Cancel = true;
                firstName.Focus();
                errorValidation.SetError(firstName, "Required");
            }
            else
            {
                errorValidation.Clear();
            }
        }
    }
}
