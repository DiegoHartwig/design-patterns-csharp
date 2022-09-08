using FactoryMethod.Factories;
using System;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transport transport = null;

            //transport = new CarTransport();

            //transport = new MotorcycleTransport();

            transport = new BikeTransport();

            if (transport != null)
                transport.StartTransport();

            Console.ReadLine();
        }
    }
}
