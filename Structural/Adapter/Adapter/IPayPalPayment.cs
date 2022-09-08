namespace Adapter
{
    public interface IPayPalPayment
    {
        Token AuthToken();
        void PayPalPayment();
        void PayPalReceive();
    }
}
