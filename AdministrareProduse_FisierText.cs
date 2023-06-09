﻿using EvidentaProduse;

using System.IO;

namespace NivelStocareDate
{
    public class AdministrareProduse_FisierText
    {
        private const int NR_MAX_PRODUSE = 50;
        private string numeFisier;

        public AdministrareProduse_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddProdus(Produs produs)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(produs.ConversieLaSir_PentruFisier());
            }
        }

        public Produs[] GetProduse(out int nrProduse)
        {
            Produs[] produse = new Produs[NR_MAX_PRODUSE];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrProduse = 0;

                // citeste cate o linie si creaza un obiect de tip Produs
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    produse[nrProduse++] = new Produs(linieFisier);
                }
            }

            return produse;
        }
        public Produs CautaProdus(string nume)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si verifica daca numele cautat se potriveste
                // cu cel al produsului din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Produs produs = new Produs(linieFisier);
                    if (produs.Nume == nume)
                    {
                        return produs;
                    }
                }
            }

            return null; // daca nu a fost gasit produsul cu numele cautat
        }
    }
}