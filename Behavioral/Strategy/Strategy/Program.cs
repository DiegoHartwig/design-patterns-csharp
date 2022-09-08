using System;

namespace StrategyBehavioralPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITipoImposto iss = new ISS();
            ITipoImposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(200.0);

            CalculadoraImposto calculadora = new CalculadoraImposto();
            calculadora.EfetuarCalculo(orcamento, iss);
            Console.ReadKey();
        }
    }
}
