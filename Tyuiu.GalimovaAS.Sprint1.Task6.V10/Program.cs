using Tyuiu.GalimovaAS.Sprint1.Task6.V10.Lib;
namespace Tyuiu.GalimovaAS.Sprint1.Task6.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Галимова А.С. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                *");
            Console.WriteLine("* Тема: Работа со строками класс String                                                    *");
            Console.WriteLine("* Задание #6                                                                               *");
            Console.WriteLine("* Вариант #10                                                                              *");
            Console.WriteLine("* Выполнила: Галимова Алина Салаватовна | АСОиУБ - 24-1                               *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать консольную программу: пользователь вводит текст.                                *");
            Console.WriteLine("* Напечатать все слова, удалив среднюю букву у слов нечетной длины.                        *");
            Console.WriteLine("*                                                                                          *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("* Введите предложение:                                                                     *");
            string str = Console.ReadLine();

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                                *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine(ds.DeleteMiddleLetter(str));
            Console.ReadKey();
        }
    }
}
