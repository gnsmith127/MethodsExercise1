using System;

namespace MethodsExercise1
{
    class Program
    {
        public static int Sum(params int[] numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
                total += numbers[i];
            return total;
        }

        public static int Multiply(int num1, int num2)
        {
            int answer = num1 * num2;
            return answer;
        }

        static void Main(string[] args)
        {
            int balls = Sum(1, 4, 5);
            Console.WriteLine(balls);

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
