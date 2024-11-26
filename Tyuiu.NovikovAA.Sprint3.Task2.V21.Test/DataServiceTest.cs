
using Tyuiu.NovikovAA.Sprint3.Task2.V21.Lib;


namespace Tyuiu.NovikovAA.Sprint3.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double value = 1.5;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.048;
            Assert.AreEqual(wait, res);
        }
    }
}