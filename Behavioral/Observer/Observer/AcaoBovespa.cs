namespace ObserverBehavioralPattern
{
    // Concrete Subject
    public class AcaoBovespa : Investimento
    {
        public AcaoBovespa(string simbolo, decimal preco)
            : base(simbolo, preco)
        {

        }
    }
}
