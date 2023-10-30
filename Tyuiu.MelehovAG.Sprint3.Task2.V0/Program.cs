using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MelehovAG.Sprint3.Task2.V0.Lib;

// ТЕОРИЯ
// Отличие do/while заключается в том, что проверка условия происходит после тела цикла,
// что приводит к тому, что вне зависимости от условия цикл выполнится хотя бы один раз.

// Пример работы с циклом do/while:
// int j = 0;
// int number2 = 3;
// do
// {
//      Console.WriteLine("Итерация цикла номер " + j);
//      j++;
// } while (j > number2);
// Console.ReadKey();

namespace Tyuiu.MelehovAG.Sprint3.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
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
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
