using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3  basamaklı sayı girin");
            int a;
            a = int.Parse(Console.ReadLine());
            int hundred,tens,ones;
            int sum;
            ones = a % 10;
            tens = (a % 100) / 10;
            hundred = a / 100;

            Console.WriteLine(ones + "-"+tens + "-"+hundred);
            sum = ones + tens + hundred;
            Console.WriteLine("3 basamaklı sayının toplamı " + sum);

         }
    }
}
