using System;

namespace FactoryMethod.Vehicles
{
    public class Car : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegando passageiros");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando rota");
        }
    }
}
