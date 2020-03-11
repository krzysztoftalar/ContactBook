using CBDesktopUI.Library.Models;
using System;
using System.Collections.Generic;

namespace CBDesktopUI.ViewAbstraction
{
    public interface IMainView : IBaseView
    {
        Action<IContactView> Contact { get; set; }
        event EventHandler DeleteContact;
        event EventHandler SelectedContact;

        List<PersonDbModel> ContactsList { get; set; }
        string ContactSelected { get; set; }
    }
}
