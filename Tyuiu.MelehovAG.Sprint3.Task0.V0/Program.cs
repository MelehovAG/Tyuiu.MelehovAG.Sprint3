using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MelehovAG.Sprint3.Task0.V0.Lib;

// ТЕОРИЯ
// Конструкция цикла for следующая:

// for (инициализация; условие; порядок выполнения)
// {
//      Действие;
// }

// инициализация - начальное значение счётчика;
// условие - пока условие выдаёт true, цикл будет выполняться; 
// порядок выполнения - команда, которая должна наращивать счётчик.

// Пример
// for (int i = 1; i <= 3; i++)
// {
//      Console.WriteLite("Квадрат числа i " + i * i);
// }


namespace Tyuiu.MelehovAG.Sprint3.Task0.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Мелехов Алексей Григорьевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            double value = 5;
            int startValue = 1;
            int stopValue = 10;

            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
