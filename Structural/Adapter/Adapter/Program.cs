using System;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PayPal pagamento = new PayPal();
            //pagamento.PayPalPayment();
            //pagamento.PayPalReceive();

            //Payonner pagamento = new Payonner();
            //pagamento.SendPayment();
            //pagamento.ReceivePayment();

            IPayPalPayment pagamento = new PayonnerAdapter(new Payonner());
            pagamento.PayPalPayment();
            pagamento.PayPalReceive();

            Console.ReadLine();
        }
    }
}
