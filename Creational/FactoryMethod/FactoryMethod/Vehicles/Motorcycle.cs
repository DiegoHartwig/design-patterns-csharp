using System;

namespace FactoryMethod.Vehicles
{
    public class Motorcycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegando encomenda");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando entrega");
        }
    }
}
