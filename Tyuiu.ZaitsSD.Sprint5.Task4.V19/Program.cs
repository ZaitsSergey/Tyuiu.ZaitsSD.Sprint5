
using Tyuiu.ZaitsSD.Sprint5.Task4.V19.Lib;
namespace Tyuiu.ZaitsSD.Sprint5.Task4.V19
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Заиц Сергей Денисович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Прочитать вещественное число из InPutDataFileTask4V19.txt.              *");
            Console.WriteLine("* Вычислить y = (x / cos(x))^2. Округлить до трёх знаков                  *");
            Console.WriteLine("* и вывести результат на консоль.                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask4V19.txt");
            Console.WriteLine($"Файл находится по пути: {path}");
            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Результат формулы для значения из файла: {res}");

        }
    }
}
