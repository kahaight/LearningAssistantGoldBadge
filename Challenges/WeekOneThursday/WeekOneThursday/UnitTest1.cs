using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeekOneThursday
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            char[] poppins = { 's','u','p','e','r','c','a','l','i','f','r','a','g','i','l','i','s','t','i','c','e','x','p','i','a','l','i','d','o','c','i','o','u','s' };

            for (int i =0; i < poppins.Length; i++)
            {
                Console.WriteLine(poppins[i]);
            }

            for (int i=0; i<poppins.Length; i++)
            {
                if (poppins[i] == 'i' || poppins[i] == 'l')
                {
                    Console.WriteLine(poppins[i]);
                }
                else
                {
                    Console.WriteLine("Not an i");
                }
            }

            string firstName = "Konrad";
            string lastName = "Haight";
            int age = 33;

            string[] bookArray = { "Harry Potter", "Stormlight Archive", "Game of Thrones", "Mystborn" };

            List<DateTime> listOfDates = new List<DateTime>();
            listOfDates.Add(DateTime.Now);
            Console.WriteLine(listOfDates[0]);

            int sum = age + 7;
            int diff = age - 7;
            int prod = age * 7;
            float quot = age / 7;
            int remainder = age % 7;
            Console.WriteLine("Sum: "+ sum + "\n" + "Difference: " + diff + "\n" +
                "Product: " + prod +"\n" + "Quotient: " + quot + "\n" + "Remainder: " + remainder);

            int testNum = 9;
            if (testNum >= 10)
            {
                Console.WriteLine("Wow that's a lot fo sleep!");
            }
            else if (testNum >= 8 && testNum < 10)
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if (testNum > 4 && testNum < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep");
            }

            string dayQuality = "Bad";
            switch (dayQuality)
            {
                case "Great":
                    Console.WriteLine("Great for you");
                    break;
                case "Good":
                    Console.WriteLine("Good for you");
                    break;
                case "Okay":
                    Console.WriteLine("Okay for you");
                    break;
                case "Bad":
                    Console.WriteLine("Bad for you");
                    break;
            }
        }
    }
}
