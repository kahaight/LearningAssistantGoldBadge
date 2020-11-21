using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //-- Whole Numbers
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallWholeNumber = 16; //Int 16
            Int16 anotherSmallNumber = 16;
            int wholeNumber = 32;
            long largeWholeNumber = 64;

            //-- Decimals
            float floatExample = 1.234567f;
            double doubleExample = 1.2382352d;
            decimal decimalExample = 1.700000000m;

            char letter = 'j';

            //-- Operators
            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numTwo * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            Console.WriteLine("Hello");

        }
        [TestMethod]
        public void ReferenceTypes()
        {
            char space = ' ';

            //-- Strings
            string stringExample = "This is a string.";
            string name = "Konrad";

            string declared;
            declared = "Now it's initialized";

            //Formatting strings
            string concatenate = stringExample + space + name;
            string interpolate = $"{name}{space}{stringExample}";
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

            //-- Other Object Examples
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomeDate = new DateTime(2019, 6, 29);

            TimeSpan waitTime = randomeDate - now;
            Console.WriteLine(waitTime.TotalSeconds);

            //-- Collections (Generic)
            //-- Arrays
            string anotherExampleString = "Hello World";
            string[] stringArray = { anotherExampleString, "Hello", "World", "!" };
            string[] students = new string[15];

            Console.WriteLine(stringArray);

            //-- Lists

            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Lawrence");

            //-- Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Arabia");

            //-- Dictionaries

            Dictionary<char, string> keyValuePairs = new Dictionary<char, string>();
            keyValuePairs.Add('k', "Konrad");


            //-- Other Collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();

        }
    }
}
