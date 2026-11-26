
using Tyuiu.ZaitsSD.Sprint5.Task3.V21.Lib;
namespace Tyuiu.ZaitsSD.Sprint5.Task3.V21
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Заиц Сергей Денисович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить y = (x^2 + 1) / sqrt(4x^2 - 3) при x = 3.                     *");
            Console.WriteLine("* Округлить до трёх знаков, сохранить в OutPutFileTask3.bin               *");
            Console.WriteLine("* и вывести результат на консоль.                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine($"X = {x}");
            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Файл: {res}");
            using (BinaryReader reader = new BinaryReader(File.OpenRead(res)))
            {
                Console.WriteLine(reader.ReadDouble());
            }

        }
    }
}
