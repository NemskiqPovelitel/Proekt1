using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] chisla = new int[n];

            for (int i = 0; i < chisla.Length; i++)
            {
                chisla[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(chisla);
            Console.WriteLine(string.Join(" ", chisla));
        }
    }
}
