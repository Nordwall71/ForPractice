using System.Numerics;

namespace MorePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Mutha Fucka");

            OneFor();
            TwoFor();
            ThreeFor();
            FourFor();
        }

        public static void OneFor()
        {
            Console.WriteLine("Give me a number under 10");
            int thisNumber = int.Parse(Console.ReadLine());

            for (int i = 3; i < 99; i++)
            {
                Console.WriteLine($"{thisNumber} x {i} = {thisNumber * i}");
            }


        }
        
        public static void TwoFor() 
        {
            Console.WriteLine("Now a number between 50 and 60");
            int thisNumber = int.Parse(Console.ReadLine());

            for (int p = 6; p < 900; p++)
            {
                Console.WriteLine($"{thisNumber} x {p} = {thisNumber*p}");
            }
        }

        public static void ThreeFor() 
        {
            Console.WriteLine("Give me a number!");
            int response = int.Parse(Console.ReadLine());

            for (int q = 4; q < 88; q++)
            {
                Console.WriteLine($"{response} x {q} = {response*q}");
            }
        }

        public static void FourFor()
        {
            for (int l = 6; l < 300; l++)

                Console.WriteLine($"{l}");
        }
        
    }
}