namespace AgentBanck
{
    public class ContaCorrente
    {
        public int Agencia { get;}
        public int Conta { get; set; }
        public ContaCorrente(int agencia, int conta)
        {
            Agencia = agencia;
            Conta = conta;
        }
    }
}