
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.NovikovAA.Sprint3.Task3.V21.Lib
{
    public class DataService : ISprint3Task3V21
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string result = "";
            foreach (char chr in value)
            {
                if (char.IsDigit(chr))
                {
                    result += ('e');
                }
                else 
                {
                    result += chr;
                }
            }
            return result.ToString();
        }
    }
}
