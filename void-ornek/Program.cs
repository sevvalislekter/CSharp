using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace void_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {

       
          
                string Country(string cName, string capital, string flagc)
                {
                    string card = "ülke" + cName + "başkent" + capital + "bayrak" + flagc;
                    return card;
                }
                string x, y, z;
                Console.WriteLine("ülke adını gir");
                x = Console.ReadLine();
                Console.WriteLine("baskenti gir");
                y = Console.ReadLine();
                Console.WriteLine("bayrak rengi gir");
                z = Console.ReadLine();
                Console.WriteLine(Country(x, y, z));

            }
        }
    }
