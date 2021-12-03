using System;

namespace MethodsExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hi, {name}. What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine($"I love {color} too! What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine($"Wow, {animal} is an interesting choice. What is your favorite band?");
            string band = Console.ReadLine();
        }
    }
}
