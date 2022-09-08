using System;

namespace FactoryMethod.Vehicles
{
    public class Bike : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegando encomenda de bicicleta");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando entrega de bicicleta");
        }
    }
}
