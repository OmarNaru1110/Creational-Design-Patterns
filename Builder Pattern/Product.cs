using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class Product
    {
        private List<string> Parts { get; set; } = new List<string>();
        public void Add(string part)
        {
            Parts.Add(part);
        }
        public void ShowProduct()
        {
            foreach (var part in Parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
