
using Tyuiu.NovikovAA.Sprint3.Task4.V12.Lib;


namespace Tyuiu.NovikovAA.Sprint3.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 3.737;
            Assert.AreEqual(wait, res);
        }
    }
}