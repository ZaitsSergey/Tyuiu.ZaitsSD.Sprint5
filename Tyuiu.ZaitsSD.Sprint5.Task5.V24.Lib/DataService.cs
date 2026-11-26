using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ZaitsSD.Sprint5.Task5.V24.Lib
{
    public class DataService : ISprint5Task5V24
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            string[] numbers = File.ReadAllText(path).Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries);
            foreach (string number in numbers)
            {
                if (int.TryParse(number, out int value) && (value >= 10 && value <= 99 || value >= -99 && value <= -10))
                {
                    res += value;
                }
            }
            return res;
        }
    }
}
