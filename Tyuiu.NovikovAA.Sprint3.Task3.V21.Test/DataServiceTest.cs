
using Newtonsoft.Json.Linq;
using Tyuiu.NovikovAA.Sprint3.Task3.V21.Lib;


namespace Tyuiu.NovikovAA.Sprint3.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();

            string str = "f3g5ht g4j 34kg4";
            char chr = 'e';
            string wait = "fegeht gej eekge";
            string res = ds.ReplaceNumOnChar(str, chr);
            Assert.AreEqual(wait, res);
        }
    }
}