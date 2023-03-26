using EcommAPI.DoonKartModel;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;
using System.Data.Common;

namespace EcommAPI.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private DoonCartContext _repoContext;

        public UnitOfWork(DoonCartContext repoContext, bool beginTrans) : this(repoContext)
        {
            _beginTrans = beginTrans;
        }

        public UnitOfWork()
            : this(new DoonCartContext()) { }

        public UnitOfWork(DoonCartContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        #region Transaction

        public void SaveChanges()
        {
            _repoContext.SaveChanges();
        }

        private bool _beginTrans;
        public void BeginTransaction()
        {
            if (!_beginTrans)
            { 
                _repoContext.Database.BeginTransaction();
                _beginTrans = true;
            }
            else
            {
                _repoContext.Database.RollbackTransaction();
                _repoContext.Database.BeginTransaction();
                _beginTrans = true;
            }
        }

        public void CommitTransaction()
        {
            if (_beginTrans)
            {
                _repoContext.Database.CommitTransaction();
                _beginTrans = false;
            }
        }

        public void RollbackTransaction()
        {
            if (_beginTrans)
            {
                _repoContext.Database.RollbackTransaction();
                _beginTrans = false;
            }
        }

        public void CreateSavepoint(string name)
        {
            _repoContext.Database.CurrentTransaction.CreateSavepoint(name);
        }

        public void RollbackToSavepoint(string name)
        {
            _repoContext.Database.CurrentTransaction.RollbackToSavepoint(name);
        }

        public DbConnection GetConnection()
        {
            return _repoContext.Database.GetDbConnection();
            //return _repoContext.Database.CurrentTransaction?.GetDbTransaction().Connection;
        }

        public DbTransaction GetTransaction()
        {
            //return _repoContext.Database.CurrentTransaction;
            return _repoContext.Database.CurrentTransaction.GetDbTransaction();
        }

        private string GetConnectionString()
        {
            return _repoContext.Database.GetDbConnection().ConnectionString;
        }

        #endregion
    }
}