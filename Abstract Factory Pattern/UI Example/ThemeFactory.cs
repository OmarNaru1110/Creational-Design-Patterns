using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    public class ThemeFactory : IThemeFactory
    {
        public ITheme GetDarkTheme()
        {
            return new DarkTheme();
        }

        public ITheme GetLightTheme()
        {
            return new LightTheme();
        }
    }
}
