using Tyuiu.GalimovaAS.Sprint1.Task0.V9.Lib;
namespace Tyuiu.GalimovaAS.Sprint1.Task0.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Галимова А.С. | АСОиУБ 24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                         *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #9                                                               *");
            Console.WriteLine("* Выполнила: Галимова Алина Салаватовна | АСОиУБ - 24-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу C#, которая вычисляет выражение (9/3)*4/3/2+1         *");
            Console.WriteLine("* и печатает результат на экране.                                          *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* (9/3)*4/3/2+1                                                            *");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }
    }
}
