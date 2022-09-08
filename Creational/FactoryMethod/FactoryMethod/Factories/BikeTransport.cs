using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    public class BikeTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Bike();
        }
    }
}
