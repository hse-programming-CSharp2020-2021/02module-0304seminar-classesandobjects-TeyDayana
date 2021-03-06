﻿/** Задание 2
 * 
 * Определить класс LatinChar с полем _char и свойством доступа к нему, значение поля – символ латинского алфавита. 
 * Значение поля по умолчанию – ‘a’. Определить конструкторы класса. 
 * 
 * В основной программе создать объект типа LatinChar и, 
 * последовательно перебирая все символы из заданного пользователем диапазона [minChar,  maxChar],  
 * выводить значение поля _char объекта.
 * 
 * Если введены некорректные данные, требуется вывести строку: "Incorrect input"
 * 
 * Пример входных данных: 
 * a f
 * 
 * Пример выходных данных:
 * a
 * b
 * c
 * d
 * e
 * f
 **/

using System;

namespace Task02
{
    class LatinChar
    {
        public char letter = 'a';

        public LatinChar()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RunTask02();
        }
        static void RunTask02()
        {
            // TODO: ввод и обработка пользовательского ввода.
            string[] input = Console.ReadLine().Split();
            char minChar = GetChar(input[0]);
            char maxChar = GetChar(input[1]);

            LatinChar latinChar;
            for (char let = minChar; let <= maxChar; ++let)
                Console.WriteLine(let);
        }

        static char GetChar(string str)
        {
            char letter;

            if (!char.TryParse(str, out letter) || !char.IsLetter(letter))
            {
                Console.WriteLine("Incorrect input");
                Environment.Exit(0);
            }

            return letter;
        }
    }
}
