using System;
namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur gammal är du? ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 16 && age <= 19)
            {
                Console.WriteLine("Du får delta i tävlingen!");
            }
            else
            {
                Console.WriteLine("Du får inte delta i tävlingen.");
            }
        }
    }
}