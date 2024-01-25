using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class CarBuilder:IVeichleBuilder
    {
        private Product Product { get; set; }
        public void AddBody(string body)
        {
            Product.Add(body);
        }
        public void AddLights(string lights)
        {
            Product.Add(lights);
        }
        public void AddWheels(string wheels)
        {
            Product.Add(wheels);
        }
        public void StartCreating()
        {
            Product = new Product();
        }
        public Product GetProduct() => Product;
    }
}
