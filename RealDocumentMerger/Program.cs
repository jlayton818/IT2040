using System;
using System.IO;
using System.Collections.Generic;

namespace RealDocumentMerger
{
    class Program
    {
        static void Main(string[] args)
        {
            string combine;
            bool shoudContinue = true;
            
            while(shoudContinue)
            {
                Console.WriteLine("Document Merger \n");

                List<string> merger = new List <string>();

                merger = getFileNames(merger);
                //I thought about making this another bool value so it'd be like if true do this else do that but I didn't 
                //think that would be necessary
                if (merger.Capacity > 2)
                {  
                    combine = getCombinedFileName(merger);
                    WriteLine(merger, combine);
                }
                else
                {
                    Console.WriteLine("There is less than 2 documents entered. There is nothing to combine"); 
                }
                shoudContinue = isTrue();
            }
        }
        static string getCombinedFileName(List<string> fileName)
        {
            //fileName.Reverse();

            string userInput = "";
            string name = combineFileName(fileName);
            
            Console.WriteLine($"Enter combined file name (default: {name}). Press enter for the default file name");

            userInput = Console.ReadLine();
            //if there is no input the filename is defaulted to the default name, otherwise it goes to the check file name
            if (string.IsNullOrEmpty(userInput))
            {
                userInput = name;
            }
            userInput = checkUserFileName(userInput);

            return userInput;
        }
        static List <string> getFileNames(List<string> fileCombine)
        {
            string file = "holder";
            string fileName = "";
            string newfileName;

            while (!string.IsNullOrEmpty(file))
            {
                try
                {
                    Console.WriteLine("Please enter a text file. If you have no more files to input press the enter key");
                    fileName = Console.ReadLine();
                    newfileName = checkUserFileName(fileName);
                    //break the loop if nothing is entered
                    if (string.IsNullOrEmpty(fileName))
                    {
                        break;
                    }
                    //if it doesn't add the newfile to the list fileCombine
                    if (File.Exists(newfileName))
                    {
                        fileCombine.Add(newfileName);  
                    }
                    else
                    {
                        Console.WriteLine("the file you entered doesn't exist please enter another file name");
                        continue;
                    }     
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Exception + {e}");
                }
           }
            return fileCombine;
        }
        static string checkUserFileName(string fileName)
        {
            //same set of code that was given to us in class
            if (fileName.EndsWith(".txt"))
            {
                return fileName;
            }
            else 
            {
                return fileName + ".txt";
            }
        }
        static string removeTxtFileName(string fileName)
        {
            //removes the .txt extension so that when the default file name is given there isn't
            //any extra txt in the middle
            char[] MyChar = {'.', 't','x','t'}; 
            string newString = fileName.TrimEnd(MyChar);
            return newString;
        }
        static string combineFileName(List<string> inputFiles)
        {
            //inputFiles.Reverse();
            string combinedFiles = "";
            string updatedA = "";
            foreach (string a in inputFiles)
            {
                //goes through the list to check if the file ends with .txt, removes it and then adds it on the end
                //so the combined File name looks good
                if (a.EndsWith(".txt"))
                {
                    //Console.WriteLine(a);
                    updatedA = removeTxtFileName(a);
                    //Console.WriteLine(updatedA);
                }
                combinedFiles += updatedA ;
                //Console.WriteLine(combinedFiles);
            }
            combinedFiles = checkUserFileName(combinedFiles);
            return combinedFiles;
        }
        static void WriteLine(List<string> docName, string fileName)
        {
            string combinedData = "";
            string placeholder = "";
            int iteration = 0;
            foreach (string a in docName)
            { 
                StreamReader sr = new StreamReader(a);
                StreamWriter outputFile = File.AppendText(fileName);
                try 
                {
                    //read the data and then add it to the string that holds all of the file contents combined
                    //then reset the placeholder data so it can take more input
                    placeholder = sr.ReadToEnd();
                    combinedData += placeholder;
                    placeholder = "";
                    //originally when combining multiple documents the text from the text file would print 1, 1&2, 1,2&3, and then 1,2,3,4 on the last
                    //iteration on the loop, so I needed to figure out how to do only print the data at the last iteration of the loop
                    //so i made a counting variable and made it so when the size of the list is equal to the iteration it prints the data to the file.
                    if (iteration == docName.Count - 1)
                    {
                        outputFile.Write(combinedData);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);  
                }
                finally
                {
                    sr.Close();
                    outputFile.Close();
                }
                iteration++;
            }
            int charCount = getCharCount(combinedData);
            Console.WriteLine($"{fileName} was succesfully saved and there are {charCount} number of characters");
        }
        static int getCharCount(string fileName)
        {
            //since char is its own type it is relatively easier in my opinion to count the characters than
            //the words since we can just count them. 
            int count = 0;
            foreach(char c in fileName)
            {
                if(!char.IsWhiteSpace(c))
                {
                    count++;
                }
            }
            return count;
        }
        static bool isTrue()  
        {
            //same bool function from previous modules
            string more; 
            Console.WriteLine("Would you like to merge more files? (y/n) ");
            more = Console.ReadLine();
            if (more != "y" && more != "Y")
            {
                Console.WriteLine("\nThanks for using the file merger");
                return false;
            }
            return true;
        } 
    }
}
