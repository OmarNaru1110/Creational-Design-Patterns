using System.Security.Principal;

namespace Builder_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IVeichleBuilder builder = new CarBuilder();
            var dir = new Director(builder);
            var product = dir.Construct();
            product.ShowProduct();
        }
    }
}
