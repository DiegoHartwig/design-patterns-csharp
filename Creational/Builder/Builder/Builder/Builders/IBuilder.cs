using Builder.Components;
using Builder.Products;

namespace Builder.Builders
{
    public interface IBuilder
    {
        void Reset();
        Veiculo BuscarVeiculo();
        void SetarLugares(int lugares);
        void SetarMotor(Motor motor);
        void SetarTransmissao(Transmissao transmissao);
        void SetarTipoVeiculo(TipoVeiculo tipoVeiculo);
        void SetarAirBag(AirBag airbag);
    }
}
