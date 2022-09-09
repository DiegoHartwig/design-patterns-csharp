using System;

namespace Bridge.Plataformas
{
    public class PlataformaTwitchTv : IPlataforma
    {
        public PlataformaTwitchTv()
        {
            ConfigurarRMTP();
            Console.WriteLine("Plataforma do TwitchTv: Transmissão iniciada");
        }
        public void Autenticacao()
        {
            Console.WriteLine("Plataforma do TwitchTv: Aplicação autorizada");
        }

        public void ConfigurarRMTP()
        {
            Autenticacao();
            Console.WriteLine("Plataforma do TwitchTv: Configurando servidor RMTP");
        }
    }
}
