using Bridge.Plataformas;
using System;

namespace Bridge.Transmissoes
{
    public class TransmissaoAoVivo : ITransmissao
    {
        protected IPlataforma _plataforma;
        public TransmissaoAoVivo(IPlataforma plataforma)
        {
            _plataforma = plataforma;
        }
        public void Broadcasting()
        {
            Console.WriteLine($"Iniciando a transmissão na plataforma: { _plataforma }");
        }

        public void ResultadoTransmissao()
        {
            Console.WriteLine("Transmitindo ao vivo");
        }
    }
}
