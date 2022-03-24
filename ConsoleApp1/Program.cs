//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            Input input = new Input();
            //Get either manually entered text, or text from a file
            string text = "";
            string choice = "";
            while (true)
            {
                Console.Write("Input mode (1 for manual, 2 for file): ");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    text = input.manualTextInput();
                    if (text != "")
                    {
                        break;
                    }
                    Console.WriteLine("Invalid input.");
                }
                else if (choice == "2")
                {
                    Console.Write("Text file path: ");
                    string filePath = Console.ReadLine();
                    try
                    {
                        text = input.fileTextInput(filePath);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input.");
                        continue;
                    }
                    if (text != "")
                    {
                        break;
                    }
                    Console.WriteLine("Invalid input.");
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }

            //Create an 'Analyse' object
            Analyse analyse = new Analyse();

            //Pass the text input to the 'analyseText' method
            //Receive a list of integers back
            List<int> values = new List<int>();
            List<string> longWords = new List<string>();
            values = analyse.analyseText(text).Item1;
            longWords = analyse.analyseText(text).Item2;

            //Report the results of the analysis
            Report report = new Report();
            while (true)
            {
                Console.Write("Output mode (1 for console, 2 for file): ");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    report.outputConsole(values);
                    break;
                }
                else if (choice == "2")
                {
                    report.outputFile(values, longWords);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            Console.ReadLine();
        }
    }
}
