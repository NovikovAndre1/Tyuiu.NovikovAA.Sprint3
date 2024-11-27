
using Tyuiu.NovikovAA.Sprint3.Task3.V21.Lib;


namespace Tyuiu.NovikovAA.Sprint3.Task3.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************");
            Console.WriteLine("Исходные данные");
            Console.WriteLine("********************************************************************");

            string value = "f3g5ht g4j 34kg4";
            char chr = 'e';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Нужный символ = " + chr);

            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("********************************************************************");

            Console.WriteLine("Изменённая строка = " + ds.ReplaceNumOnChar(value, chr));

            Console.ReadKey();
        }
    }
}
