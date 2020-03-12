using CBDesktopUI.Library.DataAccess;
using CBDesktopUI.ViewAbstraction;
using System;

namespace CBDesktopUI.Presenter
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly IPersonData _personData;
        private readonly IComboBoxData _boxData;

        public MainPresenter(IMainView view, IPersonData personData, IComboBoxData boxData)
        {
            _view = view;
            _personData = personData;
            _boxData = boxData;

            _view.Contact += (v) => ShowContact(v, null);
            _view.EditContact += (v, u) => ShowContact(v, u);
            _view.DeleteContact += OnDeleteContact;
            _view.SelectedContact += OnSelectedContact;

            LoadContacts();
        }

        private void OnSelectedContact(object sender, EventArgs e)
        {

        }

        private void OnDeleteContact(object sender, EventArgs e)
        {
            int.TryParse(_view.ContactSelected, out int id);
            _personData.DeleteContact(id);

            LoadContacts();
        }

        public void LoadContacts()
        {
            _view.ContactsList = _personData.GetContacts();
        }

        private void ShowContact(IContactView contactView, string contactId)
        {
            var contactPresenter = new ContactPresenter(contactView, _personData, _boxData);
            contactPresenter.MainPresenter = this;
            contactPresenter.Contact(contactId);
        }

        public void ShowView()
        {
            _view.OpenView();
        }
    }
}
