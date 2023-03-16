using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public class Client
{
    public string Nume { get; set; }
    public string Prenume { get; set; }
    public string NrTelefon { get; set; }
    public string Adresa { get; set; }
    public List<Produs> CosCumparaturi { get; set; }
    public Client(string nume,string prenume, string nrTelefon, string adresa)
	{
        Nume = nume;
        Prenume = prenume;
        NrTelefon = nrTelefon;
        Adresa = adresa;
        CosCumparaturi = new List<Produs>();
    }
    public decimal CalculeazaTotal()
    {

    }
    public void AdaugaProdus(Produs produs)
    {
    }
    public void StergeProdus(Produs produs)
    {
    }
    public void GolesteCosCumparaturi()
    {
    }
}
