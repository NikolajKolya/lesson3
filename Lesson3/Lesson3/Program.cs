using Lesson3.Abstractions;
using Lesson3.Implementations;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Кубик с 6 гранями
            var d6 = new D6();

            // Кубик с 20 гранями
            var d20 = new D20();

            IDice toThrow = null;

            Console.WriteLine("Какой кубик бросаем?");
            var readStr = Console.ReadLine();
            
            if (readStr == "6")
            {
                toThrow = d6;
            }
            else if (readStr == "20")
            {
                toThrow= d20;
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