using Tyuiu.GalimovaAS.Sprint1.Task1.V2.Lib;
namespace Tyuiu.GalimovaAS.Sprint1.Task1.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Галимова А.С. | АСОиУБ 24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Организация ввода или вывода в консольных                          *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #2                                                               *");
            Console.WriteLine("* Выполнила: Галимова Алина Салаватовна | АСОиУБ - 24-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные   *");
            Console.WriteLine("* вычисляет результат по формуле (x * y / (5 + x)) и печатает его          *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* (x * y / (5 + x))                                                        *");
            Console.WriteLine("****************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y; ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                                *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}
