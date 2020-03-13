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

            _view.Contact += (v, y) => ShowContact(v, null, y);
            _view.EditContact += (v, u, y) => ShowContact(v, u, y);
            _view.DeleteContact += OnDeleteContact;

            LoadContacts();
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

        private void ShowContact(IContactView contactView, string contactId, bool isEditMode)
        {
            var contactPresenter = new ContactPresenter(contactView, _personData, _boxData);
            contactPresenter.MainPresenter = this;
            contactPresenter.Contact(contactId, isEditMode);
        }

        public void ShowView()
        {
            _view.OpenView();
        }
    }
}
