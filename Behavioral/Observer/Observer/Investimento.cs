using System;
using System.Collections.Generic;

namespace ObserverBehavioralPattern
{
    // Subject
    // Esta classe abstrata representa o Subject e possui uma lista de observadores
    // Toda vez que o estado desta classe muda, a lista de observadores (subscribers) serão notificados
    public abstract class Investimento
    {
        private decimal _valor;
        private readonly List<IObservador> _observadores = new List<IObservador>();

        public string Simbolo { get;  }

        // Toda vez que for alterado o estado, os subscribers serão notificados
        // Ou seja, aqui cada vez que setar o valor e este valor for diferente do valor anterior, irá notificar os subscribers (Assinantes)
        public decimal Valor
        {
            get => _valor;
            set
            {
                if (_valor == value) return;

                _valor = value;
                Notificar();
            }
        }

        protected Investimento(string simbolo, decimal valor)
        {
            Simbolo = simbolo;
            _valor = valor;
        }

        // Este método recebe um observador e o adiciona a lista de assinantes
        public void Subscribe(IObservador observador)
        {
            _observadores.Add(observador);
            Console.WriteLine($"Notificação que {observador.Nome} está recebendo as atualizações de {Simbolo}");
        }

        // Este método irá remover um observador da lista de assinantes
        public void Unsubscribe(IObservador observador)
        {
            _observadores.Remove(observador);
            Console.WriteLine($"Notificação que {observador.Nome} Não está recebendo as atualizações de {Simbolo}");
        }

        // Toda vez que eu chamo este metodo, ele chama o metodo Notificar de cada um dos assinantes pra dar o feedback
        private void Notificar()
        {
            foreach(var investidor in _observadores)
            {
                investidor.Notificar(this);
            }

            Console.WriteLine("");
        }
    }
}
