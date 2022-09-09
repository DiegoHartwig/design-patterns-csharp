using ChainOfResponsibility.Servers;
using System;

namespace ChainOfResponsibility.Middlewares
{
    public class VerificaNivelSenhaMiddleware : Middleware
    {
        public override bool Verificar(string email, string senha)
        {
            if (senha.Equals("123"))
            {
                Console.WriteLine("Atenção você está utilizando uma senha fraca, considere alterar para uma mais dificil!");
                return true;
            }

            return VerificarProximo(email, senha);
        }
    }
}
