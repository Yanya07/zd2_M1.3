using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Введите максимальную сумму элементов массива: ");
            int maxSum = int.Parse(Console.ReadLine());
            int[] array = GenerateArrayWithMaxSum(maxSum);// Создание массива с минимальным количеством элементов

            Console.WriteLine("Созданный массив:");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            int totalSum = 0;// Вывод суммы элементов массива
            foreach (int element in array)
            {
                totalSum += element;
            }
            Console.WriteLine($"\nСумма элементов массива: {totalSum}");
            Console.WriteLine("Нажмите Enter, чтобы закрыть программу.");
            Console.ReadLine();
        }
        static int[] GenerateArrayWithMaxSum(int maxSum)// Метод для генерации массива с минимальным количеством элементов, сумма которых не превышает maxSum
        {
            Random rand = new Random();
            int sum = 0;
            int count = 0;
            int[] tempArray = new int[100]; // Временный массив для хранения значений
            while (sum < maxSum)// Добавляем случайные элементы в массив до тех пор, пока сумма не превысит maxSum
            {
                int nextValue = rand.Next(1, 10); // Случайное число от 1 до 9 включительно
                if (sum + nextValue > maxSum)
                {
                    break; // Прекращаем добавление, если сумма превысит maxSum
                }
                tempArray[count] = nextValue;
                sum += nextValue;
                count++;
            }
            int[] resultArray = new int[count];// Создаем массив точного размера и копируем в него элементы
            Array.Copy(tempArray, resultArray, count);
            return resultArray;
        }
    }
}
