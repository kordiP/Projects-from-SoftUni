using TransportPrice.Controllers;

namespace TransportPrice
{
    internal class Program
    {
        static void Main()
        {
            Controller controller = new Controller();
            controller.Start();
        }
    }
}