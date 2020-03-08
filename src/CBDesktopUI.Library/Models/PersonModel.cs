using System.Collections.Generic;

namespace CBDesktopUI.Library.Models
{
    public class PersonModel
    {
        public List<PhoneDbModel> Phones { get; set; } = new List<PhoneDbModel>();
        public List<AdressDbModel> Addresses { get; set; } = new List<AdressDbModel>();
    }
}
