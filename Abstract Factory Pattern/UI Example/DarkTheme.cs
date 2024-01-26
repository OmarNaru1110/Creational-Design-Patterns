using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    public class DarkTheme : ITheme
    {
        public string GetTheme() => "Dark";
    }
}
