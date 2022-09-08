using AbstractFactory.LandVehicles;
using System;

namespace AbstractFactory.VeiculoTerrestre
{
    public class Moto : IVeiculoTerrestre
    {
        public void BuscarPassageiro()
        {
            Console.WriteLine("Pegando encomenda");
        }

        public void IniciarRota()
        {
            BuscarPassageiro();
            Console.WriteLine("Iniciando o trajeto com a encomenda");
        }
    }
}
