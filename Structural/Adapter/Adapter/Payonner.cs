using System;

namespace Adapter
{
    public class Payonner : IPayonnerPayment
    {
        private Token _token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePayment()
        {
            Console.WriteLine("Recebendo pagamento com Payonner");
        }

        public void SendPayment()
        {
            _token = AuthToken();
            Console.WriteLine("Efetuando pagamento com Payonner");
        }
    }
}
