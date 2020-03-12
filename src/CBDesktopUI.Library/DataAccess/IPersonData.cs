using CBDesktopUI.Library.Models;
using System.Collections.Generic;

namespace CBDesktopUI.Library.DataAccess
{
    public interface IPersonData
    {
        void SaveContact(PersonDbModel person, PersonDetailModel personModel);
        void EditContact(PersonDbModel person, PersonDetailModel personModel);
        void DeleteContact(int id);
        List<PersonDbModel> GetContacts();
        (PersonDbModel, List<PhoneDbModel>, List<AddressDbModel>) GetContactById(int id);
    }
}