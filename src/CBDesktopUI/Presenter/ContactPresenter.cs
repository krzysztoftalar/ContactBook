using CBDesktopUI.Library.DataAccess;
using CBDesktopUI.ViewAbstraction;
using System;

namespace CBDesktopUI.Presenter
{
    public class ContactPresenter
    {
        private readonly IContactView _view;
        private readonly IPersonData _personData;
        private readonly IComboBoxData _boxData;
        public MainPresenter MainPresenter { get; set; }

        public ContactPresenter(IContactView view, IPersonData personData, IComboBoxData boxData)
        {
            _view = view;
            _personData = personData;
            _boxData = boxData;

            LoadTypes();

            _view.CreateContact += OnCreateContact;
        }

        private void OnCreateContact(object sender, EventArgs e)
        {
            var contact = _view.GetContact();
            var contactDetails = _view.ContactDetails;

            _personData.SaveContact(contact, contactDetails);

            MainPresenter?.LoadContacts();
        }

        public void Contact()
        {
            _view.OpenView();
        }

        public void LoadTypes()
        {
            _view.PhoneType = _boxData.LoadComboBox().Item1;
            _view.AddressType = _boxData.LoadComboBox().Item2;
        }
    }
}
