using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MelehovAG.Sprint3.Task5.V0.Lib;

// ТЕОРИЯ
// Вложенные циклы
// Одни циклы могут быть вложенные в другие. Например:

// for (int i = 1; i < 10; i++)
// {
//      for (int j = 1; j < 10; j++)
//      {
//          Console.Write($"{i * j} \t");
//      }
//      Console.WriteLine();
// }

// В данном случае цикл for (int i = 1; i < 10; i++) выполняется 9 раз,
// то есть имеет 9 итераций. Но в рамках каждой итерации выполняется девять раз
// вложенный цикл for (int j = 1; j < 10; j++).

// В итоге данная программа выведет таблицу умножения.

namespace Tyuiu.MelehovAG.Sprint3.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Мелехов Алексей Григорьевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 5;
            int startValue2 = 1;
            int stopValue2 = 10;

            Console.WriteLine("Переменная = " + x);
            Console.WriteLine("Старт шага первой суммы ряда = " + startValue1);
            Console.WriteLine("Конец шага первой суммы ряда = " + stopValue1);
            Console.WriteLine("Старт шага второй суммы ряда = " + startValue2);
            Console.WriteLine("Конец шага второй суммы ряда = " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма сумм ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
            Console.ReadKey();
        }
    }
}
