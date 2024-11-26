
using Tyuiu.NovikovAA.Sprint3.Task1.V21.Lib;


namespace Tyuiu.NovikovAA.Sprint3.Task1.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************");
            Console.WriteLine("Исходные данные");
            Console.WriteLine("********************************************************************");

            int value = 1;
            int startValue = 1;
            int stopValue = 12;

            Console.WriteLine("Переменная Х = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("********************************************************************");


            Console.WriteLine("Сумма рада = " + ds.GetMultiplySeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
