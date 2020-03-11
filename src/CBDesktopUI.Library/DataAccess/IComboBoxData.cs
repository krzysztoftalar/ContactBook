using CBDesktopUI.Library.Models;
using System.Collections.Generic;

namespace CBDesktopUI.Library.DataAccess
{
    public interface IComboBoxData
    {
        (List<PhoneTypeDbModel>, List<AddressTypeDbModel>) LoadComboBox();
    }
}