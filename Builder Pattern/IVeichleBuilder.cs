using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public interface IVeichleBuilder
    {
        public Product GetProduct();
        void StartCreating();
        void AddBody(string body);
        void AddWheels(string wheels);
        void AddLights(string lights);
    }
}
