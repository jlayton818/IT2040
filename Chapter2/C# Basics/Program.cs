using System;

namespace C__Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte sample1 = 0x3a;
            byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            const float acceleration = 9.800;
            float mass = 14.6;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            const char integral = \u222B;
            



/*             Declare a constant of type byte named sample1 with an initial value of 0x3A

Declare a variable of type byte named sample2 with an initial value of 58

Declare a variable of type int named heartRate with an initial value of 85

Declare a variable of type double named deposits that has an initial value of 135002796

Declare a constant float named acceleration that has an initial value of 9.800

Declare a variable float named mass that has an initial value of 14.6

Declare a variable double named distance that has an initial value of 129.763001

Declare a variable bool named lost that has an initial value of true

Declare a variable bool named expensive that has an initial value of true

Declare a variable int named choice with an initial value of 2

Declare a constant of type char named integral that has a value of \u222B

Create a constant String named greeting that has an initial value of “Hello”

Create a variable String named name that has an initial value of “Karen”

Using the constants and variables declared and initialized based on the above, do the following. Where is says “display” it means output a line to standard out. Each displayed item is to be on a separate line.

Compare sample1 to sample2 and if they are equal display “The samples are equal.” otherwise display “The samples are not equal.”

If heartRate is greater than equal to 40 and less than equal to 80 display “Heart rate is normal.” otherwise display “Heart rate is not normal.”

If deposits is greater than or equal to 100000000 display “You are exceedingly wealthy.” otherwise display “Sorry you are so poor.”

Declare a variable called force that is assigned to the mass times the acceleration. The force variable must be of the same type as the type that results from the multiplication of mass and acceleration.

Display the calculated force preceded by the string “force = ”. The output should look like the following (actual value will be different): force = 2.345

Display the value of distance followed by “ is the distance.”

Using lost and expensive display “I am really sorry! I will get the manager.” if lost and expensive are both true and “Here is coupon for 10% off.” if lost is true and expensive is false.

Use switch/case and the variable choice to display “You chose 1.” if choice is 1, “You chose 2.” if choice is 2, “You chose 3.” if choice is 3, and “You made an unknown choice.” if choice is something other than 1, 2, or 3.

Using the char constant integral, display the character in integral followed by the string “ is an integral.”

Using a “for” loop count from 5 to 10 (inclusive of start and end) using an int variable i. Inside the loop display each value of i with a line that is “i = ” followed by the value of i as in:

i = 5
i = 6
i = 7
i = 8
i = 9
i = 10

Declare an int variable age with an initial value of 0. Using a “while” loop that continues while age is less than 6 display the value of age in a line that begins with “age = ” and is followed by the value of age. (Example: age = 3) After the age line is displayed increment the value of age by 1.

Display a line that contains the greeting String followed by a space followed by the name String. */
            Console.WriteLine("Hello World!");
        }
    }
}
