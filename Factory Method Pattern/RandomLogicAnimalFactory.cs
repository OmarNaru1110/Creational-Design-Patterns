using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    public class RandomLogicAnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 30);
            if (randomNumber <= 10)
                return new Cat();
            else if (randomNumber <= 20)
                return new Dog();
            else
                return new Duck();
        }
    }
}
