
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.NovikovAA.Sprint3.Task5.V7.Lib
{
    public class DataService : ISprint3Task5V7
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;
            int i,j;
            for (i = startValue1; i <= stopValue1; i++) 
            {
                for (j = startValue2; j <= stopValue2; j++) 
                {
                    sumSeries = sumSeries + ((1 / Math.Cos(j)) + x);
                }
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
