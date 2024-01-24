namespace Singleton_Pattern
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Task.Factory.StartNew(() =>
            {
                Logger.AddMessage("first");
                Console.WriteLine(Logger.GetLogger().ToString());
            });
            Task.Factory.StartNew(() =>
            {
                Logger.AddMessage("second");
                Console.WriteLine(Logger.GetLogger().ToString());
            });
            Task.Factory.StartNew(() =>
            {
                Logger.AddMessage("third");
                Console.WriteLine(Logger.GetLogger().ToString());
            });

            Console.ReadKey();
        }
    }
}
