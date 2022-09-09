using ChainOfResponsibility.Middlewares;
using System;
using System.Collections.Generic;

namespace ChainOfResponsibility.Servers
{
    public class Server
    {
        private Dictionary<string, string> usuarios = new Dictionary<string, string>();

        private Middleware _middleware;

        public void SetarMiddleware(Middleware middleware)
        {
            _middleware = middleware;
        }

        public bool Login(string email, string senha)
        {
            if(_middleware.Verificar(email, senha))
            {
                Console.WriteLine("Usuário autorizado com sucesso.");
                Console.WriteLine("bem vindo");
                return true;
            }
            return false; ;
        }

        public void Registrar(string email, string senha)
        {
            usuarios[email] = senha;
        }

        public bool PossuiEmail(string email)
        {
            return usuarios.ContainsKey(email);
        }

        public bool ValidarSenha(string email, string senha)
        {
            string valor = "";
            usuarios.TryGetValue(email, out valor);

            return senha == valor;
        }
    }
}
