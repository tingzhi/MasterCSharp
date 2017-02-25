using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + ". I am glad to meet you!");
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            if (age < 21)
            {
                Console.WriteLine(name + ". You cannot drink!");
            }
            else
            {
                Console.WriteLine(name + ". Here, have a drink!");
            }
        }
    }
}
