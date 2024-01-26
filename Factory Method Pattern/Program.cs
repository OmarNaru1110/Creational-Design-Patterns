namespace Factory_Method_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            suppose in your code 
            --------
            --------
            -------- <---- at this line of code you want create an animal 
            --------       but u don't know what animal u want to do 
                           it's gonna happen based on some logic that 
                           u don't know, 
                           
            
            + what if the instantaion of the animal object needs lots of computation
              and is hard to do, using the factory method, u will decrease the redundant code
              + you will abstract the client from this complex computation
              + u acheived reusability
            */

            for (int i = 0;i< 20; i++) 
            {
                if (i % 2 == 0)
                {
                    IAnimalFactory animalFactory = new RandomLogicAnimalFactory();
                    Console.WriteLine(animalFactory.CreateAnimal().GetAnimal());
                }
                else
                {
                    IAnimalFactory animalFactory = new SequentialLogicFactory();
                    Console.WriteLine(animalFactory.CreateAnimal().GetAnimal());
                }
            }
        }
    }
}
