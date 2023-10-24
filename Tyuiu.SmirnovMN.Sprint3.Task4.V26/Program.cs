using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SmirnovMN.Sprint3.Task4.V26.Lib;

namespace Tyuiu.SmirnovMN.Sprint3.Task4.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Смирнов М. Н. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #3                                                                    *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                     *");
            Console.WriteLine("* Задание #4                                                                   *");
            Console.WriteLine("* Вариант #26                                                                  *");
            Console.WriteLine("* Выполнила Смирнов М. Н. | ИИПб-23-2                                          *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение функции  *");
            Console.WriteLine("* y=cos(x)-sin(x))/x. При х = 0 пропустить значение. Полученные значения       *");
            Console.WriteLine("* суммировать.                                                                 *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            int start = -5;
            int stop = 5;
            Console.WriteLine("Начало шага = " + start);
            Console.WriteLine("Конец шага = " + stop);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Сумма ряда: " + ds.Calculate(start, stop));
            Console.ReadKey();
        }
    }
}
