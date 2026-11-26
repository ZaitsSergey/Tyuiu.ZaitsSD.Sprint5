
using Tyuiu.ZaitsSD.Sprint5.Task7.V3.Lib;
namespace Tyuiu.ZaitsSD.Sprint5.Task7.V3
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Заиц Сергей Денисович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Удалить все русские буквы из InPutDataFileTask7V3.txt.                  *");
            Console.WriteLine("* Сохранить результат в OutPutDataFileTask7V3.txt.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask7V3.txt");
            Console.WriteLine($"Файл находится по пути: {path}");
            string res = ds.LoadDataAndSave(path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Файл: {res}");
            Console.WriteLine(File.ReadAllText(res));

        }
    }
}
