using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 85, 65, 89, 90, 67, 43, 34,3,12 };
            int sum=0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    Console.WriteLine(numbers[i]);
                    sum += numbers[i];
                    

                }

            }
            Console.WriteLine("3'e bölünen sayıların toplamı"+sum);

        }
    }
}
