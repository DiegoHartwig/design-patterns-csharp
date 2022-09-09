using System;

namespace Bridge.Plataformas
{
    public class PlataformaFacebook : IPlataforma
    {
        public PlataformaFacebook()
        {
            ConfigurarRMTP();
            Console.WriteLine("Plataforma do Facebook: Transmissão iniciada");
        }
        public void Autenticacao()
        {
            Console.WriteLine("Plataforma do Facebook: Aplicação autorizada");
        }

        public void ConfigurarRMTP()
        {
            Autenticacao();
            Console.WriteLine("Plataforma do Facebook: Configurando servidor RMTP");
        }
    }
}
