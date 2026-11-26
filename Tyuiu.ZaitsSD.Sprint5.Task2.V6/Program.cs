
using Tyuiu.ZaitsSD.Sprint5.Task2.V6.Lib;
namespace Tyuiu.ZaitsSD.Sprint5.Task2.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Заиц С. Д. | ПКТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Заиц Сергей Денисович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Ввести целочисленный массив 3 на 3. Положительные элементы              *");
            Console.WriteLine("* заменить на 1, отрицательные на 0. Сохранить результат                  *");
            Console.WriteLine("* в OutPutFileTask2.csv и вывести его на консоль.                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 3;
            int columns = 3;
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Введите {i}, {j} элемент массива");
                    matrix[i, j] = int.Parse(Console.ReadLine()!);
                }
            }
            string res = ds.SaveToFileTextData(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Файл: {res}");
            Console.WriteLine(File.ReadAllText(res));

        }
    }
}
