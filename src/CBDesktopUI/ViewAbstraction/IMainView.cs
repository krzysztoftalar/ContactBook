using CBDesktopUI.Library.Models;
using System;
using System.Collections.Generic;

namespace CBDesktopUI.ViewAbstraction
{
    public interface IMainView : IBaseView
    {
        Action<IContactView, bool> Contact { get; set; }
        Action<IContactView, string, bool> EditContact { get; set; }

        event EventHandler DeleteContact;

        List<PersonDbModel> ContactsList { get; set; }
        string ContactSelected { get; set; }
    }
}
