using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    // ADDITIONAL class
    public class Test
    {
        string testText = "Object Oriented programming is a programming paradigm that relies on the concept of classes and objects. A class is an abstract blueprint used to create more specific, concrete objects. Classes often represent broad categories, like Car or Dog that share attributes. These classes define what attributes an instance of this type will have, like colour, but not the value of those attributes for a specific object. Classes can also contain functions, called methods available only to objects of that type. These functions are defined within the class and perform some action helpful to that specific type of object.";

        // ADDITIONAL method
        public void TestMethod()
        {
            //Create a list of the values we expect
            List<int> expectedValues = new List<int>();
            //Sentences
            expectedValues.Add(6);
            //Vowels
            expectedValues.Add(189);
            //Consonants
            expectedValues.Add(317);
            //Upper case
            expectedValues.Add(9);
            //Lower case
            expectedValues.Add(497);

            //Create an 'Analyse' object
            Analyse analyse = new Analyse();

            //Pass the text input to the 'analyseText' method
            //Receive a list of integers back
            List<int> values = new List<int>();
            values = analyse.analyseText(testText).Item1;

            //Compare the results with the expected values
            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine("Produced value: {0} | Expected value: {1}", values[i], expectedValues[i]);
                if (values[i] == expectedValues[i])
                {
                    Console.WriteLine("Expected value produced.");
                }
                else
                {
                    Console.WriteLine("Unexpected value produced.");
                }
            }
            Console.WriteLine("Test concluded.\n");
        }
    }
}