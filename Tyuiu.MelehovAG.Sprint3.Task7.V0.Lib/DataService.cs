using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MelehovAG.Sprint3.Task7.V0.Lib
{
    public class DataService : ISprint3Task7V0
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray; // объявляем пустой массив
            int len = (stopValue - startValue) + 1; // вычисляем длинну массива
            valueArray = new double[len]; // создаём массив с указанной длинной
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(Math.Sin(x), 2); // округляем значение до 2 знаков после запятой
                valueArray[count] = y; // присваиваем значение в массив с индексом count
                count++;
            }
            return valueArray;
        }
    }
}
