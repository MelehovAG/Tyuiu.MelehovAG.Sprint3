using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MelehovAG.Sprint3.Task1.V0.Lib;

// ТЕОРИЯ
// В С# цикл while имеет следующую конструкцию: 

// while (условие)
// {
//      Тело цикла
// }

// В этом цикле проверяется условие, и если оно истинно,
// то выполняется набор операторов внутри тела цикла. Обязательно убедитесь,
// что изменяете переменную, от которой зависит условие, иначе цикл станет бесконечным,
// если, конечно, это не является целью.

// Пример работы с циклом while:
// int i = 0;
// int number = 3;
// while (i <= number
// {
//      Console.WriteLine("Итерация цикла номер " + i);
//      i++;
// }
// Console.ReadKey();

namespace Tyuiu.MelehovAG.Sprint3.Task1.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
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
            Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
