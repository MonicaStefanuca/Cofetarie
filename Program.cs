using System;
using System.Configuration;
using System.Threading;

using EvidentaProduse;
using EvidentaComenzi;
using InregistrareClienti;

using NivelStocareDate;

namespace Cofetarie
{
    internal class Program
    {
        public static Produs[] produse { get; private set; }

        static void Main()
        {
            Produs produs = new Produs();
            Produs[] produse;

            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            AdministrareProduse_FisierText adminProduse = new AdministrareProduse_FisierText(numeFisier);
            int nrProduse = 0;

            string optiune;
            do
            {
                Console.WriteLine("I. Introducere informatii produs");
                Console.WriteLine("A. Afisare produse");
                Console.WriteLine("F. Afisare produse din fisier");
                Console.WriteLine("S. Salvare produs in fisier");
                Console.WriteLine("C. Cautare produs in fisier");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "I":
                        int idProdus = nrProduse + 1;

                        Console.WriteLine("Introdu numele produsului {0} : ", idProdus);
                        string Nume = Console.ReadLine();
                        Console.WriteLine("Introdu pretul produsului {0} in lei : ", idProdus);
                        float Pret = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Introdu gramajul produsului {0} in grame: ", idProdus);
                        int gramaj = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Introdu descrierea produsului {0} : ", idProdus);
                        string Descriere = Console.ReadLine();
                        Console.WriteLine("Introdu nr de produse de acest fel preparate {0} : ", idProdus);
                        int NrProdusePreparate = Convert.ToInt16(Console.ReadLine());
                        produs = new Produs(idProdus, Nume, Pret, gramaj, Descriere, NrProdusePreparate);
                        nrProduse++;

                        break;
                    case "A":
                        string infoProduse = produs.Info();
                        Console.WriteLine("Produsul {0}", infoProduse);

                        break;
                    case "F":
                        produse = adminProduse.GetProduse(out nrProduse);
                        AfisareProduse(produse, nrProduse);

                        break;
                    case "S":
                        idProdus = nrProduse + 1;
                        nrProduse++;
                        produs = new Produs(idProdus, "Pavlova", 24, 200, "Gust bun", 25);
                        //adaugare in fisier
                        adminProduse.AddProdus(produs);

                        break;
                    case "C":
                        Console.WriteLine("Introduceti numele produsului:");
                        string numeProdus = Console.ReadLine();
                        Produs produsCautat = adminProduse.CautaProdus(numeProdus);
                        if (produsCautat != null)
                        {
                            Console.WriteLine("Produsul cautat este: " + produsCautat.ConversieLaSir_PentruFisier());
                        }
                        else
                        {
                            Console.WriteLine("Produsul cu numele " + numeProdus + " nu a fost gasit.");
                        }
                        break;
                    case "X":

                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");

                        break;
                }
            } while (optiune.ToUpper() != "X");
        }
        public static void AfisareProdus(Produs produs)
        {
                string infoProduse = string.Format("Produsul cu id-ul #{0} are numele: {1} , pretul: {2}, gramajul: {3}, descrierea: {4}, numarul de produse preparate: {5}",
                   produs.idProdus,
                   produs.Nume ?? " NECUNOSCUT ",
                   produs.Pret,
                   produs.gramaj,
                   produs.Descriere ?? " NECUNOSCUT ",
                   produs.NrProdusePreparate);
                Console.WriteLine(infoProduse);
        
        }
        public static void AfisareProduse(Produs[] produse, int nrProduse)
        {
            Console.WriteLine("Produsele sunt:");
            for (int contor = 0; contor < nrProduse; contor++)
            {
                AfisareProdus(produse[contor]);
            }
        }
        public static Produs CitireProdusTastatura()
        {
            Console.WriteLine("Introdu numele produsului {0} : ");
            string Nume = Console.ReadLine();

            Console.WriteLine("Introdu pretul produsului {0} : ");
            float Pret = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Introdu gramajul produsului {0} : ");
            int gramaj = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Introdu descrierea produsului {0} : ");
            string Descriere = Console.ReadLine();

            Console.WriteLine("Introdu nr de produse de acest fel preparate {0} : ");
            int NrProdusePreparate = Convert.ToInt16(Console.ReadLine());

            Produs produs= new Produs(0, Nume, Pret, gramaj, Descriere, NrProdusePreparate);

            return produs;
        }
    }
}
