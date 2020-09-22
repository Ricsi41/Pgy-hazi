using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pgy_hazi
{
    class Program
    {
        static Random r = new Random();
        
        static void Main(string[] args)
        {
            string[] nevek = new string[] { "Krisztián", "Béla", "Anikó", "Eszter", "Kevin" };
            for (int i = 0; i < nevek.Length; i++)
            {
                Console.Write(nevek[i]+" ");
            }
            int[] magassag = new int[5];
            Console.WriteLine(" ");
            Console.WriteLine("\nAdd meg az 5 ember magasságát: ");
            int osszeg = 0;
            for (int i = 0; i < magassag.Length; i++)
            {
                magassag[i] = int.Parse(Console.ReadLine());
                osszeg = osszeg + magassag[i];
            }
            Console.WriteLine($"Az átlagmagasság: {osszeg/magassag.Length}");
            int[] tomb = new int[20];
            int ossz = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(50, 150);
                Console.Write(tomb[i] + " ");     
            }
            Console.WriteLine(" ");
            for (int i = 0; i < tomb.Length; i++)
            {
                ossz = ossz + tomb[i];
            }
            Console.WriteLine($"A tömb elemeinek összege: {ossz}");
            Console.WriteLine($"A tömb elemeinek átlaga: {ossz/tomb.Length}");
            Console.WriteLine("\n Add meg a napi utalásokat: ");
            int osszeg2 = 0;
            int megsz = 0;
            int[] bank = new int[12];
            for (int i = 0; i < bank.Length; i++)
            {
                bank[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < bank.Length; i++)
            {
                osszeg2 = osszeg2 + bank[i];
            }
            for (int i = 0; i < bank.Length; i++)
            {
                if (bank[i] > osszeg2 / bank.Length)
                {
                    megsz++;
                }
            }
            Console.WriteLine($"Az átutalások napi átlaga: {osszeg2/bank.Length}");
            Console.WriteLine($"Ennyiszer volt több az átutalások száma az átlagnál: {megsz}");
            Console.ReadKey();
        }
    }
}
