using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenges
{
    public class Greeter
    {
        //Build a class called Greeter.This class will hold our next few methods.

        //Inside our new class, build a method that takes in a name and then says hello to that person.

        

        public void SayHello(string name)
        {
            //Console.WriteLine("What is your name?");
            //Console.ReadLine();
            Console.WriteLine($"Hello {name}");

        }

        //Ex: If the method is given the name Joshua, the output should be "Hello Joshua"

        //Build another method that outputs some sort of farewell to the name it is given as a parameter.

        public string SayFarewell(string name)
        {
            string farewell = $"Goodbye {name}";
            return farewell;
        }

        //Build a method that says Good Morning/Afternoon/Evening/Night depending on the time of day.

        public void TimelyGreeting(DateTime timeOfDay)
        {
            if(timeOfDay.Hour < 11)
            {
                Console.WriteLine("Good Morning");
            }
            else if(timeOfDay.Hour >=11 && timeOfDay.Hour < 15)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if (timeOfDay.Hour >= 15 && timeOfDay.Hour < 18)
            {
                Console.WriteLine("Good Evening");
            }
            else
            {
                Console.WriteLine("Good night");
            }

        }  

        //public void TimelyGreeeeeeting()
        //{
        //    DateTime currentTime = DateTime.Now;
        //    TimeSpan timeSpan = currentTime.TimeOfDay;

        //}

    }
}
