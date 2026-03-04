using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("String: ");
            string frase = Console.ReadLine();

            Console.Write($"Caracter: ");
            char c = char.Parse(Console.ReadLine());

            foreach (char f in frase)
            {
                if (f != c)
                {
                    Console.Write(f);
                }
                if (f == c)
                {
                    Console.Write("x");
                }
            }
        }
    }
}
