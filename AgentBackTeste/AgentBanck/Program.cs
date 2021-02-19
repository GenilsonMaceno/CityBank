using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentBanck
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new ContaCorrente(417,123456);

            Console.WriteLine("Agencia " + conta.Agencia);
            Console.WriteLine("Conta " + conta.Conta);

            Console.ReadLine();
        }
    }
}
