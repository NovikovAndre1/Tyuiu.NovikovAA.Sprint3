
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.NovikovAA.Sprint3.Task2.V21.Lib
{
    public class DataService : ISprint3Task2V21
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double SumSeries = 0;
            do
            {
                SumSeries = SumSeries + Math.Pow(1.0 / (Math.Sin(startValue) + 2 * Math.Pow(stopValue, startValue)), startValue);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(SumSeries, 3);
        }
    }
}
