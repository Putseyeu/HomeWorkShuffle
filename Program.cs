using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbres = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Исходный массив");
            ShowHumbers(numbres);
            ShuffleNumbers(numbres);
            Console.WriteLine("Перемешаный массив");
            ShowHumbers(numbres);
        }

        static int[] ShuffleNumbers(int[] numbres)
        {
            Random random = new Random();

            for (int i = numbres.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                int tempNumber = numbres[j];
                numbres[j] = numbres[i];
                numbres[i] = tempNumber;
            }
            return numbres;
        }

        static void ShowHumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
