using CBDesktopUI.Library.Internal.DataAccess;
using CBDesktopUI.Library.Models;
using System.Collections.Generic;

namespace CBDesktopUI.Library.DataAccess
{
    public class ComboBoxData : IComboBoxData
    {
        public List<PhoneTypeDbModel> PhoneType { get; set; }
        public List<AddressTypeDbModel> AddressType { get; set; }

        public (List<PhoneTypeDbModel>, List<AddressTypeDbModel>) LoadComboBox()
        {
            using (var sql = new SqlDataAccess())
            {
                try
                {
                    sql.StartTransaction();

                    PhoneType = sql.LoadDataInTransaction<PhoneTypeDbModel, dynamic>("spPhoneNumberType_GetAll",
                       new { });

                    AddressType = sql.LoadDataInTransaction<AddressTypeDbModel, dynamic>("spAddressType_GetAll",
                      new { });

                    sql.CommitTransaction();
                }
                catch
                {
                    sql.RollbackTransaction();
                    throw;
                }
            }

            return (PhoneType, AddressType);
        }
    }
}
