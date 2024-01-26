using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    public class SequentialLogicFactory : IAnimalFactory
    {
        public static int i = 0;
        public SequentialLogicFactory()
        {
            i++;
        }
        public IAnimal CreateAnimal()
        {
            if (i % 3 == 0)
                return new Cat();
            else if (i % 3 == 1)
                return new Dog();
            else
                return new Duck();
        }
    }
}
