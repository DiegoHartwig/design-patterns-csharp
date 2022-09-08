using System;

namespace ObserverBehavioralPattern
{
    // Concrete Observer
    public class Observador : IObservador
    {
        public string Nome {  get; }   

        public Observador(string nome)
        {
            Nome = nome;
        }

        public void Notificar(Investimento investimento)
        {
            Console.WriteLine("Notificando {0} que {1} " +
                "teve preço alterado para {2:C}", Nome, investimento.Simbolo, investimento.Valor);
        }
    }
}
