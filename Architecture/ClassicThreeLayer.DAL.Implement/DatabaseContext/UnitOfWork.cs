using ClassicThreeLayer.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Transactions;

namespace ClassicThreeLayer.DAL.Implement.DatabaseContext
{
    public class UnitOfWorkForMsSql : IUnitOfWork
    {
        private readonly TransactionScope _transactionScope;
        
        public UnitOfWorkForMsSql()
        {
            _transactionScope = new TransactionScope();

        }

        public void Commit()
        {
            _transactionScope.Complete();
        }

        public void Dispose()
        {
            _transactionScope.Dispose();
        }
    }
}
