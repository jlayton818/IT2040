using System;
using System.IO;

namespace Documents
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = true;
            string file;

            while(shouldContinue)
            {
                
                Console.WriteLine("Document\n");

                file = getFileName();

                writeDataToFile(file);

                readFileContents(file);

                shouldContinue = isTrue();

            }
        }
        static string getFileName()
        {
            string fileName;
            while(true)
            {
                Console.WriteLine("Enter the name of the document");
                try 
                {
                    fileName = Console.ReadLine();
                    //check to make sure there is some input
                    if (!string.IsNullOrEmpty(fileName))
                    {
                        break;
                    }
                    Console.WriteLine("Error: you must enter a document name\n");
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
            //check if filename ends in .txt
            fileName = checkUserFileName(fileName);
            return fileName;
        }
        static string checkUserFileName(string fileName)
        {
            if (fileName.EndsWith(".txt"))
            {
                return fileName;
            }
            else 
            {
                return fileName + ".txt";
            }
        }
        static void writeDataToFile(string fileName)
        {
            string userInput;

            StreamWriter fileWriter = File.AppendText(fileName);

            Console.WriteLine("\nEnter the content to be written in the document");

            userInput = Console.ReadLine();

            //i'm not really sure how we were supposed to count words but I saw that using the split method
            //splits words after a space, but I learned that it counts the space character as a space, so if 
            // I put a double space in the file, it will count that as well. 
            //and then the length is just how many times it split (i think)
            
            int countSpaces = userInput.Split().Length;

            try
            {
                fileWriter.WriteLine(userInput);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                fileWriter.Close();
                Console.WriteLine($"\n{fileName} was successfully saved. You added {countSpaces} words to the document\n"); 
            }
        }
        static void readFileContents(string fileName)
        {
            //using code from class and a few adjustments I got the word count for the total document
            int wordCount = 0; 
            //int count = 0;
            StreamReader fileReader = new StreamReader(fileName);
            try 
            {
                while(!fileReader.EndOfStream)
                {
                    //goes through line by line and then counts the words in each line 
                    var lineOfData = fileReader.ReadLine();
                    wordCount += lineOfData.Split().Length;
                    //count++;
                    //Console.WriteLine($"Line #{count}, {wordCount}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                fileReader.Close();
                Console.WriteLine($"There are {wordCount} words in the file");
            }
        }
        static bool isTrue()  
        {
            //instead of checking the bool in the main code, create a function that returns a true/false based on user input
            //same code as the module before this
            string more; 
            Console.WriteLine("Would you like to do write another file? (y/n) ");
            more = Console.ReadLine();
            if (more != "y" && more != "Y")
            {
                Console.WriteLine("\nThanks for using the file writer");
                return false;
            }
            return true;
        }  
    }
}