using System.Net.Http.Headers;

namespace Abstract_Factory_Pattern
{
    internal class Program
    {
        /*
        it's typically the same as Factory Method pattern, it contains 
        multiple methods in the same factory that behaves differently

        Definition: 
                   the abstract factory pattern provides an interface for creating 
                   families of related OR DEPENDANT objects without specifying 
                   their concrete classes.

        I'll demonstrate that in following example
           | Theme User Interface |
           let's say u have a web application, and you want the users 
           to have theme button that when they click it, it switched between
           light theme and dark theme,
           so here in the factory method, how whould we do that?
           we will have an IFactory interface and 
           we will have 2 concrete factories (light theme factory, dark theme factory)
           that implements IFactory interface,
           now let's say we have so many themes in our web app,
           do we have to create so many concrete factories to implement those themes?
           OFC NO, we can just add some methods for each theme instead of filling the
           app with concrete factory classes
        
        */
        static void Main(string[] args)
        {
            #region UI Ex
            IThemeFactory themeFactory = new ThemeFactory();
            Console.WriteLine("Press 1 for light theme, 2 for dark theme");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    var light = themeFactory.GetLightTheme();
                    Console.WriteLine(light.GetTheme());
                    break;
                case 2:
                    var dark = themeFactory.GetDarkTheme();
                    Console.WriteLine(dark.GetTheme());
                    break;
            }
            #endregion
        }
    }
}
