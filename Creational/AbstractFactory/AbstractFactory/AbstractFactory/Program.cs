using AbstractFactory.App;
using AbstractFactory.Factories;
using System;

namespace AbstractFactory
{
    public class Program
    {
        static Aplicacao ConfigurarAplicacao()
        {
            Aplicacao aplicacao;

            ITransporteFactory transporteFactory;
            string companhia = "NoventaENove";

            if(companhia == "Uber")
            {
                transporteFactory = new UberTransporte();
            }
            else
            {
                transporteFactory = new NoventaENoveTransporte();
            }

            aplicacao = new Aplicacao(transporteFactory);

            return aplicacao;
        }
        static void Main(string[] args)
        {
            Aplicacao app = ConfigurarAplicacao();
            app.IniciarRota();
            Console.ReadLine();

        }
    }
}
