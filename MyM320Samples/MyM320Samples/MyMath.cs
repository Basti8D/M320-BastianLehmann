using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyM320Samples
{
    public class MyMath
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Calc_ggT(int a, int b)
        {
            int z = 0;
            while (b != 0)
            {
                z = a % b;
                a = b;
                b = z;
            }
            return a;
        }
        public static int Calc_kgV(int a, int b)
        {
            return (a * b) / Calc_ggT(a, b);
        }
        public static int Calc_ggT_r(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return Calc_ggT_r(b, a % b);
            }
        }
        public static int ReadInt()
        {
            int result = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.Write("Bitte eine ganze Zahl eingeben: ");
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out result);
                if (result <= 0)
                {
                    Console.WriteLine("Die Zahl muss positiv sein. Bitte versuchen Sie es erneut.");
                    isValid = false;
                }
                if (!isValid)
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte versuchen Sie es erneut.");
                }
            }
            return result;
        }
        public static int Mittelwert(int[] zahlen)
        {
            int summe = 0;
            foreach (int zahl in zahlen)
            {
                summe += zahl;
            }
            return summe / zahlen.Length;
        }
        public static int Min(int[] zahlen)
        {
            int min = zahlen[0];
            foreach (int zahl in zahlen)
            {
                if (zahl < min)
                {
                    min = zahl;
                }
            }
            return min;
        }
        public static int Max(int[] zahlen)
        {
            int max = zahlen[0];
            foreach (int zahl in zahlen)
            {
                if (zahl > max)
                {
                    max = zahl;
                }
            }
            return max;
        }
        public static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        public static int[] MakeArray(int count)
        {
            int[] zahlen = new int[count];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Bitte geben Sie die {i + 1}. Zahl ein:");
                zahlen[i] = ReadInt();
            }
            return zahlen;
        }
    }
}
