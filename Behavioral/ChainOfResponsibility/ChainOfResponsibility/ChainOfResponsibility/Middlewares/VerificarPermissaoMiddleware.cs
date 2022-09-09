using System;

namespace ChainOfResponsibility.Middlewares
{
    public class VerificarPermissaoMiddleware : Middleware
    {
        public override bool Verificar(string email, string senha)
        {
            if (email.Equals("admin@localhost.com"))
            {
                Console.WriteLine("Bem Vindo Administrador");
                return true;
            }

            Console.WriteLine("Bem Vindo");
            return VerificarProximo(email, senha);
        }
    }
}
