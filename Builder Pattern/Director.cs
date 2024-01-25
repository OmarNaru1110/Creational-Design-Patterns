using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class Director
    {
        
        public Director(IVeichleBuilder builder)
        {
            Builder = builder;
        }

        public IVeichleBuilder Builder { get; }
        public Product Construct()
        {
            Builder.StartCreating();
            Builder.AddBody("body");
            Builder.AddWheels("wheels");
            Builder.AddLights("lights");
            return Builder.GetProduct();
        }
    }
}
