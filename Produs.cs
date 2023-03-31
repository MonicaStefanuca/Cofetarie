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
        private const int DESCRIERE = 4;
        private const int NRPRODUSEPREPARATE = 5;

        public int idProdus;
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public int gramaj { get; set; }
        public float Pret { get; set; }
        public int NrProdusePreparate { get; set; }
        public int NrProdueCumparate { get; set; }
        public int NrProduseDisponibile { get { return NrProdusePreparate - NrProdueCumparate; } }

        //constructor implicit
        public Produs()
        {
            Nume = string.Empty;
        }
        //constructor cu parametrii
        public Produs(int IdProdus, string _nume , float _pret, int _gramaj, string _descriere, int _nrProdusePreparate)
        {
            idProdus = IdProdus;
            Nume = _nume;
            Pret = _pret;
            gramaj = _gramaj;
            Descriere = _descriere;
            NrProdusePreparate = _nrProdusePreparate;
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
            Descriere = dateFisier[DESCRIERE];
            NrProdusePreparate = Convert.ToInt32(dateFisier[NRPRODUSEPREPARATE]);
        }
        public string Info()
        {
            string info = string.Format("id: {0} nume:{1} pret:{2} Gramaj: {3}  descriere:{4} nrProdusePreparate: {5}",
                idProdus.ToString(),
                (Nume ?? " NECUNOSCUT "),
                Pret.ToString(),
                gramaj.ToString(),
                (Descriere ?? " NECUNOSCUT "),
                NrProdusePreparate.ToString());
            return info;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectProdusPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}",
                SEPARATOR_PRINCIPAL_FISIER,
                idProdus.ToString(),
                (Nume ?? " NECUNOSCUT "),
                Pret.ToString(),
                gramaj.ToString(),
                (Descriere ?? " NECUNOSCUT "),
                NrProdusePreparate.ToString());

            return obiectProdusPentruFisier;
        }
        public void SetIdProdus(int idProdus)
        {
            this.idProdus = idProdus;
        }

    }
}


