using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Определить, имеются ли в одномерном массиве случайных чисел элементы, значения которых кратны 11.Вывести такие значения.

            //int[] nums = new int[10];
            //Random rand = new Random();
            //for (int i = 0;i<10;i++)
            //{
            //    nums[i] = rand.Next(1, 50);
            //    Console.Write($"{nums[i]}, ");
            //}
            //Console.WriteLine("\nЧисла кратные 11: ");
            //foreach (int i in nums)
            //{
            //    if (i%11==0) { Console.WriteLine(i); }
            //}

            //Задача 2.Найти сумму и количество положительных элементов в одномерном массиве с явной инициализацией.

            //int[] nums = new int[5] { 5, 8, -2, 6, 4 };
            //int value = 0;
            //int count = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    if (nums[i] > 0) { value += nums[i]; count++; }
            //}
            //Console.WriteLine($"Сумма - {value}\nКоличество - {count}");

            //Array.Clear(nums, 2, 2);
            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}

            //Задача 3.Вывести элементы одномерного массива, заполненного с клавиатуры ,в обратном порядке.

            int[] nums = new int[5];
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"Введите {i} элемент -  ");
                nums[i] = int.Parse(Console.ReadLine());
            }
            //Array.Sort(nums);

            //Array.Reverse(nums);

            //for (int i = nums.Length-1; i>=0;i--)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}

            Console.Read();
        }
    }
}
