
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.NovikovAA.Sprint3.Task4.V12.Lib
{
    public class DataService : ISprint3Task4V12
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int x = startValue; x <= stopValue; x++) 
            {
                if (x == 0) 
                {
                    break;
                }
                else 
                {
                    res += x / (x + Math.Sin(x)) + 2.5;
                }
            }
            return Math.Round(res, 3);
        }
    }
}
