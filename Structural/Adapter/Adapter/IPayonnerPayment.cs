namespace Adapter
{
    public interface IPayonnerPayment
    {
        Token AuthToken();
        void SendPayment();
        void ReceivePayment();
    }
}
