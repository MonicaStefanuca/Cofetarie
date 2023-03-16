using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public class Produs
{
    public static int NextID { get; set; } = 0;
    public string Nume { get; set; }
    public string Descriere { get; set; }
    public int gramaj { get; set; }
    public int Pret { get; set; }
    public int Cod { get; set; }
    public int NrProdusePreparate { get; set; }
    public int NrProdueCumparate { get; set; }
    public int NrProduseDisponibile { get { return NrProdusePreparate - NrProdueCumparate; } }

    public Produs(string _nume = "", int _pret, int _gramaj, int _cod, string _descriere= "", int _nrProdusePreparate)
	{
        Nume = _nume;
        Pret = _pret;
        gramaj = _gramaj;
        Cod = _cod;
        Descriere = _descriere;
        NrProdusePreparate = _nrProdusePreparate;
        NrProdueCumparate = 0;
	}

}
