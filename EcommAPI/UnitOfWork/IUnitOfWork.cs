using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace EcommAPI.UnitOfWork
{
    public interface IUnitOfWork 
    {
        #region Transaction

        void SaveChanges();
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        void CreateSavepoint(string name);
        void RollbackToSavepoint(string name);
        DbConnection GetConnection();
        DbTransaction GetTransaction();

        #endregion
    }
}