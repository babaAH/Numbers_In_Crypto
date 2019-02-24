using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INput a");
            long a = (Convert.ToInt64(Console.ReadLine()));// ввод первого числа
            Console.WriteLine("Input b");
            long b = (Convert.ToInt64(Console.ReadLine()));// вввод второго числа

            if (a < b) Exchg(ref a, ref b);//если a < b, то поменять значения переменных местами

            Console.WriteLine();

            Console.WriteLine("Result:");
            Console.WriteLine(Gcd(a, b));
        }

        public static long Gcd(long num1, long num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("b не должен быть равен нулю");
            }
            while ((num1 % num2) != 0)//поиск НОД
            {
                Exchg(ref num1, ref num2);//меняем местами переменные
                num2 = num2 % num1;//b присваиваем остаток от деления большего числа на меньшее
            }

            return num2;
        }

        public static void Exchg(ref long a1, ref long b1)
        {
            a1 = a1 * b1;// умножаем А на Бэ
            b1 = a1 / b1;// делим A * B на B <=> (a * b) / b == a. То есть в b теперь значение a
            a1 = a1 / b1;//делим (a * b) на a. то есть теперьв а значение b
        }
    }

}
