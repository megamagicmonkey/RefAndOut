using System;

namespace RefandOut
{
    class Program
    {
        //TODO impliment this ref method by returning a bool and subtracting from the parameter.
        //So it will have two outputs. the bool of true if health is > 0. and also set x to decrease by 1.
        //TODO Call the method in the main and make sure the method changes the number of a initialized variable and returns a bool.
        public static bool SubtractHealth(ref int x)
        {
            Console.WriteLine("The hero took damage!");
            x--;
            if (x > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //TODO create method that uses the out keyword. Call the method in the main.
        

        public static int Sum(int x, int y, out  bool even)
        {
            Console.WriteLine($"Adding {x} and {y}");
            if ((x + y) % 2 == 0)
            {
                even = true;
            }
            else
            {
                even = false;
            }

            return x + y;

        }

        public static void DisplaySum(int x, bool even)
        {
            if (even)
            {
                Console.WriteLine($"The resulting number of the last Sum() method is {x}, which is even.");
            }
            else
            {
                Console.WriteLine($"The resulting number of the last Sum() method is {x}, which is odd.");
            }
        }

        public static void HeroStatus(bool alive)
        {
            if (alive)
            {
                Console.WriteLine("The hero is still going!");
            }
            else
            {
                Console.WriteLine("The hero has fallen...");
            }
        }


        static void Main(string[] args)
        {
            int health = 1;
            bool alive = true;
            bool even;
            int sum1;
            int sum2;

            sum1 = Sum(1, 2, out even);
            DisplaySum(sum1, even);
            sum2 = Sum(2, 2, out even);
            DisplaySum(sum2, even);


            HeroStatus(alive);
            alive = SubtractHealth(ref health);
            HeroStatus(alive);
    
        }

    }
}
