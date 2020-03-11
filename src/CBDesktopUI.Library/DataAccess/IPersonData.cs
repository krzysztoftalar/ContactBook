using CBDesktopUI.Library.Models;
using System.Collections.Generic;

namespace CBDesktopUI.Library.DataAccess
{
    public interface IPersonData
    {
        void DeleteContact(int id);
        List<PersonDbModel> GetContacts();
        void SaveContact(PersonDbModel person, PersonDetailModel personModel);
    }
}