using AbstractFactory.Aeronave;
using AbstractFactory.LandVehicles;
using AbstractFactory.VeiculoTerrestre;

namespace AbstractFactory.Factories
{
    public class UberTransporte : ITransporteFactory
    {
        public IAeronave CriarAeronaveTransporte()
        {
            return new Aviao();
        }

        public IVeiculoTerrestre CriarVeiculoTerrestre()
        {
            return new Carro();
        }
    }
}
