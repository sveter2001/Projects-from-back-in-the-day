// Файл Program.cs
// ФИО, группа
// Лабораторная работа №1
// Табулирование функции
// Вариант №0
// Задание:
// Составить таблицу значений функции
// y=1.1 * e^(-x) / (1.2 + tg(x)) + 4.10 * Sqrt(x);
// с точностью до 4-х значащих цифр на отрезке [3;4] с шагом h=0.1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; //пространство имен для работы с файлами

namespace _1ЛабаООП_3курс_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            double a = 1.5, b = 2.5, h = 0.1, x, y;
            n = (int)Math.Round((b - a) / h) + 1;
            //объявление файловой переменной fout и связывание ее с файлом на диске
            StreamWriter fout =
            new StreamWriter(@"G:\12\Проекты\1ЛабаООП(3курс)\bin\Debug\net5.0\Tabulir_C#.txt");
            fout.WriteLine(" Таблица значений функции");
            for (i = 0; i < n; i++)
            {
                x = a + i * h;
                y = 2.19 * Math.Exp(2 * x) / (5 - 0.6 * x) + 3.19 * Math.Log(x);
                fout.Write("i = {0,2:d}", i);
                fout.WriteLine(" x = {0:f1} y = {1:E3}", x, y);
            }
            fout.Close();
        }
    }
}
