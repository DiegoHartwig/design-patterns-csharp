using Builder.Builders;
using Builder.Components;

namespace Builder.Directors
{
    public class Director
    {
        IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void ConstruirCarroSedan()
        {
            _builder.SetarTipoVeiculo(TipoVeiculo.SEDAN);
            _builder.SetarMotor(new Motor(2000));
            _builder.SetarLugares(4);
            _builder.SetarTransmissao(Transmissao.MANUAL);
        }

        public void ConstruirSuv()
        {
            _builder.SetarTipoVeiculo(TipoVeiculo.SUV);
            _builder.SetarMotor(new Motor(2200));
            _builder.SetarLugares(5);
            _builder.SetarTransmissao(Transmissao.AUTOMATICA);
            _builder.SetarAirBag(AirBag.AIRBAGDUPLOLATERAL);
        }

        public void ConstruirCaminhao()
        {
            _builder.SetarTipoVeiculo(TipoVeiculo.CAMINHAO);
            _builder.SetarMotor(new Motor(4000));
            _builder.SetarLugares(2);
            _builder.SetarTransmissao(Transmissao.MANUAL);
        }
    }
}
