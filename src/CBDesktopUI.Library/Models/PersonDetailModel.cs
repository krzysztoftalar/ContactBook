using System.Collections.Generic;

namespace CBDesktopUI.Library.Models
{
    public class PersonDetailModel
    {
        public PersonDetailModel()
        {
            Phones = new List<PhoneDbModel>();
            Addresses = new List<AddressDbModel>();
        }

        public List<PhoneDbModel> Phones { get; set; }
        public List<AddressDbModel> Addresses { get; set; }
    }
}
