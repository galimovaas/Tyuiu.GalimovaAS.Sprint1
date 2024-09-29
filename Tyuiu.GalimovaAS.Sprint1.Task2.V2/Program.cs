﻿using Tyuiu.GalimovaAS.Sprint1.Task2.V2.Lib;
namespace Tyuiu.GalimovaAS.Sprint1.Task2.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Галимова А.С. | АСОиУБ 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                                      *");
            Console.WriteLine("* Задание #2                                                                               *");
            Console.WriteLine("* Вариант #6                                                                               *");
            Console.WriteLine("* Выполнила: Галимова Алина Салаватовна | АСОиУБ - 24-1                                    *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу, которая запришивает у пользователя исходные данные,                  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                              *");
            Console.WriteLine("*                                                                                          *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            int x;

            Console.WriteLine("Введите угол в градусах: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Угол в радианах: " + ds.ConvertAngleToRad(x));

            Console.ReadLine();
        }
    }
}
