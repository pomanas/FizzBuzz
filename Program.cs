using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzPlay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoją liczbę:");
            var userValue = GetNumber();
            FizzBuzz fizzBuzz = new FizzBuzz("");
            var result = fizzBuzz.GetStatus(userValue);
            Console.WriteLine($"Twój wynik to: {result}");
        }

        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int userNumber))
                {
                    Console.WriteLine("Podaleś nieprawidłowe dane. Spróbuj ponownie");
                    continue;
                }
                return userNumber;
            }
        }
    }
}
