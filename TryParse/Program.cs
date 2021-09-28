using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is 2 + 2?\nYou have 3 attempts.");

            int user;
            int answer = 4;
            bool valid;
            bool correct = false;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Attempt {i}");

                valid = int.TryParse(Console.ReadLine(), out user);

                if (!valid)
                {
                    Console.WriteLine("Fel inmatning, du måste mata in en siffra");
                    i--;
                    continue;
                }


                if (user == answer)
                {
                    correct = true;
                    break;
                }
            }

            if (correct)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Never mind, try again!");
            }
        }
    }
}
