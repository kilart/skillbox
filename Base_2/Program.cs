﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_2
{
    class Program
    {
        static void Main(string[] args)
        {   
            string fullname = "Иванов Иван Иванович";
            byte age = 19;
            string email = "andrey@yandex.ru";
            sbyte progresult = 50;
            sbyte mathresult = 60;
            sbyte phisresult = 80;

            int summ = progresult + mathresult + phisresult;

            double midlb = summ / 3;

            string pattern = "ФИО: {0}; Возраст: {1}; Почта: {2}; \nПрограммирование: {3}; Математика: {4}; Физика: {5};";
            Console.WriteLine(pattern, fullname, age, email, progresult, mathresult, phisresult);
            Console.ReadKey();

            string pattern1 = "Сумма балов: {0}; Средний бал: {1};";
            string dmidlb = midlb.ToString("#.###");
            Console.WriteLine(pattern1, summ, dmidlb);
            Console.ReadKey();
        }
    }
}
