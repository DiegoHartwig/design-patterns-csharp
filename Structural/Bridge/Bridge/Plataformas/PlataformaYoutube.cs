using System;

namespace Bridge.Plataformas
{
    public class PlataformaYoutube : IPlataforma
    {
        public PlataformaYoutube()
        {
            ConfigurarRMTP();
            Console.WriteLine("Plataforma do Youtube: Transmissão iniciada");
        }
        public void Autenticacao()
        {
            Console.WriteLine("Plataforma do Youtube: Aplicação autorizada");
        }

        public void ConfigurarRMTP()
        {
            Autenticacao();
            Console.WriteLine("Plataforma do Youtube: Configurando servidor RMTP");
        }
    }
}
