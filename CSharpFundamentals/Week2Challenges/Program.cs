using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenges
{
    public class Program
    {
        static void Main(string[] args)
        {

            //New up an instance of your Greeter class inside your Main method.From this instance call all of the methods you've built out.
            Greeter greeter = new Greeter();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            greeter.SayHello(name);
            string fareWell = greeter.SayFarewell(name);
            Console.WriteLine(fareWell);

            DateTime timeOfDay = DateTime.Now;
            greeter.TimelyGreeting(timeOfDay);
            Console.ReadLine();





        }
    }
}
