using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public (List<int>, List<string>) analyseText(string input)
        {
            //List of integers to hold the five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for (int i = 0; i < 5; i++)
            {
                values.Add(0);
            }

            string[] vowels = new string[] {"a", "e", "i", "o", "u"};
            string[] consonants = new string[] {"b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z"};
            int letterCount = 0;
            List<string> longWords = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                //1) Sentences - a full stop likely indicates the end of a sentence
                if (input[i].ToString() == ".")
                {
                    values[0]++;
                    if (letterCount > 7)
                    {
                        longWords.Add(input.Substring(i - letterCount, letterCount));
                    }
                    letterCount = 0;
                }
                //2) Vowels - check if current char is a vowel
                else if (Array.IndexOf(vowels, input[i].ToString().ToLower()) > -1)
                {
                    letterCount++;
                    values[1]++;
                    //4) Upper case - if the lower case of the current char is in the "vowels" list but the char itself is not, then it must be upper case
                    if (!(Array.IndexOf(vowels, input[i].ToString()) > -1))
                    {
                        values[3]++;
                    }
                    //5) Lower case
                    else
                    {
                        values[4]++;
                    }
                }
                //3) Consonants - check if current char is a consonant
                else if (Array.IndexOf(consonants, input[i].ToString().ToLower()) > -1)
                {
                    letterCount++;
                    values[2]++;
                    //4) Upper case - if the lower case of the current char is in the "consonants" list but the char itself is not, then it must be upper case
                    if (!(Array.IndexOf(consonants, input[i].ToString()) > -1))
                    {
                        values[3]++;
                    }
                    //5) Lower case
                    else
                    {
                        values[4]++;
                    }
                }
                //An apostrophe does not signify the end of a word
                else if (input[i].ToString() == "'") letterCount++;
                //If the end of a word has been reached and the word has more than 7 letters, add it to the list of long words
                else
                {
                    if (letterCount > 7)
                    {
                        longWords.Add(input.Substring(i - letterCount, letterCount));
                    }
                    letterCount = 0;
                }
            }
            return (values, longWords);
        }
    }
}
