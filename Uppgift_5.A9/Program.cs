using System;
namespace Uppgift_5_A9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namnLista = new List<string>();

            string svar = "";
            while (svar != "n")
            {
                Console.WriteLine("Skriv ett namn");
                namnLista.Add(Console.ReadLine());

                if (namnLista.Count < 1000)
                {
                    Console.WriteLine("Vill du skriva in ett till namn? Skriv j för ja eller n för nej.");
                    while (true)
                    {
                        svar = Console.ReadLine().ToLower();

                        if (svar != "j" && svar != "n")
                        {
                            Console.WriteLine("Det är inte ett giltigt alternativ. Försök igen.");
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Programmet har tyvärr inte plats för fler namn.");
                    svar = "n";
                }
            }

            Console.WriteLine("\nSkriv in ett namn för att få veta hur många gånger det förekommer.");
            string namn = Console.ReadLine();

            short antal = 0;
            foreach (string listNamn in namnLista)
            {
                if (namn.ToLower() == listNamn.ToLower())
                {
                    antal++;
                }
            }

            Console.WriteLine($"Det namnet skrev du in {antal} gånger.");

            Console.WriteLine("\nTryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}