using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ZaitsSD.Sprint5.Task1.V7.Lib
{
    public class DataService : ISprint5Task1V7
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            string[] values = new string[stopValue - startValue + 1];
            for (int i = startValue; i <= stopValue; i++)
            {
                double denominator = i + 1.2;
                double res = denominator == 0 ? 0 : Math.Sin(i) / denominator - 2 * Math.Sin(i) - 2 * i;
                values[i - startValue] = Convert.ToString(Math.Round(res, 2));
            }
            File.WriteAllText(path, string.Join(Environment.NewLine, values));
            return path;
        }
    }
}
