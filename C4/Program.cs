using System;
using System.Collections.Generic;
namespace C4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = true;
            string name, letterGrade; 
            int numOfGrades;
            //float average, min, max;
            
            List<float> scores = new List<float>();

            name = getFirstLastName();

            Console.WriteLine($"Hello {name} welcome to the grade converter");

            while(shouldContinue)
            {
                numOfGrades = getNumberOfGrades();
                
                scores = addToList(numOfGrades,scores);
                
                foreach(float a in scores)
                {
                    letterGrade = numberToLetter(a);
                    
                    Console.WriteLine($"A score of {a} is a {letterGrade}");
                    
                }
                // average = averageScore(scores);

                // Console.WriteLine($"The average score is {average} which is a {numberToLetter(average)}");

                // min = getMinimum(scores);
                // max = getMaximum(scores);

                // Console.WriteLine($"The max is {max} and the min is {min}");
                printStatistics(scores);

                shouldContinue = isTrue();

                if (shouldContinue == true)
                {
                    scores.Clear();
                }

                //Console.WriteLine(shouldContinue);

            }   
        }


// Write a function that gets and returns the user's first and last name.
        static string getFirstLastName()
        {
            string userName;
            Console.WriteLine("Please enter your first and last name");
            userName = Console.ReadLine();
            return userName;
        }
// Write a function that gets and returns the number of grades the user wants to enter.
        static int getNumberOfGrades()
        {
            int num;
            while(true)
            {
                Console.WriteLine("How many grades would you like to enter?");
                try
                {
                    num = int.Parse(Console.ReadLine());
                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Error: Please enter a number value");
                }
            }
            return num;
        }
// Write a function that adds the grades the user enters to a list. The function should return a list of grades
        static List<float> addToList(int num, List<float> scores)
        {
            int j;
            for (int i = 0; i < num; i++)
            {
                while(true)
                {
                    Console.WriteLine("Please enter a grade");
                    try
                    {
                        j = int.Parse(Console.ReadLine());
                        if (j >= 0 && j <= 110)
                        {
                            scores.Add(j);
                            break;
                        }
                        Console.WriteLine("Error : Number out of range. Please enter a number between 0 and 110");
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Error: Please enter a number");
                    }
                }
            }
            scores.Sort();
            scores.Reverse();
            foreach(float a in scores)
            {
                Console.WriteLine(a);
            }
            return scores;
        }
        // Write a function that prints the letter grades and the numerical scores for the grades stored in the grades list e.g. (A score of  89.5 is a B grade)
        static string numberToLetter(float score)
        {
            //Code from the grade calculator that the professor gave to us
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        static float averageScore(List<float> scores)
        {
            float average;
            float sum = 0;
            int count = 0;

            foreach(float a in scores)
            {
                sum = a + sum;
                count ++;
            }
            average = sum / count;

            return average;
        }
        static float getMaximum(List<float> scores)
        {
            float x = 0;
            foreach(float a in scores)
            {
                //if the incoming value is bigger than 0 set the incoming value to the x value
                // goes through the whole list so every number is checked
                if (a > x)
                {
                    x = a;
                }
            }
            return x;
        }
        static float getMinimum(List<float> scores)
        {
            //set the x value to the highest number in the range that inputted
            float x = 110;
            foreach(float a in scores)
            {
                //then check the incomming values to see if the new value is less than the incoming value
                if (a < x)
                {
                    x = a;
                }
            }
            return x;
        }

        // Write a function that prints the statistics for the grades list. (number of grades, average grade, maximum grade, minimum grade)
        static float printStatistics(List<float> scores)
        {
            //do all of the calucations in this function
            //call the functions for max, min, average
            int num;
            float average, max, min;
            average = averageScore(scores);
            Console.WriteLine($"The average score is {average}");

            min = getMinimum(scores);
            Console.WriteLine($"The min score is {min}");

            max = getMaximum(scores);
            Console.WriteLine($"The max score is {max}");

            num = scores.Count;
            Console.WriteLine($"You entered {num} grades");
            
            return 0;
        }
        static bool isTrue()  
        {
            //instead of checking the bool in the main code, create a function that returns a true/false based on user input
            string more; 
            Console.WriteLine("Would you like to do another calculation? (y/n) ");
            more = Console.ReadLine();
            if (more != "y" && more != "Y")
            {
                return false;
            }
            return true;
        }  
    }
}