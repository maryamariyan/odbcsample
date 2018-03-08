using System;
using System.Data.Odbc;

namespace test
{
    public abstract class IntegrationTestBase : IDisposable
    {
        protected readonly OdbcConnection connection;
        protected readonly OdbcTransaction transaction;
        protected readonly OdbcCommand command;

        public IntegrationTestBase()
        {
            connection = new OdbcConnection(ConnectionStringsUnix.WorkingConnection);
            connection.Open();
            transaction = connection.BeginTransaction();
            command = connection.CreateCommand();
            command.Transaction = transaction;
        }

        public void Dispose()
        {
            command.Dispose();
            transaction.Dispose();
            connection.Dispose();
        }
    }
}
