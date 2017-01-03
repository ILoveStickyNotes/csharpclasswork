using System;

namespace DBConnection
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instructions;
        public DbCommand(DbConnection dbConnection, string instructions)
        {
            _dbConnection = dbConnection;
            if (string.IsNullOrWhiteSpace(instructions))
                throw new InvalidOperationException("Instructions are empty");
            _instructions = instructions;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine(_instructions);
            _dbConnection.CloseConnection();
        }

    }
}