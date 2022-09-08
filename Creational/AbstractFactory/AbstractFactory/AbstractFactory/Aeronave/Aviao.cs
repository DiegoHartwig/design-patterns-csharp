using System;

namespace AbstractFactory.Aeronave
{
    public class Aviao : IAeronave
    {
        public void VerificarVento()
        {
            Console.WriteLine("Verificando vento");
        }

        public void BuscarPassageiro()
        {
            Console.WriteLine("Passageiros a bordo");
        }

        public void IniciarRota()
        {
            VerificarVento();
            BuscarPassageiro();
            
            Console.WriteLine("Iniciando a decolagem");
        }
    }
}
