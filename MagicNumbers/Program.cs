using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers
{
    class Program
    {
        /// <summary>
        /// Возвращает сумму чисел
        /// </summary>
        /// <param name="number">число</param>
        /// <returns></returns>
        static int getSumNumber(int number) {
            int sum = -1;
            int a = number;
            if (number >= 0) {
                sum = 0;
                while (a > 0) {
                    sum += a % 10;
                    a /= 10;
                }
            }

            return sum;
        }
        /// <summary>
        /// Является ли число магическим
        /// </summary>
        /// <param name="number">число для определения</param>
        /// <returns></returns>
        static bool isMagicNumber(int number) {
            int right = number / 1000; //первые 3 цифры шестизначного числа
            int left = number % 1000;  //вторые 3 цифры шестизначного числа          
            bool isMagic = (getSumNumber(right) == getSumNumber(left));

            return isMagic;
        }
        /// <summary>
        /// Возвращает кол-во магических цифр от 0 до 999999
        /// </summary>
        /// <returns></returns>
        static int getCountMagicNumbers()
        {
            int count = 0;

            for (int i = 0; i <= 999999; i++) {
                if (isMagicNumber(i) == true) count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            int count = getCountMagicNumbers();
            Console.WriteLine("Кол-во магических цифр от 0 до 999999 равно - {0}", count);
            Console.ReadKey();
        }
    }
}
