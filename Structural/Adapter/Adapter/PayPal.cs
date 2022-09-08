using System;

namespace Adapter
{
    public class PayPal : IPayPalPayment
    {
        private Token _token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void PayPalPayment()
        {
            _token = AuthToken();
            Console.WriteLine("Efetuando pagamento com PayPal");
        }

        public void PayPalReceive()
        {
            Console.WriteLine("Recebendo pagamento com PayPal");
        }
    }
}
