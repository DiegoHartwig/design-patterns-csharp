using Builder.Components;
using Builder.Products;

namespace Builder.Builders
{
    public class VeiculoBuilder : IBuilder
    {
        private Veiculo veiculo = new Veiculo();

        public Veiculo BuscarVeiculo()
        {
            Veiculo resultado = veiculo;
            Reset();
            return resultado;
        }

        public void Reset()
        {
            veiculo = new Veiculo();
        }

        public void SetarLugares(int lugares)
        {
            veiculo.Lugares = lugares;
        }

        public void SetarMotor(Motor motor)
        {
            veiculo.Motor = motor;
        }

        public void SetarTipoVeiculo(TipoVeiculo tipoVeiculo)
        {
            veiculo.TipoVeiculo = tipoVeiculo;
        }

        public void SetarTransmissao(Transmissao transmissao)
        {
            veiculo.Transmissao = transmissao;
        }

        public void SetarAirBag(AirBag airbag)
        {
            veiculo.AirBag = airbag;
        }
    }
}
