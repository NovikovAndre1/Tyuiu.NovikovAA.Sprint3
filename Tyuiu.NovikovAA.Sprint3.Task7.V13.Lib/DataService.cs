
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NovikovAA.Sprint3.Task7.V13.Lib
{
    public class DataService : ISprint3Task7V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray; // объявляем пустой массив
            int len = (stopValue - startValue) + 1; // вычисляем длину массива
            valueArray = new double[len]; // создаём массив с указанной длинной
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + 1;
                if (denominator == 0)
                {
                    Console.WriteLine($"Деление на ноль при x = {x}.  Результат: NaN");
                    valueArray[count] = double.NaN; //  NaN - не число
                }
                else
                {
                    y = 3 * x + 2 - ((2 * x - Math.Exp(x)) / denominator);
                    valueArray[count] = Math.Round(y, 2);
                }
                count++;
            }
            return valueArray;
        }
    }
}
