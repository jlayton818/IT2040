using System;

namespace ObjectPositionCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print welcome message
            Console.WriteLine("This program calculates an object's final position");
            bool doCalculation = true;
            //main program loop
            while (doCalculation)
            {
                while (true)
                {
                    try
                    {
                    Console.WriteLine("What is the intial velocity");
                    float initial = float.Parse(Console.ReadLine());
                    break;
                    }
                    catch(Exception err)
                    {
                        Console.WriteLine("The value you entered is invalid.");
                        Console.WriteLine($"Error: {err.GetType().Name}");
                    }
                }
                //Ask user for initial position
                
                //Ask user for acceleration
                Console.WriteLine("What is the acceleration");
                float acceleration = float.Parse(Console.ReadLine());
                //Ask user for elapsed time
                Console.WriteLine("What is the elapsed time");
                float time = float.Parse(Console.ReadLine());
                //Console.WriteLine(initial * acceleration);
                //Ask user for velocity
                Console.WriteLine("What is the velocity");
                float velocity = float.Parse(Console.ReadLine());
                //Calculate final position
                //output results
                //ask user if they want to continue or exit
                Console.WriteLine("Do you wnat to perform another calculation? (y/n): ");
                string anotherCalculation = Console.ReadLine();
                if (anotherCalculation != "y")
                {
                    doCalculation = false;
                }
            }
           
        }
    }
}
