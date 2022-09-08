using Builder.Components;

namespace Builder.Products
{
    public class Veiculo
    {
        public TipoVeiculo TipoVeiculo { get; set; }
        public int Lugares { get; set; }
        public Motor Motor { get; set; }
        public Transmissao Transmissao { get; set; }
        public AirBag AirBag { get; set; }
    }
}
