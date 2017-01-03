using System;

namespace DBConnection
{
    public class OracleConnection : DbConnection
    {

        public OracleConnection(string ip)
            : base(ip)
        {

        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle: Closing Connection");
        }
        public override void OpenConnection()
        {
            Console.WriteLine("Oracle: Opening Connection");
        }
    }
}