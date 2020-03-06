using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaTestBD
{
    class Program
    {
        static void Main(string[] args)
        {
            var con = ConexionBD.GetConnection();
            Console.WriteLine(con);
            Console.Read();
        }
    }
}
