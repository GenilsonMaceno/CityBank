using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentBackTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            var Genilson = new contacorrete(212154,45454);

            Console.WriteLine("Conta Agencia: " + Genilson.Agencia);
            Console.WriteLine("Conta conta: " + Genilson.Conta );

            Console.ReadLine();
        }
    }
}
