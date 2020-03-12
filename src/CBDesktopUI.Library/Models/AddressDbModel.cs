namespace CBDesktopUI.Library.Models
{
    public class AddressDbModel
    {
        public int Id { get; set; }
        public int PersonID { get; set; }
        public int AddressTypeID { get; set; }
        public string HomeNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
