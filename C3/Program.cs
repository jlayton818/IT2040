using System;
using System.Collections.Generic;

namespace C3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doCalculation = true;
            //Ask the user to enter their first and last name
            Console.WriteLine("Please enter your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string lastName = Console.ReadLine();
            //Print a welcome message: "Hello [first name] [last name] Welcome to the Grade Converter!"
            Console.WriteLine($"Hello {firstName} {lastName} Welcome to the Grade Converter");
            //Prompt the user to enter the number of grades they need to convert "Enter the number of grades you need to convert: "

            while(doCalculation == true)
            {
                //gets the value of the amount of grades entered for the first for loop
                int userInput;

                while (true)
                {
                    try
                    {

                        Console.WriteLine("Enter the number of grades you need to convert:");
                        userInput = int.Parse(Console.ReadLine());

                    if (userInput < 1000000000)
                        {
                        //Console.WriteLine("Good input");
                        break;
                        }
                        Console.WriteLine("too big");
                    }
                    catch{
                        Console.WriteLine("Please enter a number");
                    }
                }

                //placeholder value for all new data coming in 
                float userValue;


                List<float> numbers = new List<float>();
                //get user input for the grades
                for(int value = 0; value < userInput; value ++){
                    userValue = getNumber();
                    numbers.Add(userValue);
                }

                // convert the grades so that it displays a score of x is an "A"
                //sort and reverse makes the highest grade go to the top and the lowest at the bottom
                numbers.Sort();
                numbers.Reverse();
                userValue = Convert(numbers);
                
            //     Prompt the user to enter the grades. The grades should be stored in a list and you should use the appropriate data type for the grades. Grades can be whole numbers like 77, or have a decimal, like 77.3. Note: Your program should not crash because of bad input.

            
                Console.WriteLine("Grade Statistics");
                Console.WriteLine("--------------------");
                Console.WriteLine($"Number of grades = {numbers.Count}");
                //gets the sum of the list
                float a = 0;
                foreach (float n in numbers)
                    {
                        a += n;
                    }
                //calculates the average from the sum from the foreach loop divided by the amount of grades inputted
                float average = a / userInput;

                if (average <= 100 && average >= 90)
                {
                    Console.WriteLine($"Average Grade : {average}, which is an A");
                }  
                if (average <= 89.9 && average>= 80)
                {
                    Console.WriteLine($"Average Grade : {average}, which is a B");
                }
                if (average <= 79.9 && average >= 70)
                {
                    Console.WriteLine($"Average Grade : {average}, which is a C");
                }
                if (average <= 69.9 && average >= 60)
                {
                    Console.WriteLine($"Average Grade : {average}, which is a D");
                }
                if (average < 60)
                {
                    Console.WriteLine($"Average Grade : {average}, which is a F");
                }
        
                //Ask the user if they have more grades to convert. If they don't have more grades to convert you should end the program. 
                //If they do have more grades to convert you should run the program again.
                Console.WriteLine("Do you want to convert more grades (y/n): ");
                string anotherCalculation = Console.ReadLine();
                if (anotherCalculation != "y")
                {
                    doCalculation = false;
                }
            }
         }
         static float getNumber()
         {
            while(true)
            {
                try
                {
                    //prompt user for value
                    Console.WriteLine("Please enter an number: ");
                    
                    //get value from the console and convert to integer type
                    float userValue = float.Parse(Console.ReadLine());

                    if (userValue >= 0 && userValue <= 100)
                    {
                        //Console.WriteLine("Valid Number entered");
                        return userValue;
                    }
                    Console.WriteLine("Please enter a valid number between 0 and 100");
                    
                    }
                catch(Exception)
                {
                    Console.WriteLine("Please enter a number betwenn 0 and 100");
                }
            }
        }  
        //convert function takes a list of numbers and converts them to their letter grade
         static float Convert(List<float> numbers)
         {  
            foreach (float a in numbers)
            {
                if (a <= 100 && a >= 90)
                {
                    Console.WriteLine($"A score of {a} is an A");
                }  
                if (a <= 89.9 && a >= 80)
                {
                    Console.WriteLine($"A score of {a} is a B");
                }
                if (a <= 79.9 && a>= 70)
                {
                    Console.WriteLine($"A score of {a} is a C");
                }
                if (a <= 69.9 && a >= 60)
                {
                    Console.WriteLine($"A score of {a} is an D");
                }
                if (a < 60)
                {
                    Console.WriteLine($"A score of {a} is an F");
                }
            }  
            return 0.0f;
         }
    }
}