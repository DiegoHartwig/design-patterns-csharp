namespace StrategyBehavioralPattern
{
    public class ICMS : ITipoImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
              
    }
}
