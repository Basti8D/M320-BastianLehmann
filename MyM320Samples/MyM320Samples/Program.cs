namespace MyM320Samples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)
            {
                int a = MyMath.ReadInt();
                int b = MyMath.ReadInt();
                Console.WriteLine("Bitte wählen Sie eine Berechnung (1: ggT) (2: kgV):");
                string Calc = Console.ReadLine();
                switch (Calc)
                {
                    case "1":
                        int result = MyMath.Calc_ggT(a, b);
                        Console.WriteLine($"Das Ergebnis der Berechnung ist: {result}");
                        break;
                    case "2":
                        int result2 = MyMath.Calc_kgV(a, b);
                        Console.WriteLine($"Das Ergebnis der Berechnung ist: {result2}");
                        break;

                }
                Console.WriteLine("Möchten Sie das Programm beenden? (j/n)");
                string input = Console.ReadLine();
                if (input.ToLower() == "j")
                {
                    exit = true;
                    Console.WriteLine("Programm wird beendet.");
                }
            }
        }
    }
}
