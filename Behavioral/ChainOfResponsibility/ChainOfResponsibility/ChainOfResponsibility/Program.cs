using ChainOfResponsibility.Middlewares;
using ChainOfResponsibility.Servers;
using System;

namespace ChainOfResponsibility
{
    internal class Program
    {
        private static Server _server;
        static void Init()
        {
            _server = new Server();
            _server.Registrar("admin@localhost.com", "SenhaAdmin123");
            _server.Registrar("usuario@localhost.com", "SenhaUsuario123");
            _server.Registrar("usuario2@localhost.com", "123");

            Middleware middleware = new VerificaNivelSenhaMiddleware();
            middleware.ConectarCom(new VerificarUsuarioMiddleware(_server));
            middleware.ConectarCom(new VerificarPermissaoMiddleware());

            _server.SetarMiddleware(middleware);
        }

        static void Main(string[] args)
        {
            Init();

            bool pronto = false;

            do
            {
                Console.WriteLine("Informe seu e-mail:");
                string email = Console.ReadLine();

                Console.WriteLine("Informe sua senha:");
                string senha = Console.ReadLine();

                pronto = _server.Login(email, senha);

            } while (!pronto);

            Console.ReadLine();
        }
    }
}
