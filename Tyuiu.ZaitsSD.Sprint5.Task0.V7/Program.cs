using Tyuiu.ZaitsSD.Sprint5.Task0.V7.Lib;
namespace Tyuiu.ZaitsSD.Sprint5.Task0.V7
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Заиц Сергей Денисович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить F(x) = -x^3 + 4x^2 - 3x/2 при x = 4.                          *");
            Console.WriteLine("* Округлить до трёх знаков, записать в OutPutFileTask0.txt                *");
            Console.WriteLine("* и вывести результат на консоль.                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 4;
            Console.WriteLine($"X = {x}");
            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Файл: {res}");
            Console.WriteLine(File.ReadAllText(res));

        }
    }
}
