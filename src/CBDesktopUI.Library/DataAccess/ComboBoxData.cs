using CBDesktopUI.Library.Internal.DataAccess;
using CBDesktopUI.Library.Models;
using System.Collections.Generic;

namespace CBDesktopUI.Library.DataAccess
{
    public class ComboBoxData : IComboBoxData
    {
        private readonly ISqlDataAccess _sql;

        public ComboBoxData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<PhoneTypeDbModel> PhoneType { get; set; }
        public List<AddressTypeDbModel> AddressType { get; set; }

        public (List<PhoneTypeDbModel>, List<AddressTypeDbModel>) LoadComboBox()
        {
            try
            {
                _sql.StartTransaction();

                PhoneType = _sql.LoadDataInTransaction<PhoneTypeDbModel, dynamic>("spPhoneNumberType_GetAll",
                   new { });

                AddressType = _sql.LoadDataInTransaction<AddressTypeDbModel, dynamic>("spAddressType_GetAll",
                  new { });

                _sql.CommitTransaction();
            }
            catch
            {
                _sql.RollbackTransaction();
                throw;
            }

            return (PhoneType, AddressType);
        }
    }
}
