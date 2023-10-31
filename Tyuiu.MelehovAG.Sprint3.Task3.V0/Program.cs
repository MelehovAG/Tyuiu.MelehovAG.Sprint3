using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MelehovAG.Sprint3.Task3.V0.Lib;

// ТЕОРИЯ
// Цикл foreach
// Оператор foreach используется для обхода коллекций, последовательно переходя
// от элемента к элементу в цикле. В данном случае,
// под коллекцией понимается тип, который:

// реализует интерфейс Syster.Collections.IEnumerable
// или System.Collections.Generic.IEnumerable<T>;
// реализует открытый метод GetEnumerator, возвращающий интерфейс,
// класс или структуру, имеющие открытое свойство Current и метод MoveNext.

// foreach (тип имя_переменной_цикла in коллекция)
// {
//      Тело цикла
// }

// Пример работы с оператором foreach:
// int[] nums = { 6, 3, 6, 8, 9, 12, 4, 5, 88, 54, 3, 66, 78, 10, 12, 5, 7, 9, 3, 5 };
// int result = 0;
// foreach (int n in nums)
// {
//      if (n > 10)
//      {
//          result++;
//      }
// }
// Console.WriteLine($"Количество чисел в массиве больше 10: {result}");


namespace Tyuiu.MelehovAG.Sprint3.Task3.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Мелехов Алексей Григорьевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            string value = "abcd abcd abcd abcd abcd abcd abcd";
            char chr = 'a';

            Console.WriteLine("Искомая строка = " + value);
            Console.WriteLine("Искомый символ = " + chr);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество символов = " + ds.GetCharCount(value, chr));
            Console.ReadKey();
        }
    }
}
