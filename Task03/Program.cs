/** Задание 3
 * 
 * Описать класс комплексных чисел Complex. Комплексные числа имеют вид a+bi, где i^2=-1, a, b - действительные числа. Определить в нем:
 * - конструктор, принимающий действительную и мнимую часть;
 * - свойства Re и Im, возвращающие действительную и мнимые части;
 * - свойства Abs и Arg, возвращающие модуль и аргумент числа;
 * - метод Add сложения комплексного числа с другим комплексным или действительным числом;
 * - метод Subtract вычитания из комплексного числа другого комплексного или действительного числа.
 * - метод Multiply умножения комплексного числа на другое комплексное или действительное число.
 * - переопределенный ToString, возвращающий строку в формате "a+bi", где a, b выводятся с двумя знаками после запятой.
 * 
 * В основной программе считать последовательно два комплексных числа,
 * затем вывести их модули и аргументы, результаты сложения, вычитания и умножения введеных чисел.
 * 
 * Если введены некорректные данные (в том числе данные, не являющиеся числами), требуется вывести строку: "Incorrect input"
 * 
 * Пример входных данных:
 * 5 2
 * 1 3
 * 
 * Пример выходных данных:
 * 5,39 3,16
 * 0,38 1,25
 * 6,00+5,00i
 * 4,00-1,00i
 * -1,00+17,00i
 * 
 * Пояснение: на первой строке выходных данных расположены модули комплексных чисел, на второй - аргументы.
**/

using System;

namespace Task03
{
    class Complex
    {
        public double real, imaginary;

        public Complex(double real, double imaginary)
        { this.real = real; this.imaginary = imaginary; }

        public double Abs() => Math.Sqrt(real * real + imaginary * imaginary);

        public double Arg() => Math.Atan(imaginary / real);

        public string Add(Complex num)
        {
            double num1 = real + num.real;
            double num2 = imaginary + num.imaginary;
            return GetString(num1, num2);
        }

        public string Subtract(Complex num)
        {
            double num1 = real - num.real;
            double num2 = imaginary - num.imaginary;
            return GetString(num1, num2);
        }

        public string Multiply(Complex num)
        {
            double n1 = real * num.real;
            double n2 = real * num.imaginary;
            double n3 = imaginary * num.real;
            double n4 = -imaginary * num.imaginary;

            double num1 = n1 + n4;
            double num2 = n2 + n3;
            return GetString(num1, num2);
        }

        public string GetString(double num1, double num2)
        {
            string result = $"{num1:f2}";
            if (num2 > 0) result += "+";
            result += $"{num2:f2}i";

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RunTask03();
        }

        static void RunTask03()
        {
            // TODO: ввод и обработка пользовательского ввода.

            Complex a = GetComplex();
            Complex b = GetComplex();

            Console.WriteLine($"{a.Abs():f2} {b.Abs():f2}");

            Console.WriteLine($"{a.Arg():f2} {b.Arg():f2}");

            Console.WriteLine(a.Add(b));
            Console.WriteLine(a.Subtract(b));
            Console.WriteLine(a.Multiply(b));
        }

        static Complex GetComplex()
        {
            string[] data = Console.ReadLine().Split();
            Complex complex = new Complex(GetNumber(data[0]), GetNumber(data[1]));
            return complex;
        }

        static double GetNumber(string str)
        {
            double number;
            if (!double.TryParse(str, out number))
            {
                Console.WriteLine("Incorrect input");
                Environment.Exit(0);
            }
            return number;
        }
    }
}
