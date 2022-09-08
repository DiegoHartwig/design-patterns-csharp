using AbstractFactory.Aeronave;
using AbstractFactory.LandVehicles;
using AbstractFactory.VeiculoTerrestre;

namespace AbstractFactory.Factories
{
    public class NoventaENoveTransporte : ITransporteFactory
    {
        public IAeronave CriarAeronaveTransporte()
        {
            return new Helicoptero();
        }

        public IVeiculoTerrestre CriarVeiculoTerrestre()
        {
            return new Moto();
        }
    }
}
