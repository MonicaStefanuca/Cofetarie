using System;
using System.Collections.Generic;
using System.Linq;

using EvidentaProduse;
using InregistrareClienti;

namespace EvidentaComenzi
{
    public class Comanda
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int ID = 0;
        private const int DATA = 1;
        private const int CLIENT = 2;
        private const int PRODUSE = 3;
        private const int TOTAL = 4;

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Client Client { get; set; }
        public List<Produs> Produse { get; set; }
        public double Total { get; set; }

        public Comanda(int id, DateTime data, Client client, List<Produs> produse)
        {
            Id = id;
            Data = data;
            Client = client;
            Produse = produse;
            Total = CalculeazaTotal();
        }
        public Comanda(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            // se apeleaza metoda ConversieLaSir_PentruFisier pentru a extrage valorile din linia de fisier
            string[] dateObiect = ConversieLaSir_PentruFisier().Split(SEPARATOR_PRINCIPAL_FISIER);

            // se initializeaza campurile obiectului cu valorile extrase din linia de fisier
            Id = Convert.ToInt32(dateObiect[ID]);
            Data = DateTime.Parse(dateObiect[DATA]);
            Client = new Client(Convert.ToInt32(dateObiect[ID]), dateObiect[2], dateObiect[3], dateObiect[4], dateObiect[5]);
            Produse = new List<Produs>();
            string[] produse = dateObiect[PRODUSE].Split(SEPARATOR_PRINCIPAL_FISIER);
            foreach (string produs in produse)
            {
                Produse.Add(new Produs(produs));
            }
            Total = CalculeazaTotal();
        }

        public string Info()
        {
            string dataString = Data != default ? Data.ToString() : "Data necunoscuta";
            string clientString = Client != null ? Client.Nume : "Client necunoscut";
            string produseString = Produse != null && Produse.Count > 0 ? string.Join(", ", Produse.Select(p => p.Nume).ToArray()) : "Lista de produse este goala";
            string info = string.Format("id:{0} data:{1} Client: {2} Produse: {3}",
                Id.ToString(),
                dataString,
                clientString,
                produseString);
            return info;
        }


        public string ConversieLaSir_PentruFisier()
        {
            string dataString = Data != default ? Data.ToString() : "Data necunoscuta";
            string clientString = Client != null ? Client.Nume : "Client necunoscut";
            string produseString = Produse != null && Produse.Count > 0 ? string.Join(", ", Produse.Select(p => p.Nume).ToArray()) : "Lista de produse este goala";

            return string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}",
                        SEPARATOR_PRINCIPAL_FISIER,
                        Id.ToString(),
                        dataString,
                        clientString,
                        produseString,
                        Total.ToString());
        }
        public double CalculeazaTotal()
        {
            double total = 0;

            foreach (Produs produs in Produse)
            {
                total += produs.Pret;
            }

            return total;
        }
        public void AdaugaProdus(Produs produs)
        {
            Produse.Add(produs);
            Total += produs.Pret;
        }

        public void EliminaProdus(Produs produs)
        {
            Produse.Remove(produs);
            Total -= produs.Pret;
        }

        public void SchimbaClient(Client client)
        {
            Client = client;
        }

        public void Goleste()
        {
            Produse.Clear();
            Total = 0;
        }
    }
}
