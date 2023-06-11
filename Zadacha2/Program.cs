using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] chisla = new int[30];

            for (int i = 0; i < 30; i++)
            {
                Console.Write("Vuvedi chislo {0}: ",i + 1  );
                chisla[i] = int.Parse(Console.ReadLine());
            }

            int pozitivni = 0;
            int nuli = 0;
            for (int i = 0; i < 30; i++)
            {
                if (chisla[i] > 0)
                {
                    pozitivni += chisla[i];
                }
                else if (chisla[i] == 0)
                {
                    nuli++;
                }
            }

            int malko = chisla[0];
            int golqmo = chisla[0];
            for (int i = 1; i < 30; i++)
            {
                if (chisla[i] < malko)
                {
                    malko = chisla[i];
                }
                if (chisla[i] > golqmo)
                {
                    golqmo = chisla[i];
                }
            }

          
            Console.WriteLine("Broi na polojitelnite chisla: {0}", pozitivni);
            Console.WriteLine("Broi na nulite: {0}", nuli);
            Console.WriteLine("Nai-malkoto chislo: {0}", malko);
            Console.WriteLine("Nai-golqmoto chislo: {0}", golqmo);
        }
    }
}

