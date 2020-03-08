using System;
using System.Text;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // To Display a String
            //string myString = "I am Learning C-Sharp";

            // To add special Chacters in String
            //string myString = "I am Learning \"C-Sharp\" at Lexic";

            // To write on a new line in String
            //string myString = "I am Learning \nC-Sharp at Lexic";

            // To write back slash in String

            //string myString = "My codes are in C:\\ drive";
            //string myString = @"My codes are in C:\ drive";

            // To Format a String

            //string myString = string.Format("{0}, {1}", "First", "Second");

            // To Format a String in Currencey 
            //string myString = string.Format("{0:C}", 500.12);


            // To Format a String of Numbers 
            //string myString = string.Format("{0:N}", 50001150.12);

            // To Format a String to precentage 
            //string myString = string.Format("Percentage: {0:P}", 0.125);

            // To Format a String to Phone Number 
            //string myString = string.Format("Phone Number: {0:(+##) ##-### ####}", 123456789011);

            /*string myString = " That summer we took threes accros the board  ";

            myString = myString.Substring(6, 14);
             myString = myString.ToUpper();
             myString = myString.Replace(" ", "--");
             myString = myString.Remove(6, 14);
             
            myString = String.Format("Length Before: {0} -- Length After {1}",
                myString.Length, myString.Trim().Length);*/
            /*string myString = "";
            for (int i = 0; i <50; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            StringBuilder myString
                 = new StringBuilder();
            for (int i = 0; i < 50; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
