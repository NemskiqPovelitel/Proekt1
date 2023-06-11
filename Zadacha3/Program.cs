using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frazi = new List<string> {"Produktut e otlichen.", "Tova e strahoten produkt.", "Postoqnno polzvam tozi produkt.", "Tova e nai-dobrqt produkt ot tazi kategoriq." };
            List<string> sluchki =new List <string> { "Chustvam se dobre.", "Uspqh da se promenq.", "Toi napravi chudo.", "Spechelih! Sluchi se chudo!", "Ne moga da povqrvam, no uspqh da prevuzmogna sebe si.", "Opitaite i vie. Az sum mnogo dovolna." };
            List<string> ime = new List<string> { "Kalina", "Gergana", "Stela", "Elena", "Katq" };
            List<string> familiq = new List<string> { "Ivanova", "Petrova", "Kirova" };
            List<string> grad = new List<string> { "Sofiq", "Plovdiv", "Varna", "Ruse", "Burgas", "Karlovo", "Sopot" };

            Random random = new Random();

            string frazi2 = frazi[random.Next(frazi.Count)];
            string sluchki2 = sluchki[random.Next(sluchki.Count)];
            string ime2 = ime[random.Next(ime.Count)];
            string familiq2 = familiq[random.Next(familiq.Count)];
            string grad2 = grad[random.Next(grad.Count)];

            string reklama = $"{frazi2} {sluchki2} - {ime2} {familiq2}, {grad2}";

            Console.WriteLine(reklama);
        }
    }
}
