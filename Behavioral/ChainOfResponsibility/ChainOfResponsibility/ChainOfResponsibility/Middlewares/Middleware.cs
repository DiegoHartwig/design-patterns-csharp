namespace ChainOfResponsibility.Middlewares
{
    public abstract class Middleware
    {
        private Middleware _proximo;

        public Middleware ConectarCom(Middleware proximo)
        {
            _proximo = proximo;

            return _proximo;
        }

        public abstract bool Verificar(string email, string senha);

        protected bool VerificarProximo(string email, string senha)
        {
            if(_proximo == null)
            {
                return true;
            }

            return _proximo.Verificar(email, senha);
        }
    }
}
