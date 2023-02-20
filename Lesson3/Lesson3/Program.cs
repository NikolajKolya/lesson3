using Lesson3.Abstractions;
using Lesson3.Implementations;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDice toThrow = null;

            Console.WriteLine("Какой кубик бросаем?");
            var readStr = Console.ReadLine();
            
            if (readStr == "6")
            {
                toThrow = new D6();
            }
            else if (readStr == "20")
            {
                toThrow= new D20();
            }
            else if (readStr == "cheat")
            {
                toThrow = new Cheat();
            }
            else
            {
                Console.WriteLine("Такого кубика нет!");
                Environment.Exit(1);
            }

            Console.WriteLine($"Выпало: {toThrow.Throw()}");

            Console.ReadLine();
        }
    }
}