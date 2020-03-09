using System.Collections.Generic;

namespace CBDesktopUI.Library.Models
{
    public class PersonModel
    {
        public PersonModel()
        {
            Phones = new List<PhoneDbModel>();
            Addresses = new List<AdressDbModel>();
        }

        public List<PhoneDbModel> Phones { get; set; }
        public List<AdressDbModel> Addresses { get; set; }
    }
}
