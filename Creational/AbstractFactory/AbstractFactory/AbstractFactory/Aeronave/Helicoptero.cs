using System;

namespace AbstractFactory.Aeronave
{
    public class Helicoptero : IAeronave
    {
        public void VerificarVento()
        {
            Console.WriteLine("Verificando vento");
        }

        public void BuscarPassageiro()
        {
            Console.WriteLine("Passageiros a bordo, ligando hélices");
        }

        public void IniciarRota()
        {
            VerificarVento();
            BuscarPassageiro();

            Console.WriteLine("Iniciando a decolagem");
        }
    }
}
