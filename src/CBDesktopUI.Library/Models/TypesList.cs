using System.Collections.Generic;

namespace CBDesktopUI.Library.Models
{
    public class TypesList
    {
        public IEnumerable<PhoneTypeDbModel> PhoneTypes { get; set; }
        public IEnumerable<AddressTypeDbModel> AdressesTypes { get; set; }
    }
}
