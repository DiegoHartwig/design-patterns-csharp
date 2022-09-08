using AbstractFactory.Aeronave;
using AbstractFactory.Factories;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.App
{
    public class Aplicacao
    {
        private IAeronave _aeronave;
        private IVeiculoTerrestre _veiculoTerrestre;

        public Aplicacao(ITransporteFactory fabrica)
        {
           _aeronave =  fabrica.CriarAeronaveTransporte();
           _veiculoTerrestre = fabrica.CriarVeiculoTerrestre();
        }

        public void IniciarRota()
        {
            _veiculoTerrestre.IniciarRota();
            _aeronave.IniciarRota();
        }
    }
}
