using Builder.Builders;
using Builder.Directors;
using Builder.Products;
using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VeiculoBuilder builder = new VeiculoBuilder();
            Director director = new Director(builder);

            director.ConstruirCarroSedan();

            Veiculo sedan = builder.BuscarVeiculo();

            Console.WriteLine($"Criando veiculo do tipo: {sedan.TipoVeiculo}");

            director.ConstruirSuv();

            Veiculo suv = builder.BuscarVeiculo();

            Console.WriteLine($"Criando veiculo do tipo: {suv.TipoVeiculo}");

            director.ConstruirCaminhao();

            Veiculo caminhao = builder.BuscarVeiculo();

            Console.WriteLine($"Criando veiculo do tipo: {caminhao.TipoVeiculo}");
            Console.ReadLine();
        }
    }
}
