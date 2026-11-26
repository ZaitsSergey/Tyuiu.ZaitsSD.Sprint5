using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ZaitsSD.Sprint5.Task2.V6.Lib
{
    public class DataService : ISprint5Task2V6
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            string[] lines = new string[rows];
            for (int i = 0; i < rows; i++)
            {
                string[] row = new string[columns];
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > 0) matrix[i, j] = 1;
                    else if (matrix[i, j] < 0) matrix[i, j] = 0;
                    row[j] = matrix[i, j].ToString();
                }
                lines[i] = string.Join(';', row);
            }
            File.WriteAllText(path, string.Join(Environment.NewLine, lines));
            return path;
        }
    }
}
