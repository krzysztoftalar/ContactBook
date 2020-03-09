using CBDesktopUI.Library.Internal.DataAccess;
using CBDesktopUI.Library.Models;

namespace CBDesktopUI.Library.DataAccess
{
    public class ComboBoxData
    {
        public TypesList TypesList { get; set; }

        public TypesList LoadComboBox()
        {
            using (var sql = new SqlDataAccess())
            {
                try
                {
                    sql.StartTransaction();

                    TypesList = new TypesList
                    {
                        PhoneTypes = sql.LoadDataInTransaction<PhoneTypeDbModel, dynamic>("spPhoneNumberType_GetAll",
                        new { }),

                        AdressesTypes = sql.LoadDataInTransaction<AddressTypeDbModel, dynamic>("spAddressType_GetAll",
                        new { })
                    };

                    sql.CommitTransaction();
                }
                catch
                {
                    sql.RollbackTransaction();
                    throw;
                }
            }

            return TypesList;
        }
    }
}
