namespace StrategyBehavioralPattern
{
    public class ISS : ITipoImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        } 
    }
}
