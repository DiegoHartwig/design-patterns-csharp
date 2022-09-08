using System;

namespace ObserverBehavioralPattern
{
    public static class ExecucaoObserver
    {
        public static void Executar()
        {
            var diego = new Observador("Diego");

            var microsoft = new AcaoBovespa("Microsoft", SimularValorAcao());
            var amazon = new AcaoBovespa("Amazon", SimularValorAcao());

            microsoft.Subscribe(diego);

            amazon.Subscribe(diego);

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");

            for (int i = 0; i < 9; i++)
            {
                microsoft.Valor = SimularValorAcao();
                amazon.Valor = SimularValorAcao();

                // Aqui somente para simular a saída da lista de assinantes
                if(i == 1)
                {
                    amazon.Unsubscribe(diego);
                }
            }

        }
        public static decimal SimularValorAcao()
        {
            var random = new Random();
            var resultado = random.Next(111122, 404050);
            return resultado / (decimal)100000.00;
        }

    }
}
