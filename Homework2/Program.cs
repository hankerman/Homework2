using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 1
            //Объявить одномерный(5 элементов) массив с именем A и двумерный массив(3 строки, 4 столбца) дробных
            //чисел с именем B.Заполнить одномерный массив
            //А числами, введенными с клавиатуры пользователем, а
            //двумерный массив В случайными числами с помощью
            //циклов.Вывести на экран значения массивов: массива
            //А в одну строку, массива В — в виде матрицы.Найти в
            //данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее
            //произведение всех элементов, сумму четных элементов
            //массива А, сумму нечетных столбцов массива В.

            int size = 5;
            int row = 3;
            int col = 4;

            double[] arr = new double[size];
            double[,] arr2 = new double[row, col];
            double sum = 0;
            double mult = 0;
            double sumto = 0;
            double sumB = 0;
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                //arr[i] = Convert.ToInt32(Console.ReadLine());
                arr[i] = Math.Round(random.NextDouble() * 10, 2);
                sum += arr[i];
                if ((arr[i] * 100) % 2 == 0)
                {
                    sumto += arr[i];
                }
                if(i == 0)
                {
                    mult = arr[i];
                }
                else
                {
                    mult *= arr[i];
                }
            }
            

            for(int i = 0; i <row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    arr2[i, j] = Math.Round(random.NextDouble() * 10, 2);
                    sum += arr2[i, j];
                    mult = arr2[i, j];
                    if (j % 2 != 0)
                    {
                        sumB += arr2[i, j];
                    }
                }
            }

            foreach(double it in arr)
            {
                Console.Write(it + " ");
            }
            Console.WriteLine("\n");
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }

            double[] res = new double[5];
            for (int t = 0, r = 0; t < size; t++)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if(arr[t] == arr2[i, j])
                        {
                            res[r] = arr[t];
                            r++;
                        }
                    }
                    
                }
            }

            double max = res.Max();
            double min = res.Min();

            if(max > 0)
            {
                Console.WriteLine("общее максимальное - " + max);
            }
            else
            {
                Console.WriteLine("максимальных совпадений нет");
            }
            if (min > 0)
            {
                Console.WriteLine("общее минимальное - " + min);
            }
            else
            {
                Console.WriteLine("минимальных совпадений нет");
            }

            Console.WriteLine("Сумма - " + sum);
            Console.WriteLine("Произведение - " + mult);
            Console.WriteLine("Сумма четных масива A - " + sumto);
            Console.WriteLine("Сумма не четных столбцов масива B- " + sumB);
        }
    }
}
