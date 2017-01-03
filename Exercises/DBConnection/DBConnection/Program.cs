using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sql = new SqlConnection("192.168.0.1");
            var oracle = new OracleConnection("192.168.0.1");
            var command = new DbCommand(sql,"Kys");
            var command2 = new DbCommand(oracle,"WOW");

            command.Execute();
            command2.Execute();
        }
    }
}

