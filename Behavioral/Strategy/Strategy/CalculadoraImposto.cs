using System;

namespace StrategyBehavioralPattern
{
    public class CalculadoraImposto
    {
        public void EfetuarCalculo(Orcamento orcamento, ITipoImposto imposto)
        {
                double resultado = imposto.Calcular(orcamento);
                Console.WriteLine(resultado);      
        }
    }
}
