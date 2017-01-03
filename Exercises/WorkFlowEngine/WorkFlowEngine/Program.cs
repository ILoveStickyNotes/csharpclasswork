using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = new SendString("Sup");
            var b = new SendString("Suasdasdp");
            var c = new SendString("Suasdasdaa22aaaaaap");
            var d = new SendString("Su123123p");
            var wfe = new WorkFlowEngine(a,b,c,d);
            wfe.Run();
        }
    }
}
