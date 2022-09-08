namespace Adapter
{
    public class PayonnerAdapter : IPayPalPayment
    {
        private Payonner _payonner;

        public PayonnerAdapter(Payonner payonner)
        {
            _payonner = payonner;
        }

        public Token AuthToken()
        {
            return _payonner.AuthToken();
        }

        public void PayPalPayment()
        {
            _payonner.SendPayment();
        }

        public void PayPalReceive()
        {
            _payonner.ReceivePayment();
        }
    }
}
