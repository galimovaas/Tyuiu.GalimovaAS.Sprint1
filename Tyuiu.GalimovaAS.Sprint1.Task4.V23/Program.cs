using Tyuiu.GalimovaAS.Sprint1.Task4.V23.Lib;
namespace Tyuiu.GalimovaAS.Sprint1.Task4.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Галимова А.С. | АСОиУБ 24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнила: Галимова А.С. | АСОиУБ 24-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                √|x+y|                                                   *");
            Console.WriteLine("*               ---------                                                 *");
            Console.WriteLine("*                 |3−x|                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x, y;
            Console.WriteLine("ВВЕДИТЕ ЗНАЧЕНИЕ X");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ВВЕДИТЕ ЗНАЧЕНИЕ Y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
