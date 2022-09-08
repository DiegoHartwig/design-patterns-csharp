using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    public class MotorcycleTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Motorcycle();
        }
    }
}
