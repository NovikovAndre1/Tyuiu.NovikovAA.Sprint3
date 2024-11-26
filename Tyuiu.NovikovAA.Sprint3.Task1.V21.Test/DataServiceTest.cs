
using Tyuiu.NovikovAA.Sprint3.Task1.V21.Lib;


namespace Tyuiu.NovikovAA.Sprint3.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 1;
            int startValue = 1;
            int stopValue = 12;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 16947810.881;

            Assert.AreEqual(wait, res);
        }
    }
}