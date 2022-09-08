using AbstractFactory.Aeronave;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    public interface ITransporteFactory
    {
        IAeronave CriarAeronaveTransporte();
        IVeiculoTerrestre CriarVeiculoTerrestre();
    }
}
