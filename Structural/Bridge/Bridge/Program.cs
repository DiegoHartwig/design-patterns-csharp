using Bridge.Plataformas;
using Bridge.Transmissoes;
using System;

namespace Bridge
{
    internal class Program
    {
        static void IniciandoTransmissao(IPlataforma plataforma)
        {
        Console.WriteLine("Aguarde...");

            TransmissaoAoVivo transmissaoAoVivo = new(plataforma);
            transmissaoAoVivo.Broadcasting();
            transmissaoAoVivo.ResultadoTransmissao();
        }

        static void IniciandoTransmissaoAvancada(IPlataforma plataforma)
        {
            Console.WriteLine("Aguarde...");

            TransmissaoAvancada transmissaoAvancada = new(plataforma);
            transmissaoAvancada.Broadcasting();
            transmissaoAvancada.Legendas();
            transmissaoAvancada.Comentarios();
            transmissaoAvancada.ResultadoTransmissao();
        }

        static void Main(string[] args)
        {
            IniciandoTransmissao(new PlataformaYoutube());
            IniciandoTransmissao(new PlataformaFacebook());

            IniciandoTransmissaoAvancada(new PlataformaTwitchTv());
        }
    }
}
