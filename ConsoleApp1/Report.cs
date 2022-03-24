using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output? --Done
        //eg.   public void outputConsole(List<int>)

        public void outputConsole(List<int> values)
        {
            Console.WriteLine("\nSentences: {0}"
                                + "\nVowels: {1}"
                                + "\nConsonants: {2}"
                                + "\nUpper case: {3}"
                                + "\nLower case: {4}"
                                , values[0], values[1], values[2], values[3], values[4]);
        }

        //ADDITIONAL method
        public void outputFile(List<int> values, List<string> longWords)
        {
            string filePath = "";
            while (true)
            {
                Console.Write("Directory to create file in: ");
                filePath = Console.ReadLine();
                try
                {
                    if (File.Exists(filePath + @"\output.txt"))
                    {
                        File.Delete(filePath + @"\output.txt");
                    }
                    using (StreamWriter streamWriter = File.CreateText(filePath + @"\output.txt"))
                    {
                        streamWriter.WriteLine("Sentences: {0}"
                                                + "\nVowels: {1}"
                                                + "\nConsonants: {2}"
                                                + "\nUpper case: {3}"
                                                + "\nLower case: {4}"
                                                , values[0], values[1], values[2], values[3], values[4]);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid directory.");
                    continue;
                }
                Console.WriteLine("Output file created at {0}", filePath);
                break;
            }

            //Generate long words text file
            if (longWords.Count != 0)
            {
                LongWords long_words = new LongWords();
                long_words.outputLongWordsFile(longWords, filePath);
            }
        }
    }
}
