using ChainOfResponsibility.Servers;
using System;

namespace ChainOfResponsibility.Middlewares
{
    public class VerificarUsuarioMiddleware : Middleware
    {
        private Server _server;

        public VerificarUsuarioMiddleware(Server server)
        {
            _server = server;
        }

        public override bool Verificar(string email, string senha)
        {
            if (!_server.PossuiEmail(email))
            {
                Console.WriteLine("E-mail inválido");
                return false;
            }

            if (!_server.ValidarSenha(email, senha))
            {
                Console.WriteLine("E-mail e/ou senha inválidos!");
                return false;
            }

            return VerificarProximo(email, senha);
        }
    }
}
