using System;

namespace DBConnection
{
    public class SqlConnection : DbConnection
    {

        public SqlConnection(string ip)
            :base(ip)
        {
            
        }

        public override void CloseConnection()
        {
            Console.WriteLine("SQL: Closing Connection");
        }
        public override void OpenConnection()
        {
            Console.WriteLine("SQL: Opening Connection");
        }
    }
}