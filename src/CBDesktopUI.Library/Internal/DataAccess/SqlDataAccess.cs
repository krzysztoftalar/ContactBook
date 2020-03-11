using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CBDesktopUI.Library.Internal.DataAccess
{
    public class SqlDataAccess : IDisposable
    {
        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CBData"].ConnectionString;
        }

        public void SaveData<T>(string storedProcedure, T parameters)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public List<T> LoadData<T, U>(string storedProcedure, U parameters)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString()))
            {
                List<T> rows = connection
                    .Query<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure).ToList();

                return rows;
            }
        }

        private IDbConnection _connection;
        private IDbTransaction _transaction;

        public void StartTransaction()
        {
            _connection = new SqlConnection(GetConnectionString());
            _connection.Open();

            _transaction = _connection.BeginTransaction();

            _isClosed = false;
        }

        public List<T> LoadDataInTransaction<T, U>(string storedProcedure, U parameters)
        {
            List<T> rows = _connection.Query<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure,
                    transaction: _transaction).ToList();

            return rows;
        }

        public object SaveDataInTransaction<T>(string storedProcedure, T parameters)
        {
            return _connection.ExecuteScalar(storedProcedure, parameters, commandType: CommandType.StoredProcedure,
                transaction: _transaction);
        }

        private bool _isClosed = false;

        public void CommitTransaction()
        {
            _transaction?.Commit();
            _connection?.Close();

            _isClosed = true;
        }

        public void RollbackTransaction()
        {
            _transaction?.Rollback();
            _connection?.Close();

            _isClosed = true;
        }

        public void Dispose()
        {
            if (_isClosed == false)
            {
                try
                {
                    CommitTransaction();
                }
                catch
                {

                }
            }

            _transaction = null;
            _connection = null;
        }
    }
}
