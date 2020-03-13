using System.Collections.Generic;

namespace CBDesktopUI.Library.Internal.DataAccess
{
    public interface ISqlDataAccess
    {
        void CommitTransaction();
        void Dispose();
        List<T> LoadData<T, U>(string storedProcedure, U parameters);
        List<T> LoadDataInTransaction<T, U>(string storedProcedure, U parameters);
        void RollbackTransaction();
        void SaveData<T>(string storedProcedure, T parameters);
        object SaveDataInTransaction<T>(string storedProcedure, T parameters);
        void StartTransaction();
    }
}