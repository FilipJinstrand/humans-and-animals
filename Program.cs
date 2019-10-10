using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Animal> animals = new List<Animal>();

            Elephant elephant = new Elephant();
            Giraffe giraffe = new Giraffe();
            Wolf wolf = new Wolf();
            Seal seal = new Seal();
            Bear bear = new Bear();

            animals.Add(elephant);
            animals.Add(giraffe);
            animals.Add(wolf);
            animals.Add(seal);
            animals.Add(bear);


            int nrOfMeatLeft = 50;
            int nrOfVeggiesLeft = 50;
            int day = 0;

            while (true)
            {
                day++;
                Console.WriteLine("Det är dag " + day + ":");
                Console.WriteLine("-------");

               foreach (Animal animal in animals)
               {
                   
                   if (animal.canEatHerbs && nrOfVeggiesLeft > 0)
                   {
                       nrOfVeggiesLeft = animal.HasToEat(nrOfVeggiesLeft);
                       Console.WriteLine(nrOfVeggiesLeft + " nr of herbs left");
                   }
                   else if (animal.canEatMeat && nrOfMeatLeft > 0)
                   {
                       nrOfMeatLeft = animal.HasToEat(nrOfMeatLeft);
                       Console.WriteLine(nrOfMeatLeft + " nr of meat left");
                   }
               }
                // Wait for the next day
                Console.ReadKey();
            }

        }
    }
}
