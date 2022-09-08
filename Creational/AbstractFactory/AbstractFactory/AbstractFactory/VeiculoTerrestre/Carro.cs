using AbstractFactory.LandVehicles;
using System;

namespace AbstractFactory.VeiculoTerrestre
{
    public class Carro : IVeiculoTerrestre
    {
        public void BuscarPassageiro()
        {            
            Console.WriteLine("Passageiros embarcaram" );
        }

        public void IniciarRota()
        {
            BuscarPassageiro();
            Console.WriteLine("Iniciando o trajeto");
        }
    }
}
