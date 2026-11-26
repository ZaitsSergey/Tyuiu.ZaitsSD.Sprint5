using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ZaitsSD.Sprint5.Task4.V19.Lib
{
    public class DataService : ISprint5Task4V19
    {
        public double LoadFromDataFile(string path)
        {
            string value = File.ReadAllText(path).Trim().Replace(',', '.');
            double x = double.Parse(value, System.Globalization.CultureInfo.InvariantCulture);
            return Math.Round(Math.Pow(x / Math.Cos(x), 2), 3);
        }
    }
}
