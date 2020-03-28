using CBDesktopUI.Library.Internal.DataAccess;
using CBDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CBDesktopUI.Library.DataAccess
{
    public class ApplicationSeed
    {
        public static void Seed(IComboBoxData comboBoxData, ISqlDataAccess sql)
        {
            if (!comboBoxData.LoadComboBox().Item1.Any())
            {
                var phoneType = PhoneType();
                var addressType = AddressType();
                var contact = Person();
                var contactPhone = Phone();
                var contactAddress = Address();

                try
                {
                    sql.StartTransaction();

                    foreach (var item in phoneType)
                    {
                        var Id = sql.SaveDataInTransaction("dbo.spPhoneNumberType_Insert", item);

                        contactPhone.PhoneNumberTypeID = Convert.ToInt32(Id);
                    }

                    foreach (var item in addressType)
                    {
                        var Id = sql.SaveDataInTransaction("dbo.spAddressType_Insert", item);

                        contactAddress.AddressTypeID = Convert.ToInt32(Id);
                    }

                    var contactId = sql.SaveDataInTransaction("dbo.spPerson_Insert", contact);

                    contact.Id = Convert.ToInt32(contactId);
                    contactPhone.PersonID = contact.Id;
                    contactAddress.PersonID = contact.Id;

                    sql.SaveDataInTransaction("dbo.spPhone_Insert", contactPhone);
                    sql.SaveDataInTransaction("dbo.spAddress_Insert", contactAddress);

                    sql.CommitTransaction();
                }
                catch
                {
                    sql.RollbackTransaction();
                    throw;
                }
            }
        }

        public static List<PhoneTypeDbModel> PhoneType()
        {
            return new List<PhoneTypeDbModel>
            {
                new PhoneTypeDbModel
                {
                    Name = "Home"
                },
                new PhoneTypeDbModel
                {
                    Name = "Work"
                },
                    new PhoneTypeDbModel
                {
                    Name = "Cell"
                }
            };
        }

        public static List<AddressTypeDbModel> AddressType()
        {
            return new List<AddressTypeDbModel>
            {
                new AddressTypeDbModel
                {
                    Name = "Home"
                },
                new AddressTypeDbModel
                {
                    Name = "Work"
                },
                new AddressTypeDbModel
                {
                    Name = "Billing"
                },
                new AddressTypeDbModel
                {

                    Name = "Shipping"
                }
            };
        }

        public static PersonDbModel Person()
        {
            return new PersonDbModel
            {
                FirstName = "Kasia",
                LastName = "Kowalska",
                EmailAddress = "kasia@kk.com",
                Description = "test"
            };
        }

        public static PhoneDbModel Phone()
        {
            return new PhoneDbModel
            {
                PhoneNumber = "639-111-490"
            };
        }
        public static AddressDbModel Address()
        {
            return new AddressDbModel
            {
                HomeNumber = "22",
                Street = "Słoneczna",
                City = "Kraków",
                Country = "Polska"
            };
        }
    }
}
