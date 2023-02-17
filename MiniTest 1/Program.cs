using System;
namespace Minitest_1
{
    class progeam
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv två heltal");
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());

            Area(tal1, tal2);
            Console.WriteLine($"Arean på ditt föremål kommer då bli {tal1 * tal2} i kvadrat");


        }

        static int Area(int tal1, int tal2)
        {
            return (tal1 * tal2);
        }
    }
}