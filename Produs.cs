using System;

namespace EvidentaProduse
{
    public class Produs
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int ID = 0;
        private const int NUME = 1;
        private const int PRET = 2;
        private const int GRAMAJ = 3;
        private const int COD = 4;
        private const int DESCRIERE = 5;
        private const int NRPRODUSEPREPARATE = 6;

        private int idProdus;
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public int gramaj { get; set; }
        public float Pret { get; set; }
        public int Cod { get; set; }
        public int NrProdusePreparate { get; set; }
        public int NrProdueCumparate { get; set; }
        public int NrProduseDisponibile { get { return NrProdusePreparate - NrProdueCumparate; } }

        //constructor implicit
        public Produs()
        {
            Nume = string.Empty;
        }
        //constructor cu parametrii
        public Produs(int IdProdus, string _nume , float _pret, int _gramaj, int _cod, string _descriere, int _nrProdusePreparate)
        {
            idProdus = IdProdus;
            Nume = _nume;
            Pret = _pret;
            gramaj = _gramaj;
            Cod = _cod;
            Descriere = _descriere;
            NrProdusePreparate = _nrProdusePreparate;
            NrProdueCumparate = 0;
        }

        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Produs(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            idProdus = Convert.ToInt32(dateFisier[ID]);
            Nume = dateFisier[NUME];
            Pret = Convert.ToInt32(dateFisier[PRET]);
            gramaj = Convert.ToInt32(dateFisier[GRAMAJ]);
            Cod = Convert.ToInt32(dateFisier[COD]);
            Descriere = dateFisier[DESCRIERE];
            NrProdusePreparate = Convert.ToInt32(dateFisier[NRPRODUSEPREPARATE]);
        }
        public string Info()
        {
            string info = string.Format("nume:{0} pret:{1} Gramaj: {2} cod:{3} descriere:{4} nrProdusePreparate: {5}",
                idProdus.ToString(),
                (Nume ?? " NECUNOSCUT "),
                Pret.ToString(),
                gramaj.ToString(),
                Cod.ToString(),
                (Descriere ?? " NECUNOSCUT "),
                NrProdusePreparate.ToString());
            return info;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectProdusPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                idProdus.ToString(),
                (Nume ?? " NECUNOSCUT "),
                Pret.ToString(),
                gramaj.ToString(),
                Cod.ToString(),
                (Descriere ?? " NECUNOSCUT "),
                NrProdusePreparate.ToString());

            return obiectProdusPentruFisier;
        }
        public int GetIdProdus()
        {
            return idProdus;
        }
        public string GetNume()
        {
            return Nume;
        }
        public float GetPret()
        {
            return Pret;
        }
        public int GetGramaj()
        {
            return gramaj;
        }
        public int GetCod()
        {
            return Cod;
        }
        public string GetDescriere()
        {
            return Descriere;
        }
        public int GetNrProdusePreparate()
        {
            return NrProdusePreparate;
        }
        public void SetIdStudent(int idProdus)
        {
            this.idProdus = idProdus;
        }

    }
}


