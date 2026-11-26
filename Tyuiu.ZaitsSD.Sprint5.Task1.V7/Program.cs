using Tyuiu.ZaitsSD.Sprint5.Task1.V7.Lib;
namespace Tyuiu.ZaitsSD.Sprint5.Task1.V7
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Заиц Сергей Денисович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* F(x) = sin(x)/(x + 1,2) - 2sin(x) - 2x. Табулировать на [-5, 5]         *");
            Console.WriteLine("* с шагом 1, округляя до двух знаков. При делении на ноль вернуть 0.      *");
            Console.WriteLine("* Сохранить значения в OutPutFileTask1.txt и вывести таблицу.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int StartValue = -5;
            int StopValue = 5;
            Console.WriteLine($"Начальное значение = {StartValue}");
            Console.WriteLine($"Конечное значение = {StopValue}");
            string res = ds.SaveToFileTextData(StartValue, StopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Файл: {res}");
            Console.WriteLine("X\tF(x)");
            string[] values = File.ReadAllLines(res);
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine($"{StartValue + i}\t{values[i]}");
            }

        }
    }
}
