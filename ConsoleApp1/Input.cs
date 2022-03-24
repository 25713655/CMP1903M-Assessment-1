using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "";
        string temp = "";
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            while (true)
            {
                Console.Write("Enter your text (or leave empty to finish): ");
                temp = Console.ReadLine() + " ";
                if (temp == " ")
                {
                    break;
                }
                text += temp;
            }
            try
            {
                return text.Substring(0, text.Length - 1);
            }
            catch (Exception)
            {
                return "";
            }
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(fileName);
            }
            catch (Exception)
            {
                return "";
            }
            temp = streamReader.ReadLine();
            while (temp != null)
            {
                text += temp;
                text += " ";
                temp = streamReader.ReadLine();
            }
            try
            {
                return text.Substring(0, text.Length - 1);
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
