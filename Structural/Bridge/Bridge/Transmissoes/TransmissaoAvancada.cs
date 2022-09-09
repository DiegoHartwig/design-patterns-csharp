using Bridge.Plataformas;
using System;

namespace Bridge.Transmissoes
{
    public class TransmissaoAvancada : TransmissaoAoVivo
    {
        public TransmissaoAvancada(IPlataforma plataforma) : base(plataforma)
        {

        }

        public void Legendas()
        {
            Console.WriteLine("Legendas ativadas");
        }

        public void Comentarios()
        {
            Console.WriteLine("Comentários ativados");
        }
    }
}
