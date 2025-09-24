namespace Lidl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kunde kunde1 = new Kunde() { Vorname = "Fritz", Name = "Mueller", umsatz = 0};
            Lagerist lagerist = new Lagerist() { Vorname = "Joe", Name = "Manser", groesse = 180 };

            kunde1.Kaufe();
            lagerist.lagereEin();
            kunde1.Trage();
            lagerist.Trage();
        }
    }
}
