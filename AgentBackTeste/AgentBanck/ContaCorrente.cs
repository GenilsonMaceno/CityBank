using System;

namespace AgentBanck
{
    public class ContaCorrente
    {
        public int Agencia { get;}
        public int Conta { get; set; }
        public ContaCorrente(int agencia, int conta)
        {
            if(agencia < 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));

            } 
            else if (conta < 0)
            {
                throw new ArgumentException("O Argumento Conta deve ser maior que 0 ", nameof(conta));
            }


            Agencia = agencia;
            Conta = conta;
        }
    }
}