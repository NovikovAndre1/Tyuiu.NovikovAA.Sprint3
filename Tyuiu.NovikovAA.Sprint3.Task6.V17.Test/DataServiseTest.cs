
using Tyuiu.NovikovAA.Sprint3.Task6.V17.Lib;


namespace Tyuiu.NovikovAA.Sprint3.Task6.V17.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 10;
            int stopValue = 20;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 270;

            Assert.AreEqual(wait, res);
        }
    }
}