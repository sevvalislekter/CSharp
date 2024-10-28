using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("öğrenci sınav sistemi");
            Console.WriteLine("--------------");
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Sınıfta kaç öğrenci var");
            int stdC = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------");

            string[] isim = new string[stdC];
            double[] exams = new double[stdC];

            for (int i = 0; i < stdC; i++)
            {
                Console.WriteLine($"{i + 1} öğrencinin ismini yazın");
                isim[i] = Console.ReadLine();
                double total = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{isim[i]} isimli öğrencinin {j+1} sınav notunu girin");
                     double value= double.Parse(Console.ReadLine());

                    total += value;
                }
                exams[i] = total / 3;
                
            }
            for (int i = 0; i < stdC; i++)
            {
                Console.WriteLine($"{isim[i]} öğrencinin ortalaması:{exams[i]}");

            }
            for (int i = 0; i < stdC; i++)
            {
                if (exams[i] >= 50)
                {
                    Console.WriteLine($"{isim[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{isim[i]} adlı öğrenci dersi geçemedi");
                }
            }
        }
    }
}
