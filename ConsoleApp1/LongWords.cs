using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1903M_Assessment_1_Base_Code
{
    //ADDITIONAL class
    public class LongWords
    {
        //ADDITIONAL method
        public void outputLongWordsFile(List<string> longWords, string filePath)
        {
            if (File.Exists(filePath + @"\long_words.txt"))
            {
                File.Delete(filePath + @"\long_words.txt");
            }
            using (StreamWriter streamWriter = File.CreateText(filePath + @"\long_words.txt"))
            {
                for (int i = 0; i < longWords.Count; i++)
                {
                    streamWriter.WriteLine(longWords[i]);
                }
            }
            Console.WriteLine("Long words file created at {0}", filePath);
            }
        }
    }
