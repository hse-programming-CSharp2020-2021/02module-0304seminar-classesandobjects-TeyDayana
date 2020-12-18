/** Задание 1
 * 
 * Определить класс Circle с полем радиус _r и свойством доступа к нему, значение радиуса - положительное вещественное число. 
 * В классе Circle описать конструктор без параметров и конструктор с вещественным параметром - радиусом круга.
 * Определить свойство S – площадь круга заданного радиуса. 
 * 
 * В основной программе получить от пользователя диапазон изменения значения радиуса: 
 * [rMin, rMax), rMin, rMax – произвольные вещественные числа и величину шага delta (delta > 0) разбиения данного диапазона. 
 * Создать объект типа Circle, затем последовательно изменяя значение радиуса на delta
 * вычислять и выводить на экран значение площади круга, ограниченного данной окружностью, с двумя знаками после запятой.
 * 
 * Если введены некорректные данные (в том числе данные, не являющиеся числами), требуется вывести строку: "Incorrect input"
 * 
 * Пример входных данных: 
 * 5 7 0.5
 * 
 * Пример выходных данных:
 * 78,54
 * 95,03
 * 113,10
 * 132,73
**/

using System;

namespace Task01
{
    class Circle
    {
        public double _r;

        // TODO: описать конструктор без параметров.

        // TODO: описать конструктор с вещественным параметром - радиусом круга.
        public Circle(double r)
        { _r = r; }

        // TODO: добавить свойство R, инкапсулирующее поле _r и недопускающее присваивание полю некорректного значения.

        // TODO: добавить свойство S - площадь круга заданного радиуса.

        public double GetSquare() => Math.PI*_r*_r;
    }

    class Program
    {
        static void Main(string[] args)
        {
            RunTask01();
        }
        static void RunTask01()
        {
            // TODO: ввод и обработка пользовательского ввода.

            string[] input = Console.ReadLine().Split();
            double rMin = GetNumber(input[0]);
            double rMax = GetNumber(input[1]);
            double delta = GetNumber(input[2]);

            Circle circle;
            for (double r = rMin; r < rMax; r += delta)
            {
                circle = new Circle(r);
                Console.WriteLine($"{circle.GetSquare():f2}");
            }
        }

        static double GetNumber(string str)
        {
            double number;
            if (!double.TryParse(str, out number) || number <= 0)
            {
                Console.WriteLine("Incorrect input");
                Environment.Exit(0);
            }    

            return number;
        }
    }
}
