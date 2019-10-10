using System;

namespace humans_and_animals
{
    class Animal
    {
        public bool canEatMeat = false;
        public bool canEatHerbs = false;

        public int hunger = 0;

        public virtual int HasToEat(int foodType)
        {
            return foodType;
        }

    }

    class Elephant : Animal
    {

        public Elephant()
        {
            canEatHerbs = true;
        }
        public override int HasToEat(int foodType)
        {
            if (hunger <= 10)
            {
                foodType = Eat(foodType);
                return foodType;
            }
            else
            {
                Console.WriteLine("The Elephant did not need to eat");
                hunger--;
                return foodType;
            }
        }

        private int Eat(int foodType)
        {
            hunger++;
            foodType--;
            Console.WriteLine("The Elephant ate!");

            return foodType;

        }
    }
    class Giraffe : Animal
    {
        public Giraffe()
        {
            canEatHerbs = true;
        }
        public override int HasToEat(int foodType)
        {
            if (hunger <= 7)
            {
                foodType = Eat(foodType);
                return foodType;
            }
            else
            {
                Console.WriteLine("The Giraffe did not need to eat");
                hunger--;
                return foodType;
            }
        }

        private int Eat(int foodType)
        {
            hunger++;
            foodType--;
            Console.WriteLine("The Giraffe ate!");
            return foodType;
        }
    }
    class Wolf : Animal
    {
        public Wolf()
        {
            canEatMeat = true;
        }
        public override int HasToEat(int foodType)
        {
            if (hunger <= 15)
            {
                foodType = Eat(foodType);
                return foodType;
            }
            else
            {
                Console.WriteLine("The Wolf did not need to eat");
                hunger--;
                return foodType;
            }
        }

        private int Eat(int foodType)
        {
            hunger++;
            foodType--;
            Console.WriteLine("The Wolf ate!");
            return foodType;
        }
    }
    class Seal : Animal
    {
        public Seal()
        {
            canEatMeat = true;
        }
        public override int HasToEat(int foodType)
        {
            if (hunger <= 13)
            {
                foodType = Eat(foodType);
                return foodType;
            }
            else
            {
                Console.WriteLine("The Seal did not need to eat");
                hunger--;
                return foodType;
            }
        }

        private int Eat(int foodType)
        {
            hunger++;
            foodType--;
            Console.WriteLine("The Seal ate!");
            return foodType;
        }
    }
    class Bear : Animal
    {
        public Bear()
        {
            canEatHerbs = true;
            canEatMeat = true;
        }
        public override int HasToEat(int foodType)
        {
            if (hunger <= 3)
            {
                foodType = Eat(foodType);
                return foodType;
            }
            else
            {
                Console.WriteLine("The Bear did not need to eat");
                hunger--;
                return foodType;
            }
        }

        private int Eat(int foodType)
        {
            hunger++;
            foodType--;
            Console.WriteLine("The Bear ate!");
            return foodType;
        }
    }

}
