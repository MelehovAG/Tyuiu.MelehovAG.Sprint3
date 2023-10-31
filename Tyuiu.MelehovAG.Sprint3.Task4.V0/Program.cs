using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MelehovAG.Sprint3.Task4.V0.Lib;

// ТЕОРИЯ
// Управление циклами в C#
// Управлять циклами в C# возможно с использованием двух операторов перехода:

// continue - прерывает текущую итерацию цикла и переходит к следующей;
// break - полностью прерывает выполнение цикла.

// int[] nums = { 6, 3, 6, 8, 9, 12, 4, 5, 88, 54, 3, 66, 78, 10, 12, 5, 7, 9, 3, 5};
// for (int i = 0; i < nums.Length; i++)
// {
//      if (nums[i] > 10)
//      {
//          Console.WriteLine($"{nums[i]} > 10");
//          continue;
//      }
//      if (i > 7)
//      {
//          Console.WriteLine("Цикл прерван");
//          break;
//      } 
// }

namespace Tyuiu.MelehovAG.Sprint3.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Мелехов Алексей Григорьевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ЗАДАНИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y = cos(x) / x                                                  *");
            Console.WriteLine("* При x = 0 прервать цикл. Полученные значения суммировать.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
